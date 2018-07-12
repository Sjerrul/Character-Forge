using Sjerrul.CharacterForge.Builder.Rules;
using Sjerrul.CharacterForge.Builder.Violations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Builder.Factories
{
    public interface IRulesFactory
    {
        IEnumerable<IRule> BuildRuleset();
    }
}
