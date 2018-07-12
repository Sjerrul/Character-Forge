using Sjerrul.CharacterForge.Builder.Rules;
using Sjerrul.CharacterForge.Builder.Rules.Race;
using Sjerrul.CharacterForge.Builder.Violations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Builder.Factories
{
    public class RulesFactory : IRulesFactory
    {
        public IEnumerable<IRule> BuildRuleset()
        {
            return new List<IRule>
            {
                new CharacterMustHaveRaceRule()
            };
        }
    }
}
