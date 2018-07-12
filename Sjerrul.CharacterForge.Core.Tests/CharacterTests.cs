using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sjerrul.CharacterForge.Core.Abilities;
using Sjerrul.CharacterForge.Core.Races;

namespace Sjerrul.CharacterForge.Core.Tests
{
    [TestClass]
    public class CharacterTests
    {
        [TestMethod]
        public void Ctor_InitializesBaseStats()
        {
            // Act
            var character = new Character();

            // Assert
            Assert.AreEqual(10, character.BaseCharisma);
            Assert.AreEqual(10, character.BaseConstitution);
            Assert.AreEqual(10, character.BaseDexterity);
            Assert.AreEqual(10, character.BaseIntelligence);
            Assert.AreEqual(10, character.BaseStrength);
            Assert.AreEqual(10, character.BaseWisdom);
        }

        [TestMethod]
        public void Ctor_InitializesAsUndefinedRace()
        {
            // Act
            var character = new Character();

            // Assert
            Assert.AreEqual(Race.Undefined, character.Race.RaceName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetRace_Null_Throws()
        {
            // Arrange
            ICharacter character = new Character();

            // Act
            character.SetRace(null);

            // Assert
            //ExpectedException
        }

        [TestMethod]
        public void SetRace_Dwarf_ChangesRace()
        {
            // Arrange
            ICharacter character = new Character();

            // Act
            character.SetRace(new Dwarf());

            // Assert
            Assert.AreEqual(Race.Dwarf, character.Race.RaceName);
        }
    }
}
