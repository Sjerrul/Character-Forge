using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sjerrul.CharacterForge.Core.Decorators;
using System;
using System.Linq;

namespace Sjerrul.CharacterForge.Core.Tests
{
    [TestClass]
    public class WizardDecoratorTests
    {
        [TestMethod]
        public void Ctor_NullCharacter_Throws()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new WizardDecorator(null));
        }

        [TestMethod]
        public void Level_DecoratedOnce_LevelIsOne()
        {
            // Arrange
            ICharacter character = new Character();

            // Act
            character = new WizardDecorator(character);

            // Assert
            Assert.AreEqual(1, character.Level);
        }

        [TestMethod]
        public void Level_DecoratedTwice_LevelIsTwo()
        {
            // Arrange
            ICharacter character = new Character();

            // Act
            character = new WizardDecorator(character);
            character = new WizardDecorator(character);

            // Assert
            Assert.AreEqual(2, character.Level);
        }

        [TestMethod]
        public void Classes_DecoratedOnce_ShowsCorrectClass()
        {
            // Arrange
            ICharacter character = new Character();

            // Act
            character = new WizardDecorator(character);

            // Assert
            Assert.AreEqual(1, character.Classes.Count);
            Assert.AreEqual(1, character.Classes.Count(x => x.Name == "Wizard"));
        }

        [TestMethod]
        public void Classes_DecoratedTwice_ShowsCorrectClasses()
        {
            // Arrange
            ICharacter character = new Character();

            // Act
            character = new WizardDecorator(character);
            character = new WizardDecorator(character);

            // Assert
            Assert.AreEqual(2, character.Classes.Count);
            Assert.AreEqual(2, character.Classes.Count(x => x.Name == "Wizard"));
        }
    }
}
