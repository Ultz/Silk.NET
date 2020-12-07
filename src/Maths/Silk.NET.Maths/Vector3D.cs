using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace Silk.NET.Maths
{
    /// <summary>A structure encapsulating three values and provides hardware accelerated methods.</summary>
    [Serializable]
    [DataContract]
    public struct Vector3D<T>
        : IEquatable<Vector3D<T>>, IFormattable
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        /// <summary>The X component of the vector.</summary>
        [DataMember]
        public T X;

        /// <summary>The Y component of the vector.</summary>
        [DataMember]
        public T Y;

        /// <summary>The Z component of the vector.</summary>
        [DataMember]
        public T Z;

        /// <summary>Constructs a vector whose elements are all the single specified value.</summary>
        /// <param name="value">The element to fill the vector with.</param>
        public Vector3D(T value) => (X, Y, Z) = (value, value, value);

        /// <summary>Constructs a Vector3D from the given Vector2D and a third value.</summary>
        /// <param name="value">The Vector to extract X and Y components from.</param>
        /// <param name="z">The Z component.</param>
        public Vector3D(Vector2D<T> value, T z) => (X, Y, Z) = (value.X, value.Y, z);

        /// <summary>Constructs a vector with the given individual elements.</summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        /// <param name="z">The Z component.</param>
        public Vector3D(T x, T y, T z) => (X, Y, Z) = (x, y, z);

        /// <summary>Returns the vector (0,0,0).</summary>
        public static Vector3D<T> Zero => default;

        /// <summary>Returns the vector (1,1,1).</summary>
        public static Vector3D<T> One => new(Scalar<T>.One);

        /// <summary>Returns the vector (1,0,0).</summary>
        public static Vector3D<T> UnitX => new(Scalar<T>.One, Scalar<T>.Zero, Scalar<T>.Zero);

        /// <summary>Returns the vector (0,1,0).</summary>
        public static Vector3D<T> UnitY => new(Scalar<T>.Zero, Scalar<T>.One, Scalar<T>.Zero);

        /// <summary>Returns the vector (0,0,1).</summary>
        public static Vector3D<T> UnitZ => new(Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.One);

        /// <summary>
        /// Indexer for the components of this vector.
        /// </summary>
        /// <param name="i">The component to select. Zero based.</param>
        public T this[int i]
        {
            get
            {
                static void VerifyBounds(int i)
                {
                    static void ThrowHelper() => throw new IndexOutOfRangeException();

                    if (i > 2 || i < 0)
                        ThrowHelper();
                }

                VerifyBounds(i);
                return Unsafe.Add(ref X, i);
            }
        }

        /// <summary>Adds two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The summed vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> operator +(Vector3D<T> left, Vector3D<T> right)
            => new(Scalar.Add(left.X, right.X), Scalar.Add(left.Y, right.Y), Scalar.Add(left.Z, right.Z));

        /// <summary>Divides the first vector by the second.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The vector resulting from the division.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> operator /(Vector3D<T> left, Vector3D<T> right)
            => new(Scalar.Divide(left.X, right.X), Scalar.Divide(left.Y, right.Y),
                Scalar.Divide(left.Z, right.Z));

        /// <summary>Divides the vector by the given scalar.</summary>
        /// <param name="value1">The source vector.</param>
        /// <param name="value2">The scalar value.</param>
        /// <returns>The result of the division.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> operator /(Vector3D<T> value1, T value2)
            => new(Scalar.Divide(value1.X, value2), Scalar.Divide(value1.Y, value2),
                Scalar.Divide(value1.Z, value2));

        /// <summary>Returns a boolean indicating whether the two given vectors are equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns>True if the vectors are equal; False otherwise.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static bool operator ==(Vector3D<T> left, Vector3D<T> right)
            => Scalar.Equal(left.X, right.X)
            && Scalar.Equal(left.Y, right.Y)
            && Scalar.Equal(left.Z, right.Z);

        /// <summary>Returns a boolean indicating whether the two given vectors are not equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns>True if the vectors are not equal; False if they are equal.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static bool operator !=(Vector3D<T> left, Vector3D<T> right) => !(left == right);

        /// <summary>Multiplies two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The product vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> operator *(Vector3D<T> left, Vector3D<T> right)
            => new(Scalar.Multiply(left.X, right.X), Scalar.Multiply(left.Y, right.Y),
                Scalar.Multiply(left.Z, right.Z));

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The source vector.</param>
        /// <param name="right">The scalar value.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> operator *(Vector3D<T> left, T right)
            => new(Scalar.Multiply(left.X, right), Scalar.Multiply(left.Y, right),
                Scalar.Multiply(left.Z, right));

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The scalar value.</param>
        /// <param name="right">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> operator *(T left, Vector3D<T> right)
            => right * left;

        /// <summary>Subtracts the second vector from the first.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The difference vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> operator -(Vector3D<T> left, Vector3D<T> right)
            => new(Scalar.Subtract(left.X, right.X), Scalar.Subtract(left.Y, right.Y),
                Scalar.Subtract(left.Z, right.Z));

        /// <summary>Negates a given vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The negated vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> operator -(Vector3D<T> value)
            => Zero - value;

        /// <summary>Copies the contents of the vector into the given array.</summary>
        [MethodImpl((MethodImplOptions) 768)]
        public readonly void CopyTo(T[]? array)
            => CopyTo(array, 0);

        /// <summary>Copies the contents of the vector into the given array, starting from index.</summary>
        /// <exception cref="ArgumentNullException">If array is null.</exception>
        /// <exception cref="RankException">If array is multidimensional.</exception>
        /// <exception cref="ArgumentOutOfRangeException">If index is greater than end of the array or index is less than zero.</exception>
        /// <exception cref="ArgumentException">If number of elements in source vector is greater than those available in destination array.</exception>
        [MethodImpl((MethodImplOptions) 768)]
        public readonly void CopyTo(T[]? array, int index)
        {
            if (array is null)
            {
                throw new NullReferenceException("Object reference not set to an instance of an object.");
            }

            if ((index < 0) || (index >= array.Length))
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Specified argument was out of the range of valid values.");
            }

            if ((array.Length - index) < 3)
            {
                throw new ArgumentException("Value does not fall within the expected range.");
            }

            array[index] = X;
            array[index + 1] = Y;
            array[index + 2] = Z;
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Vector3D instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Vector3D; False otherwise.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public override readonly bool Equals(object? obj)
        {
            return (obj is Vector3D<T> other) && Equals(other);
        }

        /// <summary>Returns a boolean indicating whether the given Vector3D is equal to this Vector3D instance.</summary>
        /// <param name="other">The Vector3D to compare this instance to.</param>
        /// <returns>True if the other Vector3D is equal to this instance; False otherwise.</returns>
        public readonly bool Equals(Vector3D<T> other)
        {
            return this == other;
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override readonly int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }

        /// <summary>Returns the length of the vector.</summary>
        /// <value>The vector's length.</value>
        public T Length
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => Scalar.Sqrt(LengthSquared);
        }

        /// <summary>Returns the length of the vector squared. This operation is cheaper than Length().</summary>
        /// <value>The vector's length squared.</value>
        public T LengthSquared
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => Vector3D.Dot(this, this);
        }

        /// <summary>Returns a String representing this Vector3D instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString() => ToString("G", CultureInfo.CurrentCulture);

        /// <summary>Returns a String representing this Vector3D instance, using the specified format to format individual elements.</summary>
        /// <param name="format">The format of individual elements.</param>
        /// <returns>The string representation.</returns>
        public readonly string ToString(string? format) => ToString(format, CultureInfo.CurrentCulture);

        /// <summary>Returns a String representing this Vector3D instance, using the specified format to format individual elements and the given IFormatProvider.</summary>
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
            sb.Append('>');
            return sb.ToString();
        }

        /// <summary>
        /// Converts a <see cref="Vector3D{T}"/> into one with a <typeparamref name="T"/> of <see cref="Half"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="Half"/> matrix</returns>
        public static explicit operator Vector3D<Half>(Vector3D<T> from)
            => new(Scalar.As<T, Half>(from.X), Scalar.As<T, Half>(from.Y), Scalar.As<T, Half>(from.Z));

        /// <summary>
        /// Converts a <see cref="Vector3D{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Vector3D<float>(Vector3D<T> from)
            => new(Scalar.As<T, float>(from.X), Scalar.As<T, float>(from.Y), Scalar.As<T, float>(from.Z));

        /// <summary>
        /// Converts a <see cref="Vector3{T}"/> into <see cref="System.Numerics.Vector3"/>
        /// </summary>
        /// <param name="from">The source vector</param>
        /// <returns>The <see cref="System.Numerics"/> vector</returns>
        public static explicit operator System.Numerics.Vector3(Vector3<T> from)
            => new(Scalar.As<T, float>(from.X), Scalar.As<T, float>(from.Y), Scalar.As<T, float>(from.Z));
        
        /// <summary>
        /// Converts a <see cref="Vector3{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Vector3D<double>(Vector3D<T> from)
            => new(Scalar.As<T, double>(from.X), Scalar.As<T, double>(from.Y), Scalar.As<T, double>(from.Z));

        /// <summary>
        /// Converts a <see cref="Vector3D{T}"/> into one with a <typeparamref name="T"/> of <see cref="decimal"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="decimal"/> matrix</returns>
        public static explicit operator Vector3D<decimal>(Vector3D<T> from)
            => new(Scalar.As<T, decimal>(from.X), Scalar.As<T, decimal>(from.Y), Scalar.As<T, decimal>(from.Z));

        /// <summary>
        /// Converts a <see cref="Vector3D{T}"/> into one with a <typeparamref name="T"/> of <see cref="sbyte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="sbyte"/> matrix</returns>
        public static explicit operator Vector3D<sbyte>(Vector3D<T> from)
            => new(Scalar.As<T, sbyte>(from.X), Scalar.As<T, sbyte>(from.Y), Scalar.As<T, sbyte>(from.Z));

        /// <summary>
        /// Converts a <see cref="Vector3D{T}"/> into one with a <typeparamref name="T"/> of <see cref="byte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="byte"/> matrix</returns>
        public static explicit operator Vector3D<byte>(Vector3D<T> from)
            => new(Scalar.As<T, byte>(from.X), Scalar.As<T, byte>(from.Y), Scalar.As<T, byte>(from.Z));

        /// <summary>
        /// Converts a <see cref="Vector3D{T}"/> into one with a <typeparamref name="T"/> of <see cref="ushort"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ushort"/> matrix</returns>
        public static explicit operator Vector3D<ushort>(Vector3D<T> from)
            => new(Scalar.As<T, ushort>(from.X), Scalar.As<T, ushort>(from.Y), Scalar.As<T, ushort>(from.Z));

        /// <summary>
        /// Converts a <see cref="Vector3D{T}"/> into one with a <typeparamref name="T"/> of <see cref="short"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="short"/> matrix</returns>
        public static explicit operator Vector3D<short>(Vector3D<T> from)
            => new(Scalar.As<T, short>(from.X), Scalar.As<T, short>(from.Y), Scalar.As<T, short>(from.Z));

        /// <summary>
        /// Converts a <see cref="Vector3D{T}"/> into one with a <typeparamref name="T"/> of <see cref="uint"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="uint"/> matrix</returns>
        public static explicit operator Vector3D<uint>(Vector3D<T> from)
            => new(Scalar.As<T, uint>(from.X), Scalar.As<T, uint>(from.Y), Scalar.As<T, uint>(from.Z));

        /// <summary>
        /// Converts a <see cref="Vector3D{T}"/> into one with a <typeparamref name="T"/> of <see cref="int"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="int"/> matrix</returns>
        public static explicit operator Vector3D<int>(Vector3D<T> from)
            => new(Scalar.As<T, int>(from.X), Scalar.As<T, int>(from.Y), Scalar.As<T, int>(from.Z));

        /// <summary>
        /// Converts a <see cref="Vector3D{T}"/> into one with a <typeparamref name="T"/> of <see cref="ulong"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ulong"/> matrix</returns>
        public static explicit operator Vector3D<ulong>(Vector3D<T> from)
            => new(Scalar.As<T, ulong>(from.X), Scalar.As<T, ulong>(from.Y), Scalar.As<T, ulong>(from.Z));

        /// <summary>
        /// Converts a <see cref="Vector3D{T}"/> into one with a <typeparamref name="T"/> of <see cref="long"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="long"/> matrix</returns>
        public static explicit operator Vector3D<long>(Vector3D<T> from)
            => new(Scalar.As<T, long>(from.X), Scalar.As<T, long>(from.Y), Scalar.As<T, long>(from.Z));
    }
}