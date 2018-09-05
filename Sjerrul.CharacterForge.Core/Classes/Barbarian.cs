using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Core.Classes
{
    public class Barbarian : IClass
    {
        public int HitDie => 10;

        public string Name => "Barbarian";
    }
}
