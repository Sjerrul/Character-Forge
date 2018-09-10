using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sjerrul.CharacterForge.Core.Classes;
using Sjerrul.CharacterForge.Core.Features;
using Sjerrul.CharacterForge.Utilities.Extensions;

namespace Sjerrul.CharacterForge.Core.Decorators
{
    public class WizardDecorator : LevelDecorator
    {
        public WizardDecorator(ICharacter character) : base(character)
        {
        }

        public override IEnumerable<IClass> Classes => base.Classes.Concat(new Wizard());

        public override IEnumerable<IFeature> Features => base.Features;
    }
}
