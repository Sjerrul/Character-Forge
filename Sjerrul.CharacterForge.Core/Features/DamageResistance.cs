using Sjerrul.CharacterForge.Utilities.Assertion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Core.Features
{
    public class DamageResistance : IFeature
    {
        private readonly string typeOfDamage;

        public string Description => $"Resistance against {this.typeOfDamage.ToLower()} damage";

        /// <summary>
        /// Initializes a new instance of the <see cref="DamageResistance"/> class.
        /// </summary>
        /// <param name="typeOfDamage">The type of damage resistance.</param>
        public DamageResistance(string typeOfDamage)
        {
            Guard.Against.StringNullOrWhitespace(typeOfDamage, nameof(typeOfDamage));

            this.typeOfDamage = typeOfDamage;
        }
    }
}
