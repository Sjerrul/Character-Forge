using Sjerrul.CharacterForge.Core.Abilities;
using Sjerrul.CharacterForge.Core.Features;
using Sjerrul.CharacterForge.Utilities.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Sjerrul.CharacterForge.Core.Races.Elf
{
    public class HighElf : CommonElf
    {
        public override string Race => "High Elf";

        public override IEnumerable<IAbilityAdjustment> AbilityAdjustments
            => base.AbilityAdjustments.Concat(new AbilityAdjustment(AbilityName.Intelligence, +1));
    }
}
