using System;
using System.Collections.Generic;
using System.Text;

namespace Sjerrul.CharacterForge.Utilities.Assertion
{
    /// <summary>
    /// Helper to assert parameters and throw exceptions when they do not comply
    /// </summary>
    public static class Guard
    {
        /// <summary>
        /// The against interface.
        /// </summary>
        public static IAgainst Against => new Against();

        /// <summary>
        /// Guars against a specific condition
        /// </summary>
        /// <param name="condition">The condition to verify.</param>
        /// <returns></returns>
        public static IThat That(bool condition)
        {
            return new That(condition);
        }
    }
}
