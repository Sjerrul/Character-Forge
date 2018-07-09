using Sjerrul.CharacterForge.Core.Abilities;
using Sjerrul.CharacterForge.Core.Races;

namespace Sjerrul.CharacterForge.Core
{
    public interface ICharacter
    {
        Race Race { get; }

        void SetBaseBaseAbilityScore(AbilityName ability, int score);

        int GetAbilityScore(AbilityName ability);

        void SetRace(Race race);
    }
}
