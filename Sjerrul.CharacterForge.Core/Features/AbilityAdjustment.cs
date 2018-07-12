using Sjerrul.CharacterForge.Core.Abilities;
using System;

namespace Sjerrul.CharacterForge.Core.Features
{
    public class AbilityAdjustment : IAbilityAdjustment
    {
        public AbilityName AbilityName { get; private set; }
        public int Adjustment { get; private set; }

        public AbilityAdjustment(AbilityName abilityName, int adjustment)
        {
            this.AbilityName = abilityName;
            this.Adjustment = adjustment;
        }
    }
}
