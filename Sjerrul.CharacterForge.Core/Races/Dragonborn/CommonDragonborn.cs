using Sjerrul.CharacterForge.Core.Abilities;
using Sjerrul.CharacterForge.Core.Features;
using System.Collections.Generic;

namespace Sjerrul.CharacterForge.Core.Races.Dragonborn
{
    public class CommonDragonborn : BaseRace
    {
        public override string Race => "Dragonborn";

        public CommonDragonborn()
            : base()
        {
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
