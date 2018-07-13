using Sjerrul.CharacterForge.Core.Abilities;
using Sjerrul.CharacterForge.Core.Features;
using Sjerrul.CharacterForge.Core.Races.Subraces;
using Sjerrul.CharacterForge.Core.Races.Subraces.Dwarf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Core.Races
{
    public class Dragonborn : BaseRace
    {
        public override Race RaceName => Race.Dragonborn;

        public Dragonborn()
            : base()
        {
            this.PossibleSubraces = new List<ISubrace>
            {
                new BlackAncestry()
            };


            this.Features = new List<IFeature>
            {
                new SpeedModification(30)
            };

            this.AbilityAdjustments = new List<IAbilityAdjustment>
            {
                new AbilityAdjustment(AbilityName.Strength, +2),
                new AbilityAdjustment(AbilityName.Charisma, +1)
            };
        }
    }
}
