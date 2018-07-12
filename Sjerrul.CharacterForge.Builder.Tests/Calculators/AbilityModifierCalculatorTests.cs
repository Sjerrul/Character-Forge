using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sjerrul.CharacterForge.Builder.Calculators;

namespace Sjerrul.CharacterForge.Builder.Tests
{
    [TestClass]
    public class AbilityModifierCalculatorTests
    {
        [TestMethod]
        [DataRow(10, +0)]
        public void CalculateProficiency_valid_ReturnsCorectProficiency(int abilityScore, int expectedModifier)
        {
            // Act
            int result = AbilityModifierCalculator.CalculateAbilityModifier(abilityScore);

            // Assert
            Assert.AreEqual(expectedModifier, result);
        }
    }
}
