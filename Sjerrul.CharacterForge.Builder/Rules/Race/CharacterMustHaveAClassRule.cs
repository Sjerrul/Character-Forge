using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sjerrul.CharacterForge.Builder.Violations;
using Sjerrul.CharacterForge.Core;

namespace Sjerrul.CharacterForge.Builder.Rules.Race
{
    public class CharacterMustHaveAClassRule : IRule
    {
        public IEnumerable<IViolation> Check(ICharacter character)
        {
            if (!character.Classes.Any())
            {
                yield return new ClassNotSetViolation();
            }
        }
    }
}
