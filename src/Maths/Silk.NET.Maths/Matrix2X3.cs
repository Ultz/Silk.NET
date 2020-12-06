using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>A structure encapsulating a 4x4 matrix.</summary>
    [Serializable]
    [DataContract]
    public struct Matrix2X3<T> : IEquatable<Matrix2X3<T>>
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        private static readonly Matrix2X3<T> _identity = new
        (
            Scalar<T>.One, Scalar<T>.Zero, Scalar<T>.Zero,
            Scalar<T>.Zero, Scalar<T>.One, Scalar<T>.Zero
        );

        /// <summary>
        /// Row 1 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector3D<T> Row1;

        /// <summary>
        /// Row 2 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector3D<T> Row2;

        /// <summary>
        /// Column 1 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector2D<T> Column1 => new Vector2D<T>(M11, M21);

        /// <summary>
        /// Column 2 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector2D<T> Column2 => new Vector2D<T>(M12, M22);

        /// <summary>
        /// Column 3 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector2D<T> Column3 => new Vector2D<T>(M13, M23);

        /// <summary>Value at row 1, column 1 of the matrix.</summary>
        [DataMember]
        public T M11
        {
            readonly get => Row1.X;
            set => Row1.X = value;
        }

        /// <summary>Value at row 1, column 2 of the matrix.</summary>
        [DataMember]
        public T M12
        {
            readonly get => Row1.Y;
            set => Row1.Y = value;
        }

        /// <summary>Value at row 1, column 3 of the matrix.</summary>
        [DataMember]
        public T M13
        {
            readonly get => Row1.Z;
            set => Row1.Z = value;
        }

        /// <summary>Value at row 2, column 1 of the matrix.</summary>
        [DataMember]
        public T M21
        {
            readonly get => Row1.X;
            set => Row1.X = value;
        }

        /// <summary>Value at row 2, column 2 of the matrix.</summary>
        [DataMember]
        public T M22
        {
            readonly get => Row2.Y;
            set => Row2.Y = value;
        }

        /// <summary>Value at row 2, column 3 of the matrix.</summary>
        [DataMember]
        public T M23
        {
            readonly get => Row2.Z;
            set => Row2.Z = value;
        }

        /// <summary>
        /// Indexer for the rows of this matrix.
        /// </summary>
        /// <param name="x">The row to select. Zero based.</param>
        public unsafe Vector3D<T> this[int x]
        {
            get
            {
                static void VerifyBounds(int i)
                {
                    static void ThrowHelper() => throw new IndexOutOfRangeException();

                    if (i > 1 || i < 0)
                        ThrowHelper();
                }

                VerifyBounds(x);
                return Unsafe.Add(ref Row1, x);
            }
        }

        /// <summary>
        /// Indexer for the values in this matrix.
        /// </summary>
        /// <param name="x">The row to select. Zero based.</param>
        /// <param name="y">The column to select. Zero based.</param>
        public unsafe T this[int x, int y]
        {
            get
            {
                var row = this[x];
                return row[y];
            }
        }

        /// <summary>Constructs a Matrix2X3 from the given components.</summary>
        public Matrix2X3(T m11, T m12, T m13,
                         T m21, T m22, T m23)
        {
            Row1 = new(m11, m12, m13);
            Row2 = new(m21, m22, m23);
        }

        /// <summary>
        /// Constructs a Matrix2X3 from the given rows.
        /// </summary>
        public Matrix2X3(Vector3D<T> row1, Vector3D<T> row2)
        {
            Row1 = row1;
            Row2 = row2;
        }

        /// <summary>Constructs a Matrix2X3 from the given Matrix3X2.</summary>
        /// <param name="value">The source Matrix3X2.</param>
        public Matrix2X3(Matrix3X2<T> value)
        {
            Row1 = new(value.M11, value.M12, default);
            Row2 = new(value.M21, value.M22, default);
        }

        /// <summary>Constructs a Matrix2X3 from the given Matrix4X3.</summary>
        /// <param name="value">The source Matrix4X3.</param>
        public Matrix2X3(Matrix4X3<T> value)
        {
            Row1 = new Vector3D<T>(value.M11, value.M12, value.M13);
            Row2 = new Vector3D<T>(value.M21, value.M22, value.M23);
        }

        /// <summary>Constructs a Matrix2X3 from the given Matrix3X4.</summary>
        /// <param name="value">The source Matrix3X4.</param>
        public Matrix2X3(Matrix3X4<T> value)
        {
            Row1 = new Vector3D<T>(value.M11, value.M12, value.M13);
            Row2 = new Vector3D<T>(value.M21, value.M22, value.M23);
        }

        /// <summary>Constructs a Matrix4X4 from the given Matrix3X4.</summary>
        /// <param name="value">The source Matrix3X4.</param>
        public Matrix2X3(Matrix2X4<T> value)
        {
            Row1 = new Vector3D<T>(value.M11, value.M12, value.M13);
            Row2 = new Vector3D<T>(value.M21, value.M22, value.M23);
        }

        /// <summary>Constructs a Matrix4X4 from the given Matrix3X4.</summary>
        /// <param name="value">The source Matrix3X4.</param>
        public Matrix2X3(Matrix4X2<T> value)
        {
            Row1 = new Vector3D<T>(value.M11, value.M12, default);
            Row2 = new Vector3D<T>(value.M21, value.M22, default);
        }

        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix2X3<T> Identity => _identity;

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        [IgnoreDataMember]
        public readonly bool IsIdentity
            => Scalar.Equal(M11, Scalar<T>.One) &&
               Scalar.Equal(M22, Scalar<T>.One) && // Check diagonal element first for early out.
               Scalar.Equal(M12, Scalar<T>.Zero) && Scalar.Equal(M13, Scalar<T>.Zero) &&
               Scalar.Equal(M21, Scalar<T>.Zero) && Scalar.Equal(M23, Scalar<T>.Zero);

        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        public static unsafe Matrix2X3<T> operator +(Matrix2X3<T> value1, Matrix2X3<T> value2)
        {
            return new(value1.Row1 + value2.Row1, value1.Row2 + value2.Row2);
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are equal; False otherwise.</returns>
        public static unsafe bool operator ==(Matrix2X3<T> value1, Matrix2X3<T> value2)
        {
            return Scalar.Equal(value1.M11, value2.M11) && Scalar.Equal(value1.M22, value2.M22) &&
                   // Check diagonal elements first for early out.
                   Scalar.Equal(value1.M12, value2.M12) && Scalar.Equal(value1.M13, value2.M13) &&
                   Scalar.Equal(value1.M21, value2.M21) && Scalar.Equal(value1.M23, value2.M23);
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are not equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are not equal; False if they are equal.</returns>
        public static unsafe bool operator !=(Matrix2X3<T> value1, Matrix2X3<T> value2)
        {
            return Scalar.NotEqual(value1.M11, value2.M11) ||
                   Scalar.NotEqual(value1.M22, value2.M22) || // Check diagonal elements first for early out.
                   Scalar.NotEqual(value1.M12, value2.M12) || Scalar.NotEqual(value1.M13, value2.M13) ||
                   Scalar.NotEqual(value1.M21, value2.M21) || Scalar.NotEqual(value1.M23, value2.M23);
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix2X3<T> operator *(Matrix2X3<T> value1, Matrix3X3<T> value2)
        {
            return new(value1.M11 * value2.Row1 + value1.M12 * value2.Row2 + value1.M13 * value2.Row3, value1.M21 * value2.Row1 + value1.M22 * value2.Row2 + value1.M23 * value2.Row3);
        }

        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Vector3D<T> operator *(Vector2D<T> value1, Matrix2X3<T> value2)
        {
            return value1.X * value2.Row1 + value1.Y * value2.Row2;
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix2X3<T> operator *(Matrix2X2<T> value1, Matrix2X3<T> value2)
        {
            return new(value1.M11 * value2.Row1 + value1.M12 * value2.Row2, value1.M21 * value2.Row1 + value2.M22 * value2.Row2);
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix2X2<T> operator *(Matrix2X3<T> value1, Matrix3X2<T> value2)
        {
            return new(value1.M11 * value2.Row1 + value1.M12 * value2.Row2, value1.M21 * value2.Row1 + value1.M22 * value2.Row2);
        }

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        public static unsafe Matrix2X3<T> operator *(Matrix2X3<T> value1, T value2)
        {
            return new(value1.Row1 * value2, value1.Row2 * value2);
        }

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static unsafe Matrix2X3<T> operator -(Matrix2X3<T> value1, Matrix2X3<T> value2)
        {
            return new(value1.Row1 - value2.Row1, value1.Row2 - value2.Row2);
        }

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static unsafe Matrix2X3<T> operator -(Matrix2X3<T> value)
        {
            return new(-value.Row1, -value.Row2);
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this matrix instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this matrix; False otherwise.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public override readonly bool Equals(object? obj)
            => (obj is Matrix2X3<T> other) && Equals(other);

        /// <summary>Returns a boolean indicating whether this matrix instance is equal to the other given matrix.</summary>
        /// <param name="other">The matrix to compare this instance to.</param>
        /// <returns>True if the matrices are equal; False otherwise.</returns>
        public readonly bool Equals(Matrix2X3<T> other)
            => this == other;

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>   
        public override readonly int GetHashCode()
        {
            HashCode hash = default;

            hash.Add(M11);
            hash.Add(M12);
            hash.Add(M13);

            hash.Add(M21);
            hash.Add(M22);
            hash.Add(M23);

            return hash.ToHashCode();
        }

        /// <summary>Returns a String representing this matrix instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "{{ {{M11:{0} M12:{1} M13:{2} }} {{M21:{3} M22:{4} M23:{5} }} }}",
                                 M11, M12, M13,
                                 M21, M22, M23);
        }
        /// <summary>
        /// Converts a <see cref="Matrix2X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="Half"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="Half"/> matrix</returns>
        public static explicit operator Matrix2X3<Half>(Matrix2X3<T> from)
            => new(Scalar.As<T, Half>(from.M11), Scalar.As<T, Half>(from.M12), Scalar.As<T, Half>(from.M13),
                Scalar.As<T, Half>(from.M21), Scalar.As<T, Half>(from.M22), Scalar.As<T, Half>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Matrix2X3<float>(Matrix2X3<T> from)
            => new(Scalar.As<T, float>(from.M11), Scalar.As<T, float>(from.M12),
                Scalar.As<T, float>(from.M13), Scalar.As<T, float>(from.M21), Scalar.As<T, float>(from.M22),
                Scalar.As<T, float>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Matrix2X3<double>(Matrix2X3<T> from)
            => new(Scalar.As<T, double>(from.M11), Scalar.As<T, double>(from.M12),
                Scalar.As<T, double>(from.M13), Scalar.As<T, double>(from.M21),
                Scalar.As<T, double>(from.M22), Scalar.As<T, double>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="decimal"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="decimal"/> matrix</returns>
        public static explicit operator Matrix2X3<decimal>(Matrix2X3<T> from)
            => new(Scalar.As<T, decimal>(from.M11), Scalar.As<T, decimal>(from.M12),
                Scalar.As<T, decimal>(from.M13), Scalar.As<T, decimal>(from.M21),
                Scalar.As<T, decimal>(from.M22), Scalar.As<T, decimal>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="sbyte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="sbyte"/> matrix</returns>
        public static explicit operator Matrix2X3<sbyte>(Matrix2X3<T> from)
            => new(Scalar.As<T, sbyte>(from.M11), Scalar.As<T, sbyte>(from.M12),
                Scalar.As<T, sbyte>(from.M13), Scalar.As<T, sbyte>(from.M21), Scalar.As<T, sbyte>(from.M22),
                Scalar.As<T, sbyte>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="byte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="byte"/> matrix</returns>
        public static explicit operator Matrix2X3<byte>(Matrix2X3<T> from)
            => new(Scalar.As<T, byte>(from.M11), Scalar.As<T, byte>(from.M12), Scalar.As<T, byte>(from.M13),
                Scalar.As<T, byte>(from.M21), Scalar.As<T, byte>(from.M22), Scalar.As<T, byte>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="ushort"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ushort"/> matrix</returns>
        public static explicit operator Matrix2X3<ushort>(Matrix2X3<T> from)
            => new(Scalar.As<T, ushort>(from.M11), Scalar.As<T, ushort>(from.M12),
                Scalar.As<T, ushort>(from.M13), Scalar.As<T, ushort>(from.M21),
                Scalar.As<T, ushort>(from.M22), Scalar.As<T, ushort>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="short"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="short"/> matrix</returns>
        public static explicit operator Matrix2X3<short>(Matrix2X3<T> from)
            => new(Scalar.As<T, short>(from.M11), Scalar.As<T, short>(from.M12),
                Scalar.As<T, short>(from.M13), Scalar.As<T, short>(from.M21), Scalar.As<T, short>(from.M22),
                Scalar.As<T, short>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="uint"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="uint"/> matrix</returns>
        public static explicit operator Matrix2X3<uint>(Matrix2X3<T> from)
            => new(Scalar.As<T, uint>(from.M11), Scalar.As<T, uint>(from.M12), Scalar.As<T, uint>(from.M13),
                Scalar.As<T, uint>(from.M21), Scalar.As<T, uint>(from.M22), Scalar.As<T, uint>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="int"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="int"/> matrix</returns>
        public static explicit operator Matrix2X3<int>(Matrix2X3<T> from)
            => new(Scalar.As<T, int>(from.M11), Scalar.As<T, int>(from.M12), Scalar.As<T, int>(from.M13),
                Scalar.As<T, int>(from.M21), Scalar.As<T, int>(from.M22), Scalar.As<T, int>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="ulong"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ulong"/> matrix</returns>
        public static explicit operator Matrix2X3<ulong>(Matrix2X3<T> from)
            => new(Scalar.As<T, ulong>(from.M11), Scalar.As<T, ulong>(from.M12),
                Scalar.As<T, ulong>(from.M13), Scalar.As<T, ulong>(from.M21), Scalar.As<T, ulong>(from.M22),
                Scalar.As<T, ulong>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="long"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="long"/> matrix</returns>
        public static explicit operator Matrix2X3<long>(Matrix2X3<T> from)
            => new(Scalar.As<T, long>(from.M11), Scalar.As<T, long>(from.M12), Scalar.As<T, long>(from.M13),
                Scalar.As<T, long>(from.M21), Scalar.As<T, long>(from.M22), Scalar.As<T, long>(from.M23));
    }
}