using System;
using System.Collections.Generic;
using System.Text;

namespace Sjerrul.CharacterForge.Utilities.Assertion
{
    /// <summary>
    /// Against guards against conditions that are NOT to be true 
    /// </summary>
    public class Against : IAgainst
    {
        /// <summary>
        /// Guards against argument not null, throws 
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="message">The message.</param>
        public void ArgumentNull(object parameter, string parameterName, string message = null)
        {
            message = message ?? $"'{parameterName}' cannot be null";
            Guard.That(parameter == null).WhenTrue.Throws<ArgumentNullException>(message);
        }

        /// <summary>
        /// Asserts the string not null or whitespace.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="message">The message.</param>
        public void StringNullOrWhitespace(string parameter, string parameterName, string message = null)
        {
            message = message ?? $"'{parameterName}' cannot be null or whitespace";
            Guard.That(string.IsNullOrWhiteSpace(parameter)).WhenTrue.Throws<ArgumentException>(message);
        }
    }
}
