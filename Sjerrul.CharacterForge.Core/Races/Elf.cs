using Sjerrul.CharacterForge.Core.Abilities;
using Sjerrul.CharacterForge.Core.Features;
using Sjerrul.CharacterForge.Core.Races.Subraces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Core.Races
{
    public class Elf : BaseRace
    {
        public override RaceName RaceName => RaceName.Elf;

        public Elf()
            : base()
        {
            this.Features = new List<IFeature>
            {
                new Trance(),
                new Darkvision(60),
            };
        }
    }
}
