using Sjerrul.CharacterForge.Core.Abilities;
using Sjerrul.CharacterForge.Core.Races;

namespace Sjerrul.CharacterForge.Core
{
    public interface ICharacter
    {
        int BaseStrength { get; }
        int BaseCharisma { get; }
        int BaseDexterity { get; }
        int BaseIntelligence { get; }
        int BaseWisdom { get; }
        int BaseConstitution { get; }

        IRace Race { get; }

        void SetRace(IRace race);
    }
}
