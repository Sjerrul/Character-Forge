using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sjerrul.CharacterForge.Builder.Violations;
using Sjerrul.CharacterForge.Core;
using Sjerrul.CharacterForge.Core.Races;

namespace Sjerrul.CharacterForge.Builder.Rules.Race
{
    public class CharacterMustHaveRaceRule : IRule
    {
        public IEnumerable<IViolation> Check(ICharacter character)
        {
            if (character.Race.Race == "Undefined")
            {
                yield return new RaceNotSetViolation();
            }
        }
    }
}
