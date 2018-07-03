using System;
using System.Collections.Generic;
using System.Text;

namespace Sjerrul.CharacterForge.Utilities.Assertion
{
    // The condition that is checked against
    public class Condition : ICondition
    {
        /// <summary>
        /// The result that is deemed to be correct
        /// </summary>
        private bool correctResult;

        /// <summary>
        /// The actual result of the condition
        /// </summary>
        private bool actualResult;

        /// <summary>
        /// Initializes a new instance of the <see cref="Condition"/> class.
        /// </summary>
        /// <param name="correctResult">if set to <c>true</c> [correct result].</param>
        /// <param name="actual">if set to <c>true</c> [actual].</param>
        public Condition(bool correctResult, bool actual)
        {
            this.correctResult = correctResult;
            this.actualResult = actual;
        }

        /// <summary>
        /// Throws the specified exception when result that is set as correct is not equal to the actual result.
        /// </summary>
        /// <typeparam name="TException">The type of the exception.</typeparam>
        /// <param name="message">The message.</param>
        /// <exception cref="System.InvalidOperationException">TException</exception>
        public void Throws<TException>(string message) where TException : Exception
        {
            if (this.correctResult != this.actualResult)
            {
                if (Activator.CreateInstance(typeof(TException), message) is TException exception)
                {
                    throw exception;
                }

                throw new InvalidOperationException($"Couldn't create exception {nameof(TException)} with message: {message}");
            }
        }
    }
}
