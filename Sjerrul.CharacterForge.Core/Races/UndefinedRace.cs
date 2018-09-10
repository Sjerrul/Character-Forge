using Sjerrul.CharacterForge.Core.Abilities;
using Sjerrul.CharacterForge.Core.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Core.Races
{
    public class UndefinedRace : BaseRace
    {
        public override string Race => "Undefined";

        public UndefinedRace()
            : base()
        {

        }
    }
}
