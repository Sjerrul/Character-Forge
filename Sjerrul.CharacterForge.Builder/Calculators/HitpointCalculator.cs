using Sjerrul.CharacterForge.Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Builder.Calculators
{
    public static class HitpointCalculator
    {
        public static int CalculateHitpoints(IEnumerable<IClass> classes)
        {
            return classes.Sum(c => c.HitDie);
        }
    }
}
