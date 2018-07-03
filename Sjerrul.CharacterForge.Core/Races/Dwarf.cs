using Sjerrul.CharacterForge.Core.Abilities;
using Sjerrul.CharacterForge.Core.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Core.Races
{
    public class Dwarf : IRace
    {
        private IEnumerable<IFeature> features;

        public Dwarf()
        {
            this.features = new List<IFeature>
            {
                new SpeedModification(25),
                new Darkvision(60),
                new AbilityModifier(Ability.Constitution, +2)
            };
        }
    }
}
