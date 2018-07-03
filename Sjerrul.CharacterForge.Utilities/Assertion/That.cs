using System;
using System.Collections.Generic;
using System.Text;

namespace Sjerrul.CharacterForge.Utilities.Assertion
{
    /// <summary>
    /// Helper to assert parameters and throw exceptions when they do not comply
    /// </summary>
    public class That : IThat
    {
        /// <summary>
        /// The condition
        /// </summary>
        private bool condition;

        /// <summary>
        /// Gets the condition that is correct when false.
        /// </summary>
        public ICondition WhenFalse => new Condition(correctResult: true, actual: this.condition);

        /// <summary>
        /// Gets the condition that is correct when true.
        /// </summary>
        public ICondition WhenTrue => new Condition(correctResult: false, actual: this.condition);

        /// <summary>
        /// Initializes a new instance of the <see cref="That"/> class.
        /// </summary>
        /// <param name="condition">if set to <c>true</c> [condition].</param>
        public That(bool condition)
        {
            this.condition = condition;
        }
    }
}
