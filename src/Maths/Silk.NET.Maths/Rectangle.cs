﻿using System;

namespace Silk.NET.Maths
{
    /// <summary>
    /// A structure representing a Rectangle with an <see cref="Origin"/> and <see cref="Size"/>
    /// </summary>
    public struct Rectangle<T>
        : IEquatable<Rectangle<T>>
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        /// <summary>
        /// The origin.
        /// </summary>
        public Vector2<T> Origin;
        /// <summary>
        /// The size.
        /// </summary>
        public Vector2<T> Size;
        
        /// <summary>
        /// Constructs a Rectangle from an origin and an size
        /// </summary>
        /// <param name="origin">The origin of the rect.</param>
        /// <param name="size">The size of the rect.</param>
        public Rectangle(Vector2<T> origin, Vector2<T> size)
        {
            Origin = origin;
            Size = size;
        }
        
        /// <summary>
        /// The center of this rectangle.
        /// </summary>
        public Vector2<T> Center
        {
            get => Origin + HalfSize;
        }

        /// <summary>
        /// The Maximum point of this Rectangle.
        /// </summary>
        public Vector2<T> Max => Origin + Size;

        /// <summary>
        /// Half the size of this rectangle.
        /// </summary>
        public Vector2<T> HalfSize => Size / Scalar<T>.Two;

        /// <summary>
        /// Calculates whether this rectangle contains a point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>True if this rectangle contains the point; False otherwise.</returns>
        /// <remarks>This does consider a point on the edge contained.</remarks>
        public bool Contains(Vector2<T> point)
        {
            var max = Max;
            return Scalar.GreaterThanOrEqual(point.X, Origin.X) && Scalar.GreaterThanOrEqual
                (point.Y, Origin.Y) && Scalar.LessThanOrEqual(point.X, max.X) && Scalar.LessThanOrEqual(point.Y, max.Y);
        }

        /// <summary>
        /// Calculates whether this rectangle contains another rectangle
        /// </summary>
        /// <param name="other">The rectangle.</param>
        /// <returns>True if this rectangle contains the given rectangle; False otherwise.</returns>
        /// <remarks>This does consider a rectangle that touches the edge contained.</remarks>
        public bool Contains(Rectangle<T> other)
        {
            var tMax = this.Max;
            var oMax = other.Max;
            return Scalar.GreaterThanOrEqual(other.Origin.X, this.Origin.X) && Scalar.GreaterThanOrEqual
                (other.Origin.Y, this.Origin.Y) && Scalar.LessThanOrEqual(oMax.X, tMax.X) && Scalar.LessThanOrEqual
                (oMax.Y, tMax.Y);
        }

        /// <summary>
        /// Calculates the distance to the nearest edge from the point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        public T GetDistanceToNearestEdge(Vector2<T> point)
        {
            var max = Max;
            var dx = Scalar.Max(Scalar.Max(Scalar.Subtract(Origin.X, point.X), Scalar<T>.Zero), Scalar.Subtract(point.X, max.X));
            var dy = Scalar.Max(Scalar.Max(Scalar.Subtract(Origin.Y, point.Y), Scalar<T>.Zero), Scalar.Subtract(point.Y, max.Y));
            return Scalar.Sqrt(Scalar.Add(Scalar.Multiply(dx, dx), Scalar.Multiply(dy, dy)));
        }

        /// <summary>
        /// Calculates a new rectangle translated by a given distance.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <returns>The calculated rectangle.</returns>
        public Rectangle<T> GetTranslated(Vector2<T> distance)
        {
            return new(Origin + distance, Size);
        }

        /// <summary>
        /// Calculates a new rectangle scaled by the given scale around the given anchor.
        /// </summary>
        /// <param name="scale">The scale.</param>
        /// <param name="anchor">The anchor.</param>
        /// <returns>The calculated rectangle.</returns>
        public Rectangle<T> GetScaled(Vector2<T> scale, Vector2<T> anchor)
        {
            var origMax = Max;
            var min = (scale * (Origin - anchor)) + Origin;
            var max = (scale * (origMax - anchor)) + origMax;
            return new(min, max - min);
        }

        /// <summary>
        /// Calculates a rectangle inflated to contain the given point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The calculated rectangle.</returns>
        public Rectangle<T> GetInflated(Vector2<T> point)
        {
            var min = Vector2<T>.Min(Origin, point);
            var max = Vector2<T>.Max(Max, point);
            return new(min, max - min);
        }

        /// <summary>Returns a boolean indicating whether the given Rectangle is equal to this Rectangle instance.</summary>
        /// <param name="other">The Rectangle to compare this instance to.</param>
        /// <returns>True if the other Rectangle is equal to this instance; False otherwise.</returns>
        public bool Equals(Rectangle<T> other)
        {
            return Origin.Equals(other.Origin) && Size.Equals(other.Size);
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Rectangle instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Rectangle; False otherwise.</returns>
        public override bool Equals(object? obj)
        {
            return obj is Rectangle<T> other && Equals(other);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Origin, Size);
        }

        /// <summary>Returns a boolean indicating whether the two given Rectangles are equal.</summary>
        /// <param name="value1">The first Rectangle to compare.</param>
        /// <param name="value2">The second Rectangle to compare.</param>
        /// <returns>True if the Rectangles are equal; False otherwise.</returns>
        public static bool operator ==(Rectangle<T> value1, Rectangle<T> value2)
        {
            return value1.Equals(value2);
        }

        /// <summary>Returns a boolean indicating whether the two given Rectangles are not equal.</summary>
        /// <param name="value1">The first Rectangle to compare.</param>
        /// <param name="value2">The second Rectangle to compare.</param>
        /// <returns>True if the Rectangles are not equal; False if they are equal.</returns>
        public static bool operator !=(Rectangle<T> value1, Rectangle<T> value2)
        {
            return !value1.Equals(value2);
        }
    }
}