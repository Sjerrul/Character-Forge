using Sjerrul.CharacterForge.Core.Abilities;
using Sjerrul.CharacterForge.Core.Features;
using System.Collections.Generic;

namespace Sjerrul.CharacterForge.Core.Races.Dwarf
{
    public class CommonDwarf : BaseRace
    {
        public override string Race => "Dwarf";

        public CommonDwarf()
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
