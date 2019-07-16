// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Generator.Common.Functions;
using JetBrains.Annotations;

namespace Generator.Bind.Overloading
{
    /// <summary>
    /// Represents a class that can create a set of overloads from a given base signature.
    /// </summary>
    public interface IFunctionOverloader
    {
        /// <summary>
        /// Creates a set of overload signatures from the given function.
        /// </summary>
        /// <param name="function">The base function.</param>
        /// <returns>A set of code blocks.</returns>
        [NotNull]
        IEnumerable<Overload> CreateOverloads([NotNull] Function function);
    }
}