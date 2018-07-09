using Sjerrul.CharacterForge.Core.Abilities;
using System;

namespace Sjerrul.CharacterForge.Core.Features
{
    public class AbilityModifier : IAbilityModifier
    {
        public AbilityName AbilityName { get; private set; }
        private readonly int modifier;

        public AbilityModifier(AbilityName abilityName, int modifier)
        {
            this.AbilityName = abilityName;
            this.modifier = modifier;
        }

        public int Modify(int score)
        {
            return score + this.modifier;
        }
    }
}
