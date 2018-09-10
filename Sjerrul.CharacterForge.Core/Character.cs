using Sjerrul.CharacterForge.Core.Classes;
using Sjerrul.CharacterForge.Core.Features;
using Sjerrul.CharacterForge.Core.Races;
using Sjerrul.CharacterForge.Utilities.Assertion;
using System.Collections.Generic;

namespace Sjerrul.CharacterForge.Core
{
    public class Character : ICharacter
    {
        public IRace Race { get; private set; }

        public IEnumerable<IClass> Classes { get; private set; }
        public IEnumerable<IFeature> Features => this.Race.Features;

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
            this.Level = 0;

            this.Classes = new List<IClass>();
        }

        public void SetRace(IRace race)
        {
            Guard.Against.ArgumentNull(race, nameof(race));

            this.Race = race;
        }
    }
}
