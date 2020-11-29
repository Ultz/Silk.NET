﻿using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace Silk.NET.Maths
{
    /// <summary>A structure encapsulating a 4x4 matrix.</summary>
    public struct Matrix2x4<T> : IEquatable<Matrix2x4<T>>
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        private const float BillboardEpsilon = 1e-4f;
        private const float BillboardMinAngle = 1.0f - (0.1f * (MathF.PI / 180.0f)); // 0.1 degrees
        private const float DecomposeEpsilon = 0.0001f;

        private static readonly Matrix2x4<T> _identity = new
        (
            Scalar<T>.One, Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.Zero,
            Scalar<T>.Zero, Scalar<T>.One, Scalar<T>.Zero, Scalar<T>.Zero
        );

        /// <summary>Value at row 1, column 1 of the matrix.</summary>
        public T M11;

        /// <summary>Value at row 1, column 2 of the matrix.</summary>
        public T M12;

        /// <summary>Value at row 1, column 3 of the matrix.</summary>
        public T M13;

        /// <summary>Value at row 1, column 4 of the matrix.</summary>
        public T M14;

        /// <summary>Value at row 2, column 1 of the matrix.</summary>
        public T M21;

        /// <summary>Value at row 2, column 2 of the matrix.</summary>
        public T M22;

        /// <summary>Value at row 2, column 3 of the matrix.</summary>
        public T M23;

        /// <summary>Value at row 2, column 4 of the matrix.</summary>
        public T M24;

        /// <summary>Constructs a Matrix2x4 from the given components.</summary>
        public Matrix2x4(T m11, T m12, T m13, T m14,
                         T m21, T m22, T m23, T m24)
            => (M11, M12, M13, M14,
                M21, M22, M23, M24)
            =  (m11, m12, m13, m14,
                m21, m22, m23, m24);

        /// <summary>Constructs a Matrix2x4 from the given Matrix3x2.</summary>
        /// <param name="value">The source Matrix3x2.</param>
        public Matrix2x4(Matrix3x2<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;
            M13 = Scalar<T>.Zero;
            M14 = Scalar<T>.Zero;

            M21 = value.M21;
            M22 = value.M22;
            M23 = Scalar<T>.Zero;
            M24 = Scalar<T>.Zero;
        }

        /// <summary>Constructs a Matrix2x4 from the given Matrix4x3.</summary>
        /// <param name="value">The source Matrix4x3.</param>
        public Matrix2x4(Matrix4x3<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;
            M13 = value.M13;
            M14 = Scalar<T>.Zero;

            M21 = value.M21;
            M22 = value.M22;
            M23 = value.M23;
            M24 = Scalar<T>.Zero;
        }

        /// <summary>Constructs a Matrix2x4 from the given Matrix3x4.</summary>
        /// <param name="value">The source Matrix3x4.</param>
        public Matrix2x4(Matrix3x4<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;
            M13 = value.M13;
            M14 = value.M14;

            M21 = value.M21;
            M22 = value.M22;
            M23 = value.M23;
            M24 = value.M24;
        }

        /// <summary>Constructs a Matrix2x4 from the given Matrix3x3.</summary>
        /// <param name="value">The source Matrix3x3.</param>
        public Matrix2x4(Matrix3x3<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;
            M13 = value.M13;
            M14 = Scalar<T>.Zero;

            M21 = value.M21;
            M22 = value.M22;
            M23 = value.M23;
            M24 = Scalar<T>.Zero;
        }
        
        /// <summary>Constructs a Matrix4x4 from the given Matrix3x4.</summary>
        /// <param name="value">The source Matrix3x4.</param>
        public Matrix2x4(Matrix4x2<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;
            M13 = Scalar<T>.Zero;
            M14 = Scalar<T>.Zero;

            M21 = value.M21;
            M22 = value.M22;
            M23 = Scalar<T>.Zero;
            M24 = Scalar<T>.Zero;
        }

        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix2x4<T> Identity => _identity;

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        public readonly bool IsIdentity
            => Scalar.Equal(M11, Scalar<T>.One) &&
               Scalar.Equal(M22, Scalar<T>.One) && // Check diagonal element first for early out.
               Scalar.Equal(M12, Scalar<T>.Zero) && Scalar.Equal(M13, Scalar<T>.Zero) &&
               Scalar.Equal(M14, Scalar<T>.Zero) && Scalar.Equal(M21, Scalar<T>.Zero) &&
               Scalar.Equal(M23, Scalar<T>.Zero) && Scalar.Equal(M24, Scalar<T>.Zero);

        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        public static unsafe Matrix2x4<T> operator +(Matrix2x4<T> value1, Matrix2x4<T> value2)
        {
            Matrix2x4<T> m;

            m.M11 = Scalar.Add(value1.M11, value2.M11);
            m.M12 = Scalar.Add(value1.M12, value2.M12);
            m.M13 = Scalar.Add(value1.M13, value2.M13);
            m.M14 = Scalar.Add(value1.M14, value2.M14);
            m.M21 = Scalar.Add(value1.M21, value2.M21);
            m.M22 = Scalar.Add(value1.M22, value2.M22);
            m.M23 = Scalar.Add(value1.M23, value2.M23);
            m.M24 = Scalar.Add(value1.M24, value2.M24);
            
            return m;
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are equal; False otherwise.</returns>
        public static unsafe bool operator ==(Matrix2x4<T> value1, Matrix2x4<T> value2)
        {
            return Scalar.Equal(value1.M11, value2.M11) &&
                   Scalar.Equal(value1.M22, value2.M22) && // Check diagonal elements first for early out.
                   Scalar.Equal(value1.M12, value2.M12) && Scalar.Equal(value1.M13, value2.M13) &&
                   Scalar.Equal(value1.M14, value2.M14) && Scalar.Equal(value1.M21, value2.M21) &&
                   Scalar.Equal(value1.M23, value2.M23) && Scalar.Equal(value1.M24, value2.M24);
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are not equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are not equal; False if they are equal.</returns>
        public static unsafe bool operator !=(Matrix2x4<T> value1, Matrix2x4<T> value2)
        {
            return Scalar.NotEqual(value1.M11, value2.M11) ||
                   Scalar.NotEqual(value1.M22, value2.M22) || // Check diagonal elements first for early out.
                   Scalar.NotEqual(value1.M12, value2.M12) || Scalar.NotEqual(value1.M13, value2.M13) ||
                   Scalar.NotEqual(value1.M14, value2.M14) || Scalar.NotEqual(value1.M21, value2.M21) ||
                   Scalar.NotEqual(value1.M23, value2.M23) || Scalar.NotEqual(value1.M24, value2.M24);
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix2x4<T> operator *(Matrix2x4<T> value1, Matrix4x4<T> value2)
        {
            Matrix2x4<T> m;

            // First row
            m.M11 = Scalar.Add(Scalar.Add(Scalar.Multiply(value1.M11, value2.M11), Scalar.Multiply(value1.M12, value2.M21)), Scalar.Add(Scalar.Multiply(value1.M13, value2.M31), Scalar.Multiply(value1.M14, value2.M41)));
            m.M12 = Scalar.Add(Scalar.Add(Scalar.Multiply(value1.M11, value2.M12), Scalar.Multiply(value1.M12, value2.M22)), Scalar.Add(Scalar.Multiply(value1.M13, value2.M32), Scalar.Multiply(value1.M14, value2.M42)));
            m.M13 = Scalar.Add(Scalar.Add(Scalar.Multiply(value1.M11, value2.M13), Scalar.Multiply(value1.M12, value2.M23)), Scalar.Add(Scalar.Multiply(value1.M13, value2.M33), Scalar.Multiply(value1.M14, value2.M43)));
            m.M14 = Scalar.Add(Scalar.Add(Scalar.Multiply(value1.M11, value2.M14), Scalar.Multiply(value1.M12, value2.M24)), Scalar.Add(Scalar.Multiply(value1.M13, value2.M34), Scalar.Multiply(value1.M14, value2.M44)));

            // Second row
            m.M21 = Scalar.Add(Scalar.Add(Scalar.Multiply(value1.M21, value2.M11), Scalar.Multiply(value1.M22, value2.M21)), Scalar.Add(Scalar.Multiply(value1.M23, value2.M31), Scalar.Multiply(value1.M24, value2.M41)));
            m.M22 = Scalar.Add(Scalar.Add(Scalar.Multiply(value1.M21, value2.M12), Scalar.Multiply(value1.M22, value2.M22)), Scalar.Add(Scalar.Multiply(value1.M23, value2.M32), Scalar.Multiply(value1.M24, value2.M42)));
            m.M23 = Scalar.Add(Scalar.Add(Scalar.Multiply(value1.M21, value2.M13), Scalar.Multiply(value1.M22, value2.M23)), Scalar.Add(Scalar.Multiply(value1.M23, value2.M33), Scalar.Multiply(value1.M24, value2.M43)));
            m.M24 = Scalar.Add(Scalar.Add(Scalar.Multiply(value1.M21, value2.M14), Scalar.Multiply(value1.M22, value2.M24)), Scalar.Add(Scalar.Multiply(value1.M23, value2.M34), Scalar.Multiply(value1.M24, value2.M44)));
            
            return m;
        }
        
        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Vector4<T> operator *(Vector2<T> value1, Matrix2x4<T> value2)
        {
            Vector4<T> m;

            // First row
            m.X = Scalar.Add(Scalar.Multiply(value1.X, value2.M11), Scalar.Multiply(value1.Y, value2.M21));
            m.Y = Scalar.Add(Scalar.Multiply(value1.X, value2.M12), Scalar.Multiply(value1.Y, value2.M22));
            m.Z = Scalar.Add(Scalar.Multiply(value1.X, value2.M13), Scalar.Multiply(value1.Y, value2.M23));
            m.W = Scalar.Add(Scalar.Multiply(value1.X, value2.M14), Scalar.Multiply(value1.Y, value2.M24));

            return m;
        }
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix2x3<T> operator *(Matrix2x4<T> value1, Matrix4x3<T> value2)
        {
            Matrix2x3<T> m;

            // First row
            m.M11 = Scalar.Add(Scalar.Add(Scalar.Multiply(value1.M11, value2.M11), Scalar.Multiply(value1.M12, value2.M21)), Scalar.Add(Scalar.Multiply(value1.M13, value2.M31), Scalar.Multiply(value1.M14, value2.M41)));
            m.M12 = Scalar.Add(Scalar.Add(Scalar.Multiply(value1.M11, value2.M12), Scalar.Multiply(value1.M12, value2.M22)), Scalar.Add(Scalar.Multiply(value1.M13, value2.M32), Scalar.Multiply(value1.M14, value2.M42)));
            m.M13 = Scalar.Add(Scalar.Add(Scalar.Multiply(value1.M11, value2.M13), Scalar.Multiply(value1.M12, value2.M23)), Scalar.Add(Scalar.Multiply(value1.M13, value2.M33), Scalar.Multiply(value1.M14, value2.M43)));

            // Second row
            m.M21 = Scalar.Add(Scalar.Add(Scalar.Multiply(value1.M21, value2.M11), Scalar.Multiply(value1.M22, value2.M21)), Scalar.Add(Scalar.Multiply(value1.M23, value2.M31), Scalar.Multiply(value1.M24, value2.M41)));
            m.M22 = Scalar.Add(Scalar.Add(Scalar.Multiply(value1.M21, value2.M12), Scalar.Multiply(value1.M22, value2.M22)), Scalar.Add(Scalar.Multiply(value1.M23, value2.M32), Scalar.Multiply(value1.M24, value2.M42)));
            m.M23 = Scalar.Add(Scalar.Add(Scalar.Multiply(value1.M21, value2.M13), Scalar.Multiply(value1.M22, value2.M23)), Scalar.Add(Scalar.Multiply(value1.M23, value2.M33), Scalar.Multiply(value1.M24, value2.M43)));

            return m;
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix3x4<T> operator *(Matrix3x2<T> value1, Matrix2x4<T> value2)
        {
            Matrix3x4<T> m;

            // First row
            m.M11 = Scalar.Add(Scalar.Multiply(value1.M11, value2.M11), Scalar.Multiply(value1.M12, value2.M21));
            m.M12 = Scalar.Add(Scalar.Multiply(value1.M11, value2.M12), Scalar.Multiply(value1.M12, value2.M22));
            m.M13 = Scalar.Add(Scalar.Multiply(value1.M11, value2.M13), Scalar.Multiply(value1.M12, value2.M23));
            m.M14 = Scalar.Add(Scalar.Multiply(value1.M11, value2.M14), Scalar.Multiply(value1.M12, value2.M24));

            // Second row
            m.M21 = Scalar.Add(Scalar.Multiply(value1.M21, value2.M11), Scalar.Multiply(value1.M22, value2.M21));
            m.M22 = Scalar.Add(Scalar.Multiply(value1.M21, value2.M12), Scalar.Multiply(value1.M22, value2.M22));
            m.M23 = Scalar.Add(Scalar.Multiply(value1.M21, value2.M13), Scalar.Multiply(value1.M22, value2.M23));
            m.M24 = Scalar.Add(Scalar.Multiply(value1.M21, value2.M14), Scalar.Multiply(value1.M22, value2.M24));

            // Third row
            m.M31 = Scalar.Add(Scalar.Multiply(value1.M31, value2.M11), Scalar.Multiply(value1.M32, value2.M21));
            m.M32 = Scalar.Add(Scalar.Multiply(value1.M31, value2.M12), Scalar.Multiply(value1.M32, value2.M22));
            m.M33 = Scalar.Add(Scalar.Multiply(value1.M31, value2.M13), Scalar.Multiply(value1.M32, value2.M23));
            m.M34 = Scalar.Add(Scalar.Multiply(value1.M31, value2.M14), Scalar.Multiply(value1.M32, value2.M24));
            return m;
        }
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix2x4<T> operator *(Matrix2x2<T> value1, Matrix2x4<T> value2)
        {
            Matrix2x4<T> m;

            // First row
            m.M11 = Scalar.Add(Scalar.Multiply(value1.M11, value2.M11), Scalar.Multiply(value1.M12, value2.M21));
            m.M12 = Scalar.Add(Scalar.Multiply(value1.M11, value2.M12), Scalar.Multiply(value1.M12, value2.M22));
            m.M13 = Scalar.Add(Scalar.Multiply(value1.M11, value2.M13), Scalar.Multiply(value1.M12, value2.M23));
            m.M14 = Scalar.Add(Scalar.Multiply(value1.M11, value2.M14), Scalar.Multiply(value1.M12, value2.M24));

            // Second row
            m.M21 = Scalar.Add(Scalar.Multiply(value1.M21, value2.M11), Scalar.Multiply(value1.M22, value2.M21));
            m.M22 = Scalar.Add(Scalar.Multiply(value1.M21, value2.M12), Scalar.Multiply(value1.M22, value2.M22));
            m.M23 = Scalar.Add(Scalar.Multiply(value1.M21, value2.M13), Scalar.Multiply(value1.M22, value2.M23));
            m.M24 = Scalar.Add(Scalar.Multiply(value1.M21, value2.M14), Scalar.Multiply(value1.M22, value2.M24));

            return m;
        }
        
        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        public static unsafe Matrix2x4<T> operator *(Matrix2x4<T> value1, T value2)
        {
            Matrix2x4<T> m;

            m.M11 = Scalar.Multiply(value1.M11, value2);
            m.M12 = Scalar.Multiply(value1.M12, value2);
            m.M13 = Scalar.Multiply(value1.M13, value2);
            m.M14 = Scalar.Multiply(value1.M14, value2);
            m.M21 = Scalar.Multiply(value1.M21, value2);
            m.M22 = Scalar.Multiply(value1.M22, value2);
            m.M23 = Scalar.Multiply(value1.M23, value2);
            m.M24 = Scalar.Multiply(value1.M24, value2);
            

            return m;
        }

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static unsafe Matrix2x4<T> operator -(Matrix2x4<T> value1, Matrix2x4<T> value2)
        {
            Matrix2x4<T> m;

            m.M11 = Scalar.Subtract(value1.M11, value2.M11);
            m.M12 = Scalar.Subtract(value1.M12, value2.M12);
            m.M13 = Scalar.Subtract(value1.M13, value2.M13);
            m.M14 = Scalar.Subtract(value1.M14, value2.M14);
            m.M21 = Scalar.Subtract(value1.M21, value2.M21);
            m.M22 = Scalar.Subtract(value1.M22, value2.M22);
            m.M23 = Scalar.Subtract(value1.M23, value2.M23);
            m.M24 = Scalar.Subtract(value1.M24, value2.M24);
            
            return m;
        }

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static unsafe Matrix2x4<T> operator -(Matrix2x4<T> value)
        {
            Matrix2x4<T> m;

            m.M11 = Scalar.Negate(value.M11);
            m.M12 = Scalar.Negate(value.M12);
            m.M13 = Scalar.Negate(value.M13);
            m.M14 = Scalar.Negate(value.M14);
            m.M21 = Scalar.Negate(value.M21);
            m.M22 = Scalar.Negate(value.M22);
            m.M23 = Scalar.Negate(value.M23);
            m.M24 = Scalar.Negate(value.M24);
            
            return m;
        }

        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x4<T> Add(Matrix2x4<T> value1, Matrix2x4<T> value2)
        {
            return value1 + value2;
        }
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x4<T> Multiply(Matrix2x4<T> value1, Matrix4x4<T> value2)
            => value1 * value2;
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x3<T> Multiply(Matrix2x4<T> value1, Matrix4x3<T> value2)
            => value1 * value2;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x2<T> Multiply(Matrix2x4<T> value1, Matrix4x2<T> value2)
            => value1 * value2;
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix4x4<T> Multiply(Matrix4x2<T> value1, Matrix2x4<T> value2)
            => value1 * value2;
        
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x4<T> Multiply(Matrix3x2<T> value1, Matrix2x4<T> value2)
            => value1 * value2;
        
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x4<T> Multiply(Matrix2x2<T> value1, Matrix2x4<T> value2)
            => value1 * value2;
        
        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> Multiply(Vector2<T> value1, Matrix2x4<T> value2)
            => value1 * value2;
        
        /// <summary>Linearly interpolates between the corresponding values of two matrices.</summary>
        /// <param name="matrix1">The first source matrix.</param>
        /// <param name="matrix2">The second source matrix.</param>
        /// <param name="amount">The relative weight of the second source matrix.</param>
        /// <returns>The interpolated matrix.</returns>
        public static unsafe Matrix2x4<T> Lerp(Matrix2x4<T> matrix1, Matrix2x4<T> matrix2, T amount)
        {
            Matrix2x4<T> result;

            // First row
            result.M11 = Scalar.Add(matrix1.M11, Scalar.Multiply(Scalar.Subtract(matrix2.M11, matrix1.M11), amount));
            result.M12 = Scalar.Add(matrix1.M12, Scalar.Multiply(Scalar.Subtract(matrix2.M12, matrix1.M12), amount));
            result.M13 = Scalar.Add(matrix1.M13, Scalar.Multiply(Scalar.Subtract(matrix2.M13, matrix1.M13), amount));
            result.M14 = Scalar.Add(matrix1.M14, Scalar.Multiply(Scalar.Subtract(matrix2.M14, matrix1.M14), amount));

            // Second row
            result.M21 = Scalar.Add(matrix1.M21, Scalar.Multiply(Scalar.Subtract(matrix2.M21, matrix1.M21), amount));
            result.M22 = Scalar.Add(matrix1.M22, Scalar.Multiply(Scalar.Subtract(matrix2.M22, matrix1.M22), amount));
            result.M23 = Scalar.Add(matrix1.M23, Scalar.Multiply(Scalar.Subtract(matrix2.M23, matrix1.M23), amount));
            result.M24 = Scalar.Add(matrix1.M24, Scalar.Multiply(Scalar.Subtract(matrix2.M24, matrix1.M24), amount));

            return result;
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this matrix instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this matrix; False otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj)
            => (obj is Matrix2x4<T> other) && Equals(other);

        /// <summary>Returns a boolean indicating whether this matrix instance is equal to the other given matrix.</summary>
        /// <param name="other">The matrix to compare this instance to.</param>
        /// <returns>True if the matrices are equal; False otherwise.</returns>
        public readonly bool Equals(Matrix2x4<T> other)
            => this == other;

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>   
        public override readonly int GetHashCode()
        {
            HashCode hash = default;

            hash.Add(M11);
            hash.Add(M12);
            hash.Add(M13);
            hash.Add(M14);

            hash.Add(M21);
            hash.Add(M22);
            hash.Add(M23);
            hash.Add(M24);

            return hash.ToHashCode();
        }

        /// <summary>Returns a String representing this matrix instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "{{ {{M11:{0} M12:{1} M13:{2} M14:{3}}} {{M21:{4} M22:{5} M23:{6} M24:{7}}} }}",
                                 M11, M12, M13, M14,
                                 M21, M22, M23, M24);
        }
        
        /// <summary>
        /// Converts a <see cref="Matrix2x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="Half"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="Half"/> matrix</returns>
        public static explicit operator Matrix2x4<Half>(Matrix2x4<T> from)
            => new
            (
                Scalar.As<T, Half>(from.M11),Scalar.As<T, Half>(from.M12),
                Scalar.As<T, Half>(from.M13),Scalar.As<T, Half>(from.M14),
                Scalar.As<T, Half>(from.M21),Scalar.As<T, Half>(from.M22),
                Scalar.As<T, Half>(from.M23),Scalar.As<T, Half>(from.M24)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix2x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Matrix2x4<float>(Matrix2x4<T> from)
            => new
            (
                Scalar.As<T, float>(from.M11),Scalar.As<T, float>(from.M12),
                Scalar.As<T, float>(from.M13),Scalar.As<T, float>(from.M14),
                Scalar.As<T, float>(from.M21),Scalar.As<T, float>(from.M22),
                Scalar.As<T, float>(from.M23),Scalar.As<T, float>(from.M24)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix2x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Matrix2x4<double>(Matrix2x4<T> from)
            => new
            (
                Scalar.As<T, double>(from.M11),Scalar.As<T, double>(from.M12),
                Scalar.As<T, double>(from.M13),Scalar.As<T, double>(from.M14),
                Scalar.As<T, double>(from.M21),Scalar.As<T, double>(from.M22),
                Scalar.As<T, double>(from.M23),Scalar.As<T, double>(from.M24)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix2x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="decimal"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="decimal"/> matrix</returns>
        public static explicit operator Matrix2x4<decimal>(Matrix2x4<T> from)
            => new
            (
                Scalar.As<T, decimal>(from.M11),Scalar.As<T, decimal>(from.M12),
                Scalar.As<T, decimal>(from.M13),Scalar.As<T, decimal>(from.M14),
                Scalar.As<T, decimal>(from.M21),Scalar.As<T, decimal>(from.M22),
                Scalar.As<T, decimal>(from.M23),Scalar.As<T, decimal>(from.M24)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix2x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="sbyte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="sbyte"/> matrix</returns>
        public static explicit operator Matrix2x4<sbyte>(Matrix2x4<T> from)
            => new
            (
                Scalar.As<T, sbyte>(from.M11),Scalar.As<T, sbyte>(from.M12),
                Scalar.As<T, sbyte>(from.M13),Scalar.As<T, sbyte>(from.M14),
                Scalar.As<T, sbyte>(from.M21),Scalar.As<T, sbyte>(from.M22),
                Scalar.As<T, sbyte>(from.M23),Scalar.As<T, sbyte>(from.M24)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix2x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="byte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="byte"/> matrix</returns>
        public static explicit operator Matrix2x4<byte>(Matrix2x4<T> from)
            => new
            (
                Scalar.As<T, byte>(from.M11),Scalar.As<T, byte>(from.M12),
                Scalar.As<T, byte>(from.M13),Scalar.As<T, byte>(from.M14),
                Scalar.As<T, byte>(from.M21),Scalar.As<T, byte>(from.M22),
                Scalar.As<T, byte>(from.M23),Scalar.As<T, byte>(from.M24)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix2x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="ushort"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ushort"/> matrix</returns>
        public static explicit operator Matrix2x4<ushort>(Matrix2x4<T> from)
            => new
            (
                Scalar.As<T, ushort>(from.M11),Scalar.As<T, ushort>(from.M12),
                Scalar.As<T, ushort>(from.M13),Scalar.As<T, ushort>(from.M14),
                Scalar.As<T, ushort>(from.M21),Scalar.As<T, ushort>(from.M22),
                Scalar.As<T, ushort>(from.M23),Scalar.As<T, ushort>(from.M24)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix2x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="short"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="short"/> matrix</returns>
        public static explicit operator Matrix2x4<short>(Matrix2x4<T> from)
            => new
            (
                Scalar.As<T, short>(from.M11),Scalar.As<T, short>(from.M12),
                Scalar.As<T, short>(from.M13),Scalar.As<T, short>(from.M14),
                Scalar.As<T, short>(from.M21),Scalar.As<T, short>(from.M22),
                Scalar.As<T, short>(from.M23),Scalar.As<T, short>(from.M24)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix2x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="uint"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="uint"/> matrix</returns>
        public static explicit operator Matrix2x4<uint>(Matrix2x4<T> from)
            => new
            (
                Scalar.As<T, uint>(from.M11),Scalar.As<T, uint>(from.M12),
                Scalar.As<T, uint>(from.M13),Scalar.As<T, uint>(from.M14),
                Scalar.As<T, uint>(from.M21),Scalar.As<T, uint>(from.M22),
                Scalar.As<T, uint>(from.M23),Scalar.As<T, uint>(from.M24)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix2x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="int"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="int"/> matrix</returns>
        public static explicit operator Matrix2x4<int>(Matrix2x4<T> from)
            => new
            (
                Scalar.As<T, int>(from.M11),Scalar.As<T, int>(from.M12),
                Scalar.As<T, int>(from.M13),Scalar.As<T, int>(from.M14),
                Scalar.As<T, int>(from.M21),Scalar.As<T, int>(from.M22),
                Scalar.As<T, int>(from.M23),Scalar.As<T, int>(from.M24)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix2x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="ulong"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ulong"/> matrix</returns>
        public static explicit operator Matrix2x4<ulong>(Matrix2x4<T> from)
            => new
            (
                Scalar.As<T, ulong>(from.M11),Scalar.As<T, ulong>(from.M12),
                Scalar.As<T, ulong>(from.M13),Scalar.As<T, ulong>(from.M14),
                Scalar.As<T, ulong>(from.M21),Scalar.As<T, ulong>(from.M22),
                Scalar.As<T, ulong>(from.M23),Scalar.As<T, ulong>(from.M24)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix2x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="long"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="long"/> matrix</returns>
        public static explicit operator Matrix2x4<long>(Matrix2x4<T> from)
            => new
            (
                Scalar.As<T, long>(from.M11),Scalar.As<T, long>(from.M12),
                Scalar.As<T, long>(from.M13),Scalar.As<T, long>(from.M14),
                Scalar.As<T, long>(from.M21),Scalar.As<T, long>(from.M22),
                Scalar.As<T, long>(from.M23),Scalar.As<T, long>(from.M24)
            );
    }
}