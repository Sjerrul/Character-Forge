using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sjerrul.CharacterForge.Builder.Violations;
using Sjerrul.CharacterForge.Core;

namespace Sjerrul.CharacterForge.Builder.Rules.Race
{
    public class CharacterMustHaveRaceRule : IRule
    {
        public IEnumerable<IViolation> Check(Character character)
        {
            if (character.Race.RaceName == Core.Races.Race.Undefined)
            {
                yield return new RaceNotSetViolation();
            }
        }
    }
}
