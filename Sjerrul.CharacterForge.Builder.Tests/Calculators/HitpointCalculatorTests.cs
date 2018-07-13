using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sjerrul.CharacterForge.Builder.Calculators;
using Sjerrul.CharacterForge.Core.Classes;

namespace Sjerrul.CharacterForge.Builder.Tests
{
    [TestClass]
    public class HitpointCalculatorTests
    {
        [TestMethod]
        public void CalculateHitpoints_SingleClass_CalculatesCorrectly()
        {
            // Arrange
            IList<IClass> classes = new List<IClass>
            {
                new Wizard()
            };

            // Act
            int result = HitpointCalculator.CalculateHitpoints(classes);

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void CalculateHitpoints_MultipleSameClass_CalculatesCorrectly()
        {
            // Arrange
            IList<IClass> classes = new List<IClass>
            {
                new Wizard(),
                new Wizard(),
                new Wizard(),
                new Wizard(),
            };

            // Act
            int result = HitpointCalculator.CalculateHitpoints(classes);

            // Assert
            Assert.AreEqual(6 * 4, result);
        }

        [TestMethod]
        public void CalculateHitpoints_MultipleDifferentClass_CalculatesCorrectly()
        {
            // Arrange
            IList<IClass> classes = new List<IClass>
            {
                new Wizard(),
                new Fighter()
            };

            // Act
            int result = HitpointCalculator.CalculateHitpoints(classes);

            // Assert
            Assert.AreEqual(6 + 10, result);
        }
    }
}
