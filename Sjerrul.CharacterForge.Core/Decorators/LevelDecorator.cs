using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sjerrul.CharacterForge.Core.Classes;
using Sjerrul.CharacterForge.Core.Races;
using Sjerrul.CharacterForge.Core.Races.Subraces;
using Sjerrul.CharacterForge.Utilities.Assertion;

namespace Sjerrul.CharacterForge.Core.Decorators
{
    public abstract class LevelDecorator : ICharacter
    {
        protected readonly ICharacter character;

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

        public abstract IList<IClass> Classes { get; }

        public int Level => this.character.Level + 1;

        public void SetRace(IRace race)
        {
            this.character.SetRace(race);
        }

        public void SetRace(ISubrace subrace)
        {
            this.character.SetRace(subrace);
        }
    }
}
