using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sjerrul.CharacterForge.Core.Races;
using Sjerrul.CharacterForge.Core.Races.Dwarf;
using System;

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
            Assert.AreEqual("Undefined", character.Race.Race);
        }

        [TestMethod]
        public void Ctor_InitializesAsLevelZero()
        {
            // Act
            var character = new Character();

            // Assert
            Assert.AreEqual(0, character.Level);
        }

        [TestMethod]
        public void SetRace_NullRace_Throws()
        {
            // Arrange
            ICharacter character = new Character();

            // Assert
            Assert.ThrowsException<ArgumentNullException>(() => character.SetRace((IRace)null));
        }

        [TestMethod]
        public void SetRace_Dwarf_ChangesRace()
        {
            // Arrange
            ICharacter character = new Character();

            // Act
            character.SetRace(new CommonDwarf());

            // Assert
            Assert.AreEqual("Dwarf", character.Race.Race);
        }
    }
}
