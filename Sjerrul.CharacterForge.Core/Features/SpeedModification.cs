using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Core.Features
{
    public class SpeedModification : IFeature
    {
        private readonly int speedModification;

        public string Description => $"Speed {this.speedModification.ToString("+#;-#;0")} ft.";

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeedModification"/> class.
        /// </summary>
        /// <param name="speedModification">The speed modification in feet.</param>
        public SpeedModification(int speedModification)
        {
            this.speedModification = speedModification;
        }

    }
}
