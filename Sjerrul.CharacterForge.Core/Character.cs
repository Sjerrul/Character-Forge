using Sjerrul.CharacterForge.Core.Abilities;
using Sjerrul.CharacterForge.Core.Races;
using Sjerrul.CharacterForge.Utilities.Assertion;
using System;
using System.Linq;

namespace Sjerrul.CharacterForge.Core
{
    public class Character : ICharacter
    {
        public IRace Race { get; private set; }

        public int BaseStrength { get; set; }
        public int BaseCharisma { get; set; }
        public int BaseDexterity { get; set; }
        public int BaseIntelligence { get; set; }
        public int BaseWisdom { get; set; }
        public int BaseConstitution { get; set; }

        public int Level { get; private set; }

        public Character()
        {
            this.BaseStrength = 10;
            this.BaseCharisma = 10;
            this.BaseDexterity = 10;
            this.BaseIntelligence = 10;
            this.BaseWisdom = 10;
            this.BaseConstitution = 10;

            this.Race = new UndefinedRace();
        }

        public void SetRace(IRace race)
        {
            Guard.Against.ArgumentNull(race, nameof(race));

            this.Race = race;
        }

        public void SetLevel(int level)
        {
            Guard.That(level > 0).WhenFalse.Throws<ArgumentException>($"Parameter level is {level}, but must be positive");
            Guard.That(level < 20).WhenFalse.Throws<ArgumentException>($"Parameter level is {level}, but must be less than 20");

            this.Level = level;
        }
    }
}
