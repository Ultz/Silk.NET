// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input.Common
{
    /// <summary>
    /// Available methods to control the deadzone of a control stick.
    /// </summary>
    public enum DeadzoneMethod
    {
        /// <summary>
        /// The traditional deadzone method.
        /// </summary>
        /// <remarks>
        /// <para>
        /// y = x except where |x| is between 0 and d
        /// </para>
        /// <para>
        /// y is the output, x is the raw value, and d is the deadzone value.
        /// </para>
        /// </remarks>
        Traditional,
        
        /// <summary>
        /// A more adaptive deadzone method; if the value is within the deadzone, equal to 0. After exiting the
        /// deadzone, the output increases linearly.
        /// </summary>
        /// <remarks>
        /// <para>
        /// y = (1 - d)x + (d * sgn(x))
        /// </para>
        /// <para>
        /// y is the output, x is the raw value, and d is the deadzone value.
        /// </para>
        /// </remarks>
        AdaptiveGradient
    }
}