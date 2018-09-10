using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sjerrul.CharacterForge.Core.Abilities;
using Sjerrul.CharacterForge.Core.Features;
using Sjerrul.CharacterForge.Utilities.Extensions;

namespace Sjerrul.CharacterForge.Core.Races.Dwarf
{
    public class HillDwarf : CommonDwarf
    {
        public override string Race => "Hill Dwarf";

        public override IEnumerable<IFeature> Features 
            => base.Features.Concat(new HitpointModification(+1));

        public override IEnumerable<IAbilityAdjustment> AbilityAdjustments 
            => base.AbilityAdjustments.Concat(new AbilityAdjustment(AbilityName.Wisdom, +1));
    }
}
