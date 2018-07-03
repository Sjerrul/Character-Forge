using System;
using System.Collections.Generic;
using System.Text;

namespace Sjerrul.CharacterForge.Utilities.Assertion
{
    /// <summary>
    /// Helper to assert parameters and throw exceptions when they do not comply
    /// </summary>
    public static class AssertionHelper
    {
        /// <summary>
        /// Asserts the argument not null.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="message">The message.</param>
        public static void AssertArgumentNotNull(object parameter, string parameterName, string message = null)
        {
            message = message ?? $"'{parameterName}' cannot be null";
            AssertCondition<ArgumentNullException>(parameter != null, message);
        }

        /// <summary>
        /// Asserts the string not null or whitespace.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="message">The message.</param>
        public static void AssertStringNotNullOrWhitespace(string parameter, string parameterName, string message = null)
        {
            message = message ?? $"'{parameterName}' cannot be null or empty";
            AssertCondition<ArgumentException>(!string.IsNullOrWhiteSpace(parameter), message);
        }

        /// <summary>
        /// Asserts the unique identifier not empty.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="message">The message.</param>
        public static void AssertGuidNotEmpty(Guid guid, string parameterName, string message = null)
        {
            message = message ?? $"'{parameterName}' cannot be an empty guid";
            AssertCondition<ArgumentException>(guid != Guid.Empty, message);
        }

        /// <summary>
        /// Asserts the condition, throws if condition is not true
        /// </summary>
        /// <typeparam name="TException">The type of the exception.</typeparam>
        /// <param name="condition">if set to <c>true</c> [condition].</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="message">The message.</param>
        public static void AssertCondition<TException>(bool condition, string parameterName, string message)
            where TException : Exception, new()
        {
            AssertCondition<TException>(condition, message);
        }

        private static void AssertCondition<TException>(bool condition, string message) where TException : Exception, new()
        {
            if (condition)
            {
                return;
            }

            if (Activator.CreateInstance(typeof(TException), message) is TException exception)
            {
                throw exception;
            }
        }
    }
}
