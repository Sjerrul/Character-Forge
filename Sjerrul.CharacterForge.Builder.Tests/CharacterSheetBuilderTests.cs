﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sjerrul.CharacterForge.Core;
using Sjerrul.CharacterForge.Core.Races.Dragonborn;
using Sjerrul.CharacterForge.Core.Races.Dwarf;

namespace Sjerrul.CharacterForge.Builder.Tests
{
    [TestClass]
    public class CharacterSheetBuilderTests
    {
        private CharacterSheetBuilder builder;

        [TestInitialize]
        public void Initialize()
        {
            this.builder = new CharacterSheetBuilder();
        }

        [TestMethod]
        public void GetAbilityScore_Dwarf_ReturnsCorrectStatistic()
        {
            // Arrange
            ICharacter character = new Character();
            character.SetRace(new CommonDwarf());

            // Act
            CharacterSheet charactersheet = builder.Build(character);

            // Assert
            Assert.AreEqual(10 + 2, charactersheet.Consitution);
        }

        [TestMethod]
        public void GetAbilityScore_Dragonborn_ReturnsCorrectStatistic()
        {
            // Arrange
            ICharacter character = new Character();
            character.SetRace(new CommonDragonborn());

            // Act
            CharacterSheet charactersheet = builder.Build(character);

            // Assert
            Assert.AreEqual(10 + 1, charactersheet.Charisma);
            Assert.AreEqual(10 + 2, charactersheet.Strength);
        }
    }
}
