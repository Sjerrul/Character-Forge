using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sjerrul.CharacterForge.Core.Races.Dwarf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Core.Tests.Races.Dwarf
{
    [TestClass]
    class HillDwarfTests
    {
        [TestMethod]
        public void Race_SetCorrectly()
        {
            //Arrange
            var race = new HillDwarf();

            Assert.AreEqual("Hill Dwarf", race.Race);
        }

        [TestMethod]
        public void AbilityAdjustments_AreCorrectlyAdditative()
        {
            //Arrange
            var race = new HillDwarf();

            Assert.AreEqual(2, race.AbilityAdjustments.Count());
        }
    }
}
