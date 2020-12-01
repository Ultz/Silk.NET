﻿using System;

namespace Silk.NET.Maths
{
    /// <summary>
    /// A structure representing a Cube with an <see cref="Origin"/> and <see cref="Size"/>
    /// </summary>
    public struct Cube<T>
        : IEquatable<Cube<T>>
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        /// <summary>
        /// The origin.
        /// </summary>
        public Vector3<T> Origin;
        /// <summary>
        /// The size.
        /// </summary>
        public Vector3<T> Size;

        /// <summary>
        /// Constructs a Cube from an origin and it's size
        /// </summary>
        /// <param name="origin">The origin of the cube.</param>
        /// <param name="size">The size of the cube.</param>
        public Cube(Vector3<T> origin, Vector3<T> size)
        {
            Origin = origin;
            Size = size;
        }
        
        /// <summary>
        /// The center of this cube.
        /// </summary>
        public Vector3<T> Center
        {
            get => Origin + HalfSize;
        }

        /// <summary>
        /// The Maximum point of this cube.
        /// </summary>
        public Vector3<T> Max => Origin + Size;

        /// <summary>
        /// Half the size of this cube.
        /// </summary>
        public Vector3<T> HalfSize => Size / Scalar<T>.Two;

        /// <summary>
        /// Calculates whether this cube contains a point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>True if this cube contains the point; False otherwise.</returns>
        /// <remarks>This does consider a point on the edge contained.</remarks>
        public bool Contains(Vector3<T> point)
        {
            var max = Max;
            return Scalar.GreaterThanOrEqual(point.X, Origin.X) && Scalar.GreaterThanOrEqual
                (point.Y, Origin.Y) && Scalar.GreaterThanOrEqual(point.Z, Origin.Z) && Scalar.LessThanOrEqual
                (point.X, max.X) && Scalar.LessThanOrEqual(point.Y, max.Y) && Scalar.LessThanOrEqual(point.Z, max.Z);
        }

        /// <summary>
        /// Calculates whether this cube contains another rectangle
        /// </summary>
        /// <param name="other">The rectangle.</param>
        /// <returns>True if this cube contains the given cube; False otherwise.</returns>
        /// <remarks>This does consider a cube that touches the edge contained.</remarks>
        public bool Contains(Cube<T> other)
        {
            var tMax = this.Max;
            var oMax = other.Max;
            return Scalar.GreaterThanOrEqual(other.Origin.X, this.Origin.X) && Scalar.GreaterThanOrEqual
                (other.Origin.Y, this.Origin.Y) && Scalar.GreaterThanOrEqual
                (other.Origin.Z, this.Origin.Z) && Scalar.LessThanOrEqual(oMax.X, tMax.X) && Scalar.LessThanOrEqual
                (oMax.Y, tMax.Y) && Scalar.GreaterThanOrEqual(oMax.Y, tMax.Y);
        }

        /// <summary>
        /// Calculates the distance to the nearest edge from the point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        public T GetDistanceToNearestEdge(Vector3<T> point)
        {
            var max = Max;
            var dx = Scalar.Max(Scalar.Max(Scalar.Subtract(Origin.X, point.X), Scalar<T>.Zero), Scalar.Subtract(point.X, max.X));
            var dy = Scalar.Max(Scalar.Max(Scalar.Subtract(Origin.Y, point.Y), Scalar<T>.Zero), Scalar.Subtract(point.Y, max.Y));
            var dz = Scalar.Max(Scalar.Max(Scalar.Subtract(Origin.Z, point.Z), Scalar<T>.Zero), Scalar.Subtract(point.Z, max.Z));
            return Scalar.Sqrt(Scalar.Add(Scalar.Add(Scalar.Multiply(dx, dx), Scalar.Multiply(dy, dy)), Scalar.Multiply(dz, dz)));
        }

        /// <summary>
        /// Calculates a new cube translated by a given distance.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <returns>The calculated cube.</returns>
        public Cube<T> GetTranslated(Vector3<T> distance)
        {
            return new(Origin + distance, Size);
        }

        /// <summary>
        /// Calculates a new cube scaled by the given scale around the given anchor.
        /// </summary>
        /// <param name="scale">The scale.</param>
        /// <param name="anchor">The anchor.</param>
        /// <returns>The calculated cube.</returns>
        public Cube<T> GetScaled(Vector3<T> scale, Vector3<T> anchor)
        {
            var origMax = Max;
            var min = (scale * (Origin - anchor)) + Origin;
            var max = (scale * (origMax - anchor)) + origMax;
            return new(min, max - min);
        }

        /// <summary>
        /// Calculates a cube inflated to contain the given point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The cube rectangle.</returns>
        public Cube<T> GetInflated(Vector3<T> point)
        {
            var min = Vector3<T>.Min(Origin, point);
            var max = Vector3<T>.Max(Max, point);
            return new(min, max - min);
        }

        /// <summary>Returns a boolean indicating whether the given Cube is equal to this Cube instance.</summary>
        /// <param name="other">The Cube to compare this instance to.</param>
        /// <returns>True if the other Cube is equal to this instance; False otherwise.</returns>
        public bool Equals(Cube<T> other)
        {
            return Origin.Equals(other.Origin) && Size.Equals(other.Size);
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Cube instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Cube; False otherwise.</returns>
        public override bool Equals(object? obj)
        {
            return obj is Cube<T> other && Equals(other);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Origin, Size);
        }

        /// <summary>Returns a boolean indicating whether the two given Cubes are equal.</summary>
        /// <param name="value1">The first Cube to compare.</param>
        /// <param name="value2">The second Cube to compare.</param>
        /// <returns>True if the Cubes are equal; False otherwise.</returns>
        public static bool operator ==(Cube<T> value1, Cube<T> value2)
        {
            return value1.Equals(value2);
        }

        /// <summary>Returns a boolean indicating whether the two given Cubes are not equal.</summary>
        /// <param name="value1">The first Cube to compare.</param>
        /// <param name="value2">The second Cube to compare.</param>
        /// <returns>True if the Cubes are not equal; False if they are equal.</returns>
        public static bool operator !=(Cube<T> value1, Cube<T> value2)
        {
            return !value1.Equals(value2);
        }
    }
}