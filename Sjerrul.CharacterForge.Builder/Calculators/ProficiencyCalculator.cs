using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Builder.Calculators
{
    public static class ProficiencyCalculator
    {
        public static int CalculateProficiency(int level)
        {
            return (int)Math.Ceiling((decimal)level /  4) + 1;
        }
    }
}
