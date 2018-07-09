using Sjerrul.CharacterForge.Core.Abilities;
using Sjerrul.CharacterForge.Core.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Core.Races
{
    public class Dragonborn : BaseRace
    {
        public override Race Race => Race.Dragonborn;

        public Dragonborn()
            : base()
        {
            this.Features = new List<IFeature>
            {
                new SpeedModification(30)
            };

            this.AbilityModifiers = new List<IAbilityModifier>
            {
                new AbilityModifier(AbilityName.Strength, +2),
                new AbilityModifier(AbilityName.Charisma, +1)
            };
        }
    }
}
