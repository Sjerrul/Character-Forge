using Sjerrul.CharacterForge.Core.Classes;
using Sjerrul.CharacterForge.Core.Features;
using Sjerrul.CharacterForge.Core.Races;
using System.Collections.Generic;

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

        int Level { get; }
        IRace Race { get; }
        IEnumerable<IClass> Classes { get; }
        IEnumerable<IFeature> Features { get; }

        void SetRace(IRace race);
    }
}
