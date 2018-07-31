using Sjerrul.CharacterForge.Core.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Core.Classes
{
    public interface IClass
    {
        string Name { get; }
        int HitDie { get; }


    }
}
