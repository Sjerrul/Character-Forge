using Sjerrul.CharacterForge.Utilities.Assertion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Core.Features
{
    public class Darkvision : IFeature
    {
        private readonly int range;

        public string Description => $"You can see {range} ft. in total darkness";

        /// <summary>
        /// Initializes a new instance of the <see cref="Darkvision"/> class.
        /// </summary>
        /// <param name="range">The dark vision range.</param>
        public Darkvision(int range)
        {
            Guard.That(range > 0).WhenFalse.Throws<ArgumentOutOfRangeException>($"Darkvision range must be positive");

            this.range = range;
        }
    }
}
