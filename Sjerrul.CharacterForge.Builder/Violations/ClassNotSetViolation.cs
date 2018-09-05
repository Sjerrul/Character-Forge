using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Builder.Violations
{
    public class ClassNotSetViolation : IViolation
    {
        public string Description => "The character does not have (at least one) class set";
    }
}
