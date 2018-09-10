using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sjerrul.CharacterForge.Core.Features;
using Sjerrul.CharacterForge.Utilities.Extensions;

namespace Sjerrul.CharacterForge.Core.Races.Dragonborn
{
    public class BlackDragonborn : CommonDragonborn
    {
        public override string Race => "Black Dragonborn";

        public override IEnumerable<IFeature> Features => base.Features.Concat(new DamageResistance("acid"));
    }
}
