using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sjerrul.CharacterForge.Core.Decorators;
using System;
using System.Linq;

namespace Sjerrul.CharacterForge.Core.Tests
{
    [TestClass]
    public class LevelDecoratorTests
    {
        [TestMethod]
        public void Level_DecoratedTwiceWithDifferentClasses_LevelIsTwo()
        {
            // Arrange
            ICharacter character = new Character();

            // Act
            character = new WizardDecorator(character);
            character = new BarbarianDecorator(character);

            // Assert
            Assert.AreEqual(2, character.Level);
        }

        [TestMethod]
        public void Classes_DecoratedTwiceWithDifferentClasses_ShowsCorrectClasses()
        {
            // Arrange
            ICharacter character = new Character();

            // Act
            character = new WizardDecorator(character);
            character = new BarbarianDecorator(character);

            // Assert
            Assert.AreEqual(2, character.Classes.Count());
            Assert.AreEqual(1, character.Classes.Count(x => x.Name == "Wizard"));
            Assert.AreEqual(1, character.Classes.Count(x => x.Name == "Barbarian"));
        }
    }
}
