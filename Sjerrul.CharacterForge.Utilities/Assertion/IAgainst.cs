using System;
using System.Collections.Generic;
using System.Text;

namespace Sjerrul.CharacterForge.Utilities.Assertion
{
    /// <summary>
    /// INteface for testing negative conditions 
    /// </summary>
    public interface IAgainst
    {
        /// <summary>
        /// Test against argumetn null
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="message">The message.</param>
        void ArgumentNull(object parameter, string parameterName, string message = null);

        /// <summary>
        /// Test agianst string null or whitespace
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="message">The message.</param>
        void StringNullOrWhitespace(string parameter, string parameterName, string message = null);
    }
}
