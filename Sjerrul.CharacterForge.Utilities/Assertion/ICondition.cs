using System;
using System.Collections.Generic;
using System.Text;

namespace Sjerrul.CharacterForge.Utilities.Assertion
{
    /// <summary>
    /// Interface for a condition
    /// </summary>
    public interface ICondition
    {
        /// <summary>
        /// Entrypoint for final testing of the actual and expected condition and handle (throw) when needed
        /// </summary>
        /// <typeparam name="TException">The type of the exception.</typeparam>
        /// <param name="message">The message.</param>
        void Throws<TException>(string message) where TException : Exception;
    }
}
