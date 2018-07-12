using Sjerrul.CharacterForge.Core.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Core.Races
{
    public interface IRace
    {
        Race RaceName { get; }

        IEnumerable<IFeature> Features { get; }

        IEnumerable<IAbilityAdjustment> AbilityAdjustments { get; }
    }
}
