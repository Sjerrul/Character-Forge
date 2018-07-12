﻿using Sjerrul.CharacterForge.Core.Features;
using Sjerrul.CharacterForge.Utilities.Assertion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Core.Races
{
    public abstract class BaseRace : IRace, IEquatable<IRace>
    {
        public IEnumerable<IFeature> Features { get; protected set; }

        public abstract Race RaceName { get; }

        public IEnumerable<IAbilityAdjustment> AbilityAdjustments { get; protected set; }

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

            return this.RaceName == other.RaceName;
        }

        public override int GetHashCode()
        {
            // Per Eric Lippert: https://stackoverflow.com/a/263416/1535282
            unchecked 
            {
                int hash = (int)2166136261;

                hash = (hash * 16777619) ^ this.RaceName.GetHashCode();

                return hash;
            }
        }
    }
}
