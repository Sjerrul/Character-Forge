using Sjerrul.CharacterForge.Core.Features;
using Sjerrul.CharacterForge.Utilities.Assertion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Core.Races
{
    public abstract class BaseRace : IRace
    {
        public IEnumerable<IFeature> Features { get; protected set; }

        public abstract Race Race { get; }

        public IEnumerable<IAbilityModifiers> AbilityModifiers { get; protected set; }

        protected BaseRace()
        {
            this.Features = new List<IFeature>();
            this.AbilityModifiers = new List<IAbilityModifiers>();
        }
    }
}
