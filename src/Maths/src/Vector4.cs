﻿using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace Silk.NET.Numerics
{
    /// <summary>A structure encapsulating four single precision floating point values and provides hardware accelerated methods.</summary>
    public struct Vector4<T>
        : IEquatable<Vector4<T>>, IFormattable
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        /// <summary>The X component of the vector.</summary>
        public T X;

        /// <summary>The Y component of the vector.</summary>
        public T Y;

        /// <summary>The Z component of the vector.</summary>
        public T Z;

        /// <summary>The W component of the vector.</summary>
        public T W;

        /// <summary>Constructs a vector whose elements are all the single specified value.</summary>
        /// <param name="value">The element to fill the vector with.</param>
        public Vector4(T value) => (X, Y, Z, W) = (value, value, value, value);

        /// <summary>Constructs a Vector4 from the given Vector2 and a Z and W component.</summary>
        /// <param name="value">The vector to use as the X and Y components.</param>
        /// <param name="z">The Z component.</param>
        /// <param name="w">The W component.</param>
        public Vector4(Vector2<T> value, T z, T w) => (X, Y, Z, W) = (value.X, value.Y, z, w);

        /// <summary>Constructs a Vector4 from the given Vector3 and a W component.</summary>
        /// <param name="value">The vector to use as the X, Y, and Z components.</param>
        /// <param name="w">The W component.</param>
        public Vector4(Vector3<T> value, T w) => (X, Y, Z, W) = (value.X, value.Y, value.Z, w);

        /// <summary>Constructs a vector with the given individual elements.</summary>
        /// <param name="w">W component.</param>
        /// <param name="x">X component.</param>
        /// <param name="y">Y component.</param>
        /// <param name="z">Z component.</param>
        public Vector4(T x, T y, T z, T w) => (X, Y, Z, W) = (x, y, z, w);

        /// <summary>Returns the vector (0,0,0,0).</summary>
        public static Vector4<T> Zero => default;

        /// <summary>Returns the vector (1,1,1,1).</summary>
        public static Vector4<T> One => new(Constants<T>.One);

        /// <summary>Returns the vector (1,0,0,0).</summary>
        public static Vector4<T> UnitX => new(Constants<T>.One, Constants<T>.Zero, Constants<T>.Zero, Constants<T>.Zero);

        /// <summary>Returns the vector (0,1,0,0).</summary>
        public static Vector4<T> UnitY => new(Constants<T>.Zero, Constants<T>.One, Constants<T>.Zero, Constants<T>.Zero);

        /// <summary>Returns the vector (0,0,1,0).</summary>
        public static Vector4<T> UnitZ => new(Constants<T>.Zero, Constants<T>.Zero, Constants<T>.One, Constants<T>.Zero);

        /// <summary>Returns the vector (0,0,0,1).</summary>
        public static Vector4<T> UnitW => new(Constants<T>.Zero, Constants<T>.Zero, Constants<T>.Zero, Constants<T>.One);

        /// <summary>Adds two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The summed vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> operator +(Vector4<T> left, Vector4<T> right)
            => new(Operations.Add(left.X, right.X), Operations.Add(left.Y, right.Y), Operations.Add(left.Z, right.Z),
                Operations.Add(left.W, right.W));

        /// <summary>Divides the first vector by the second.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The vector resulting from the division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> operator /(Vector4<T> left, Vector4<T> right)
            => new(Operations.Divide(left.X, right.X), Operations.Divide(left.Y, right.Y), Operations.Divide(left.Z, right.Z),
                Operations.Divide(left.W, right.W));

        /// <summary>Divides the vector by the given scalar.</summary>
        /// <param name="value1">The source vector.</param>
        /// <param name="value2">The scalar value.</param>
        /// <returns>The result of the division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> operator /(Vector4<T> value1, T value2)
            => new(Operations.Divide(value1.X, value2), Operations.Divide(value1.Y, value2),
                Operations.Divide(value1.Z, value2), Operations.Divide(value1.W, value2));

        /// <summary>Returns a boolean indicating whether the two given vectors are equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns>True if the vectors are equal; False otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4<T> left, Vector4<T> right)
            => Operations.Equal(left.X, right.X)
            && Operations.Equal(left.Y, right.Y)
            && Operations.Equal(left.Z, right.Z)
            && Operations.Equal(left.W, right.W);

        /// <summary>Returns a boolean indicating whether the two given vectors are not equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns>True if the vectors are not equal; False if they are equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4<T> left, Vector4<T> right) 
            => !(left == right);

        /// <summary>Multiplies two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The product vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> operator *(Vector4<T> left, Vector4<T> right)
            => new(Operations.Multiply(left.X, right.X), Operations.Multiply(left.Y, right.Y),
                Operations.Multiply(left.Z, right.Z), Operations.Multiply(left.W, right.W));

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The source vector.</param>
        /// <param name="right">The scalar value.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> operator *(Vector4<T> left, T right)
            => new(Operations.Multiply(left.X, right), Operations.Multiply(left.Y, right),
                Operations.Multiply(left.Z, right), Operations.Multiply(left.W, right));

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The scalar value.</param>
        /// <param name="right">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> operator *(T left, Vector4<T> right) 
            => right * left;

        /// <summary>Subtracts the second vector from the first.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The difference vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> operator -(Vector4<T> left, Vector4<T> right)
            => new(Operations.Subtract(left.X, right.X), Operations.Subtract(left.Y, right.Y),
                Operations.Subtract(left.Z, right.Z), Operations.Subtract(left.W, right.W));

        /// <summary>Negates a given vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The negated vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> operator -(Vector4<T> value) => Zero - value;

        /// <summary>Returns a vector whose elements are the absolute values of each of the source vector's elements.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The absolute value vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> Abs(Vector4<T> value) => new(
            Operations.Abs(value.X),
            Operations.Abs(value.Y),
            Operations.Abs(value.Z),
            Operations.Abs(value.W)
        );

        /// <summary>Adds two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The summed vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> Add(Vector4<T> left, Vector4<T> right) 
            => left + right;

        /// <summary>Restricts a vector between a min and max value.</summary>
        /// <param name="value1">The source vector.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The restricted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> Clamp(Vector4<T> value1, Vector4<T> min, Vector4<T> max)
            // We must follow HLSL behavior in the case user specified min value is bigger than max value.
            => Min(Max(value1, min), max);

        /// <summary>Returns the Euclidean distance between the two given points.</summary>
        /// <param name="value1">The first point.</param>
        /// <param name="value2">The second point.</param>
        /// <returns>The distance.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Distance(Vector4<T> value1, Vector4<T> value2) 
            => Operations.Sqrt(DistanceSquared(value1, value2));

        /// <summary>Returns the Euclidean distance squared between the two given points.</summary>
        /// <param name="value1">The first point.</param>
        /// <param name="value2">The second point.</param>
        /// <returns>The distance squared.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T DistanceSquared(Vector4<T> value1, Vector4<T> value2)
        {
            var difference = value1 - value2;
            return Dot(difference, difference);
        }

        /// <summary>Divides the first vector by the second.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The vector resulting from the division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> Divide(Vector4<T> left, Vector4<T> right) 
            => left / right;

        /// <summary>Divides the vector by the given scalar.</summary>
        /// <param name="left">The source vector.</param>
        /// <param name="divisor">The scalar value.</param>
        /// <returns>The result of the division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> Divide(Vector4<T> left, T divisor) 
            => left / divisor;

        /// <summary>Returns the dot product of two vectors.</summary>
        /// <param name="vector1">The first vector.</param>
        /// <param name="vector2">The second vector.</param>
        /// <returns>The dot product.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Dot(Vector4<T> vector1, Vector4<T> vector2)
            => Operations.Add(
                Operations.Add(
                    Operations.Add(Operations.Multiply(vector1.X, vector2.X),
                        Operations.Multiply(vector1.Y, vector2.Y)), Operations.Multiply(vector1.Z, vector2.Z)),
                Operations.Multiply(vector1.W, vector2.W));

        /// <summary>Linearly interpolates between two vectors based on the given weighting.</summary>
        /// <param name="value1">The first source vector.</param>
        /// <param name="value2">The second source vector.</param>
        /// <param name="amount">Value between 0 and 1 indicating the weight of the second source vector.</param>
        /// <returns>The interpolated vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> Lerp(Vector4<T> value1, Vector4<T> value2, T amount) 
            => (value1 * Operations.Subtract(Constants<T>.One, amount)) + (value2 * amount);

        /// <summary>Returns a vector whose elements are the maximum of each of the pairs of elements in the two source vectors.</summary>
        /// <param name="value1">The first source vector.</param>
        /// <param name="value2">The second source vector.</param>
        /// <returns>The maximized vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> Max(Vector4<T> value1, Vector4<T> value2)
            => new(Operations.Max(value1.X, value2.X), Operations.Max(value1.Y, value2.Y),
                Operations.Max(value1.Z, value2.Z), Operations.Max(value1.W, value2.W));

        /// <summary>Returns a vector whose elements are the minimum of each of the pairs of elements in the two source vectors.</summary>
        /// <param name="value1">The first source vector.</param>
        /// <param name="value2">The second source vector.</param>
        /// <returns>The minimized vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> Min(Vector4<T> value1, Vector4<T> value2)
            => new(Operations.Min(value1.X, value2.X), Operations.Min(value1.Y, value2.Y),
                Operations.Min(value1.Z, value2.Z), Operations.Min(value1.W, value2.W));

        /// <summary>Multiplies two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The product vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> Multiply(Vector4<T> left, Vector4<T> right) 
            => left * right;

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The source vector.</param>
        /// <param name="right">The scalar value.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> Multiply(Vector4<T> left, T right) 
            => left * right;

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The scalar value.</param>
        /// <param name="right">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> Multiply(T left, Vector4<T> right) 
            => left * right;

        /// <summary>Negates a given vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The negated vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> Negate(Vector4<T> value) 
            => -value;

        /// <summary>Returns a vector with the same direction as the given vector, but with a length of 1.</summary>
        /// <param name="vector">The vector to normalize.</param>
        /// <returns>The normalized vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> Normalize(Vector4<T> vector) 
            => vector / vector.Length();

        /// <summary>Returns a vector whose elements are the square root of each of the source vector's elements.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The square root vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> SquareRoot(Vector4<T> value)
        {
            return new(Operations.Sqrt(value.X), Operations.Sqrt(value.Y), Operations.Sqrt(value.Z),
                Operations.Sqrt(value.W));
        }

        /// <summary>Subtracts the second vector from the first.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The difference vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> Subtract(Vector4<T> left, Vector4<T> right)
            => left - right;

        // TODO: Matrix4x4
        /*
        /// <summary>Transforms a vector by the given matrix.</summary>
        /// <param name="position">The source vector.</param>
        /// <param name="matrix">The transformation matrix.</param>
        /// <returns>The transformed vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4<T> Transform(Vector2<T> position, Matrix4x4<T> matrix)
        {
            return new(
                (position.X * matrix.M11) + (position.Y * matrix.M21) + matrix.M41,
                (position.X * matrix.M12) + (position.Y * matrix.M22) + matrix.M42,
                (position.X * matrix.M13) + (position.Y * matrix.M23) + matrix.M43,
                (position.X * matrix.M14) + (position.Y * matrix.M24) + matrix.M44
            );
        }
*/
        // TODO: Quaternion
        /*
        /// <summary>Transforms a vector by the given Quaternion rotation value.</summary>
        /// <param name="value">The source vector to be rotated.</param>
        /// <param name="rotation">The rotation to apply.</param>
        /// <returns>The transformed vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Transform(Vector2 value, Quaternion rotation)
        {
            float x2 = rotation.X + rotation.X;
            float y2 = rotation.Y + rotation.Y;
            float z2 = rotation.Z + rotation.Z;

            float wx2 = rotation.W * x2;
            float wy2 = rotation.W * y2;
            float wz2 = rotation.W * z2;
            float xx2 = rotation.X * x2;
            float xy2 = rotation.X * y2;
            float xz2 = rotation.X * z2;
            float yy2 = rotation.Y * y2;
            float yz2 = rotation.Y * z2;
            float zz2 = rotation.Z * z2;

            return new Vector4(
                value.X * (1.0f - yy2 - zz2) + value.Y * (xy2 - wz2),
                value.X * (xy2 + wz2) + value.Y * (1.0f - xx2 - zz2),
                value.X * (xz2 - wy2) + value.Y * (yz2 + wx2),
                1.0f
            );
        }
*/
        // TODO: Matrix4x4
        /*
        /// <summary>Transforms a vector by the given matrix.</summary>
        /// <param name="position">The source vector.</param>
        /// <param name="matrix">The transformation matrix.</param>
        /// <returns>The transformed vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Transform(Vector3 position, Matrix4x4 matrix)
        {
            return new Vector4(
                (position.X * matrix.M11) + (position.Y * matrix.M21) + (position.Z * matrix.M31) + matrix.M41,
                (position.X * matrix.M12) + (position.Y * matrix.M22) + (position.Z * matrix.M32) + matrix.M42,
                (position.X * matrix.M13) + (position.Y * matrix.M23) + (position.Z * matrix.M33) + matrix.M43,
                (position.X * matrix.M14) + (position.Y * matrix.M24) + (position.Z * matrix.M34) + matrix.M44
            );
        }
*/
        // TODO: Quaternion
        /*
        /// <summary>Transforms a vector by the given Quaternion rotation value.</summary>
        /// <param name="value">The source vector to be rotated.</param>
        /// <param name="rotation">The rotation to apply.</param>
        /// <returns>The transformed vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Transform(Vector3 value, Quaternion rotation)
        {
            float x2 = rotation.X + rotation.X;
            float y2 = rotation.Y + rotation.Y;
            float z2 = rotation.Z + rotation.Z;

            float wx2 = rotation.W * x2;
            float wy2 = rotation.W * y2;
            float wz2 = rotation.W * z2;
            float xx2 = rotation.X * x2;
            float xy2 = rotation.X * y2;
            float xz2 = rotation.X * z2;
            float yy2 = rotation.Y * y2;
            float yz2 = rotation.Y * z2;
            float zz2 = rotation.Z * z2;

            return new Vector4(
                value.X * (1.0f - yy2 - zz2) + value.Y * (xy2 - wz2) + value.Z * (xz2 + wy2),
                value.X * (xy2 + wz2) + value.Y * (1.0f - xx2 - zz2) + value.Z * (yz2 - wx2),
                value.X * (xz2 - wy2) + value.Y * (yz2 + wx2) + value.Z * (1.0f - xx2 - yy2),
                1.0f
            );
        }
*/
        // TODO: Matrix4x4
        /*
        /// <summary>Transforms a vector by the given matrix.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="matrix">The transformation matrix.</param>
        /// <returns>The transformed vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Transform(Vector4 vector, Matrix4x4 matrix)
        {
            return new Vector4(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21) + (vector.Z * matrix.M31) + (vector.W * matrix.M41),
                (vector.X * matrix.M12) + (vector.Y * matrix.M22) + (vector.Z * matrix.M32) + (vector.W * matrix.M42),
                (vector.X * matrix.M13) + (vector.Y * matrix.M23) + (vector.Z * matrix.M33) + (vector.W * matrix.M43),
                (vector.X * matrix.M14) + (vector.Y * matrix.M24) + (vector.Z * matrix.M34) + (vector.W * matrix.M44)
            );
        }
*/
        // TODO: Quaternion
