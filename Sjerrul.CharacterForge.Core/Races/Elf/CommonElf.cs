using Sjerrul.CharacterForge.Core.Features;
using System.Collections.Generic;

namespace Sjerrul.CharacterForge.Core.Races.Elf
{
    public class CommonElf : BaseRace
    {
        public override string Race => "Elf";

        public CommonElf()
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
