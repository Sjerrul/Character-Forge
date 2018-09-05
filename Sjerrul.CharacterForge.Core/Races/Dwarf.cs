using Sjerrul.CharacterForge.Core.Abilities;
using Sjerrul.CharacterForge.Core.Features;
using Sjerrul.CharacterForge.Core.Races.Subraces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Core.Races
{
    public class Dwarf : BaseRace
    {
        public override RaceName RaceName => RaceName.Dwarf;

        public Dwarf()
            : base()
        {
            this.Features = new List<IFeature>
            {
                new SpeedModification(25),
                new Darkvision(60),
            };

            this.AbilityAdjustments = new List<IAbilityAdjustment>
            {
                new AbilityAdjustment(AbilityName.Constitution, +2)
            };
        }
    }
}
