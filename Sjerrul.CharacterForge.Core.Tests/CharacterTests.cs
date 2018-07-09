using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sjerrul.CharacterForge.Core.Abilities;
using Sjerrul.CharacterForge.Core.Races;

namespace Sjerrul.CharacterForge.Core.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Ctor_InitializesBaseStats()
        {
            // Act
            var character = new Character();

            // Assert
            Assert.AreEqual(10, character.GetAbilityScore(AbilityName.Charisma));
            Assert.AreEqual(10, character.GetAbilityScore(AbilityName.Constitution));
            Assert.AreEqual(10, character.GetAbilityScore(AbilityName.Dexterity));
            Assert.AreEqual(10, character.GetAbilityScore(AbilityName.Intelligence));
            Assert.AreEqual(10, character.GetAbilityScore(AbilityName.Strength));
            Assert.AreEqual(10, character.GetAbilityScore(AbilityName.Wisdom));
        }

        [TestMethod]
        public void Ctor_InitializesAsUndefinedRace()
        {
            // Act
            var character = new Character();

            // Assert
            Assert.AreEqual(Race.Undefined, character.Race);
        }

        [TestMethod]
        [DataRow(AbilityName.Charisma, 15)]
        [DataRow(AbilityName.Constitution, 100)]
        [DataRow(AbilityName.Dexterity, -15)]
        [DataRow(AbilityName.Intelligence, 0)]
        [DataRow(AbilityName.Strength, 12)]
        [DataRow(AbilityName.Wisdom, 8)]
        public void Ctor_SetBaseStatistic_SetsStatisticCorrectly(AbilityName ability, int score)
        {
            // Arrange
            var character = new Character();

            // Act
            character.SetBaseBaseAbilityScore(ability, score);

            // Assert
            Assert.AreEqual(score, character.GetAbilityScore(ability));
        }

        [TestMethod]
        public void SetRace_Dwarf_ChangesRace()
        {
            // Arrange
            ICharacter character = new Character();

            // Act
            character.SetRace(Race.Dwarf);

            // Assert
            Assert.AreEqual(Race.Dwarf, character.Race);
        }

        [TestMethod]
        public void GetAbilityScore_Dwarf_ReturnsCorrectStatistic()
        {
            // Arrange
            ICharacter character = new Character();
            character.SetRace(Race.Dwarf);

            // Act
            int constitution = character.GetAbilityScore(AbilityName.Constitution);

            // Assert
            Assert.AreEqual(10 + 2, constitution);
        }

        [TestMethod]
        public void GetAbilityScore_Dwarf_CheckIdempotence()
        {
            // Arrange
            ICharacter character = new Character();
            character.SetRace(Race.Dwarf);

            // Act
            int constitution = character.GetAbilityScore(AbilityName.Constitution);
            Assert.AreEqual(10 + 2, constitution);

            // Act
            constitution = character.GetAbilityScore(AbilityName.Constitution);
            Assert.AreEqual(10 + 2, constitution);
        }

        [TestMethod]
        public void GetAbilityScore_Dragonborn_ReturnsCorrectStatistic()
        {
            // Arrange
            ICharacter character = new Character();
            character.SetRace(Race.Dragonborn);

            // Act
            int charisma = character.GetAbilityScore(AbilityName.Charisma);
            int strength = character.GetAbilityScore(AbilityName.Strength);

            // Assert
            Assert.AreEqual(10 + 1, charisma);
            Assert.AreEqual(10 + 2, strength);
        }

        [TestMethod]
        public void GetAbilityScore_Dragonborn_CheckIdempotence()
        {
            // Arrange
            ICharacter character = new Character();
            character.SetRace(Race.Dragonborn);

            // Act
            int charisma = character.GetAbilityScore(AbilityName.Charisma);
            int strength = character.GetAbilityScore(AbilityName.Strength);
            Assert.AreEqual(10 + 1, charisma);
            Assert.AreEqual(10 + 2, strength);

            // Act
            charisma = character.GetAbilityScore(AbilityName.Charisma);
            strength = character.GetAbilityScore(AbilityName.Strength);
            Assert.AreEqual(10 + 1, charisma);
            Assert.AreEqual(10 + 2, strength);
        }
    }
}
