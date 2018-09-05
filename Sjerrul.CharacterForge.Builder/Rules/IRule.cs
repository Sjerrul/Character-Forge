using Sjerrul.CharacterForge.Builder.Violations;
using Sjerrul.CharacterForge.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Builder.Rules
{
    public interface IRule
    {
        IEnumerable<IViolation> Check(ICharacter character);
    }
}
