using System.Collections.Generic;
using Sjerrul.CharacterForge.Builder.Violations;
using Sjerrul.CharacterForge.Core;

namespace Sjerrul.CharacterForge.Builder
{
    public interface IRulebook
    {
        IEnumerable<IViolation> CheckRules(Character character);
    }
}