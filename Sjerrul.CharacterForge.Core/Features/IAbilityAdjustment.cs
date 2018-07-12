using Sjerrul.CharacterForge.Core.Abilities;

namespace Sjerrul.CharacterForge.Core.Features
{
    public interface IAbilityAdjustment
    {
        AbilityName AbilityName { get; }
        int Adjustment { get; }
    }
}