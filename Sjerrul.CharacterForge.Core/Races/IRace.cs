using Sjerrul.CharacterForge.Core.Features;
using System.Collections.Generic;

namespace Sjerrul.CharacterForge.Core.Races
{
    public interface IRace
    {
        string Race { get; }

        IEnumerable<IFeature> Features { get; }

        IEnumerable<IAbilityAdjustment> AbilityAdjustments { get; }
    }
}
