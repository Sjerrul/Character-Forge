using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sjerrul.CharacterForge.Builder.Calculators;

namespace Sjerrul.CharacterForge.Builder.Tests
{
    [TestClass]
    public class ProficiencyCalculatorTests
    {
        [TestMethod]
        [DataRow(1, +2)]
        public void CalculateProficiency_valid_ReturnsCorectProficiency(int level, int expectedProficiency)
        {
            // Act
            int result = ProficiencyCalculator.CalculateProficiency(level);

            // Assert
            Assert.AreEqual(expectedProficiency, result);
        }
    }
}
