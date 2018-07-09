using Sjerrul.CharacterForge.Core.Abilities;

namespace Sjerrul.CharacterForge.Core.Features
{
    public interface IAbilityModifier
    {
        AbilityName AbilityName { get; }

        int Modify(int score);
    }
}