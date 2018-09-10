using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sjerrul.CharacterForge.Builder.Rules;
using Sjerrul.CharacterForge.Builder.Rules.Race;
using Sjerrul.CharacterForge.Builder.Violations;
using Sjerrul.CharacterForge.Core;
using Sjerrul.CharacterForge.Core.Races;
using Sjerrul.CharacterForge.Core.Races.Dwarf;

namespace Sjerrul.CharacterForge.Builder.Tests
{
    [TestClass]
    public class CharacterMustHaveRaceRuleTests
    {
        [TestMethod]
        public void Check_HasUndefinedRace_ReturnsCorrectViolation()
        {
            // Arrange
            Character character = new Character();

            // Act
            IRule rule = new CharacterMustHaveRaceRule();
            IEnumerable<IViolation> result = rule.Check(character);

            // Assert
            Assert.AreEqual(1, result.Count());
            Assert.IsInstanceOfType(result.Single(), typeof(RaceNotSetViolation));
        }

        [TestMethod]
        public void Check_HasRace_ReturnsNoViolation()
        {
            // Arrange
            Character character = new Character();
            character.SetRace(new CommonDwarf());

            // Act
            IRule rule = new CharacterMustHaveRaceRule();
            IEnumerable<IViolation> result = rule.Check(character);

            // Assert
            Assert.IsFalse(result.Any());
        }
    }
}
