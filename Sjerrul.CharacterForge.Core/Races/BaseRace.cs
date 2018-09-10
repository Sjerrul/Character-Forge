using Sjerrul.CharacterForge.Core.Features;
using System;
using System.Collections.Generic;

namespace Sjerrul.CharacterForge.Core.Races
{
    public abstract class BaseRace : IRace, IEqualityComparer<IRace>
    {
        public abstract string Race { get; }

        public virtual IEnumerable<IFeature> Features { get; protected set; }

        public virtual IEnumerable<IAbilityAdjustment> AbilityAdjustments { get; protected set; }

        protected BaseRace()
        {
            this.Features = new List<IFeature>();
            this.AbilityAdjustments = new List<IAbilityAdjustment>();
        }

        public bool Equals(IRace other)
        {
            if (other == null)
            {
                return false;
            }

            return this.Race == other.Race;
        }

        public bool Equals(IRace x, IRace y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode(IRace obj)
        {
            // Per Eric Lippert: https://stackoverflow.com/a/263416/1535282
            unchecked
            {
                int hash = (int)2166136261;

                hash = (hash * 16777619) ^ this.Race.GetHashCode();

                return hash;
            }
        }
    }
}
