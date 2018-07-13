using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Builder.Calculators
{
    public static class AbilityModifierCalculator
    {
        public static int CalculateAbilityModifier(int abilityScore)
        {
            return (abilityScore / 2) - 5;
        }
    }
}
