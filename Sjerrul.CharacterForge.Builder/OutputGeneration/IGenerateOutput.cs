using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Builder.OutputGeneration
{
    public interface IGenerateOutput<T>
    {
        T Generate(CharacterSheet characterSheet);
    }
}
