using Sjerrul.CharacterForge.Core.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Core.Features
{
    public class AbilityModifier : IFeature
    {
        private readonly Ability ability;
        private readonly int modification;

        public AbilityModifier(Ability ability, int modification)
        {
            this.ability = ability;
            this.modification = modification;
        }
    }
}
