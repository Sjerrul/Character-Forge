using System;
using System.Collections.Generic;
using System.Text;

namespace Sjerrul.CharacterForge.Utilities.Assertion
{
    /// <summary>
    /// Interface for fluent That classes
    /// </summary>
    public interface IThat
    {
        /// <summary>
        /// Gets the condition that is correct when false.
        /// </summary>
        ICondition WhenFalse { get; }

        /// <summary>
        /// Gets the condition that is correct when true.
        /// </summary>
        ICondition WhenTrue { get; }
    }
}
