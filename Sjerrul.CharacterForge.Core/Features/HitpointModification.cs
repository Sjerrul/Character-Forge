using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Core.Features
{
    public class HitpointModification : IFeature
    {
        private readonly int hitpointModification;

        public string Description => $"Hitpoint maximum {this.hitpointModification.ToString("+#;-#;0")}";

        /// <summary>
        /// Initializes a new instance of the <see cref="HitpointModification"/> class.
        /// </summary>
        /// <param name="speedModification">The hitpoint modification in feet.</param>
        public HitpointModification(int hitpointModification)
        {
            this.hitpointModification = hitpointModification;
        }

    }
}
