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
        [DataRow(2, +2)]
        [DataRow(3, +2)]
        [DataRow(4, +2)]
        [DataRow(5, +3)]
        [DataRow(6, +3)]
        [DataRow(7, +3)]
        [DataRow(8, +3)]
        [DataRow(9, +4)]
        [DataRow(10, +4)]
        [DataRow(11, +4)]
        [DataRow(12, +4)]
        [DataRow(13, +5)]
        [DataRow(14, +5)]
        [DataRow(15, +5)]
        [DataRow(16, +5)]
        [DataRow(17, +6)]
        [DataRow(18, +6)]
        [DataRow(19, +6)]
        [DataRow(20, +6)]
        public void CalculateProficiency_NormalLevelProgression_ReturnsCorrectProficiency(int level, int expectedProficiency)
        {
            // Act
            int result = ProficiencyCalculator.CalculateProficiency(level);

            // Assert
            Assert.AreEqual(expectedProficiency, result, $"Proficiency for level {level} is expected to be {expectedProficiency}, but is {result}");
        }
    }
}
