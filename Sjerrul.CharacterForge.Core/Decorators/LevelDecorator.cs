using Sjerrul.CharacterForge.Core.Classes;
using Sjerrul.CharacterForge.Core.Features;
using Sjerrul.CharacterForge.Core.Races;
using Sjerrul.CharacterForge.Utilities.Assertion;
using System.Collections.Generic;

namespace Sjerrul.CharacterForge.Core.Decorators
{
    public abstract class LevelDecorator : ICharacter
    {
        private readonly ICharacter character;

        protected LevelDecorator(ICharacter character)
        {
            Guard.Against.ArgumentNull(character, nameof(character));

            this.character = character;
        }

        public int BaseStrength => this.character.BaseStrength;

        public int BaseCharisma => this.character.BaseCharisma;

        public int BaseDexterity => this.character.BaseDexterity;

        public int BaseIntelligence => this.character.BaseIntelligence;

        public int BaseWisdom => this.character.BaseWisdom;

        public int BaseConstitution => this.character.BaseConstitution;

        public IRace Race => this.character.Race;

        public virtual IEnumerable<IClass> Classes => this.character.Classes;
        public virtual IEnumerable<IFeature> Features => this.character.Race.Features;

        public int Level => this.character.Level + 1;

        public void SetRace(IRace race)
        {
            this.character.SetRace(race);
        }
    }
}