/*
        /// <summary>Transforms a vector by the given Quaternion rotation value.</summary>
        /// <param name="value">The source vector to be rotated.</param>
        /// <param name="rotation">The rotation to apply.</param>
        /// <returns>The transformed vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Transform(Vector4 value, Quaternion rotation)
        {
            float x2 = rotation.X + rotation.X;
            float y2 = rotation.Y + rotation.Y;
            float z2 = rotation.Z + rotation.Z;

            float wx2 = rotation.W * x2;
            float wy2 = rotation.W * y2;
            float wz2 = rotation.W * z2;
            float xx2 = rotation.X * x2;
            float xy2 = rotation.X * y2;
            float xz2 = rotation.X * z2;
            float yy2 = rotation.Y * y2;
            float yz2 = rotation.Y * z2;
            float zz2 = rotation.Z * z2;

            return new Vector4(
                value.X * (1.0f - yy2 - zz2) + value.Y * (xy2 - wz2) + value.Z * (xz2 + wy2),
                value.X * (xy2 + wz2) + value.Y * (1.0f - xx2 - zz2) + value.Z * (yz2 - wx2),
                value.X * (xz2 - wy2) + value.Y * (yz2 + wx2) + value.Z * (1.0f - xx2 - yy2),
                value.W);
        }*/

        /// <summary>Copies the contents of the vector into the given array.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(T[] array) 
            => CopyTo(array, 0);

        /// <summary>Copies the contents of the vector into the given array, starting from index.</summary>
        /// <exception cref="ArgumentNullException">If array is null.</exception>
        /// <exception cref="RankException">If array is multidimensional.</exception>
        /// <exception cref="ArgumentOutOfRangeException">If index is greater than end of the array or index is less than zero.</exception>
        /// <exception cref="ArgumentException">If number of elements in source vector is greater than those available in destination array.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(T[] array, int index)
        {
            if (array is null)
            {
                throw new NullReferenceException("Object reference not set to an instance of an object.");
            }

            if ((index < 0) || (index >= array.Length))
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Specified argument was out of the range of valid values.");
            }

            if ((array.Length - index) < 4)
            {
                throw new ArgumentException("Value does not fall within the expected range.");
            }

            array[index] = X;
            array[index + 1] = Y;
            array[index + 2] = Z;
            array[index + 3] = W;
        }

        /// <summary>Returns a boolean indicating whether the given Vector4 is equal to this Vector4 instance.</summary>
        /// <param name="other">The Vector4 to compare this instance to.</param>
        /// <returns>True if the other Vector4 is equal to this instance; False otherwise.</returns>
        public readonly bool Equals(Vector4<T> other) 
            => this == other;

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Vector4 instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Vector4; False otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj) 
            => (obj is Vector4<T> other) && Equals(other);

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override readonly int GetHashCode() 
            => HashCode.Combine(X, Y, Z, W);

        /// <summary>Returns the length of the vector. This operation is cheaper than Length().</summary>
        /// <returns>The vector's length.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly T Length()
            => Operations.Sqrt(LengthSquared());

        /// <summary>Returns the length of the vector squared.</summary>
        /// <returns>The vector's length squared.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly T LengthSquared()
            => Dot(this, this);

        /// <summary>Returns a String representing this Vector4 instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString()
        {
            return ToString("G", CultureInfo.CurrentCulture);
        }

        /// <summary>Returns a String representing this Vector4 instance, using the specified format to format individual elements.</summary>
        /// <param name="format">The format of individual elements.</param>
        /// <returns>The string representation.</returns>
        public readonly string ToString(string? format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
        }

        /// <summary>Returns a String representing this Vector4 instance, using the specified format to format individual elements
        /// and the given IFormatProvider.</summary>
        /// <param name="format">The format of individual elements.</param>
        /// <param name="formatProvider">The format provider to use when formatting elements.</param>
        /// <returns>The string representation.</returns>
        public readonly string ToString(string? format, IFormatProvider? formatProvider)
        {
            StringBuilder sb = new();
            string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
            sb.Append('<');
            sb.Append(X.ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(Y.ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(Z.ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(W.ToString(format, formatProvider));
            sb.Append('>');
            return sb.ToString();
        }
    }
}
