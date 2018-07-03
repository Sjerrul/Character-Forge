using Sjerrul.CharacterForge.Core.Races;
using Sjerrul.CharacterForge.Utilities.Assertion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Core
{
    public class Character
    {
        private readonly IRace race;

        public Character(IRace race)
        {
            Guard.Against.ArgumentNull(race, nameof(race));

            this.race = race;
        }
    }
}
