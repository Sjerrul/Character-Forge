using Sjerrul.CharacterForge.Core;
using Sjerrul.CharacterForge.Core.Abilities;
using Sjerrul.CharacterForge.Core.Features;
using Sjerrul.CharacterForge.Utilities.Assertion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Builder
{
    public class CharacterSheetBuilder
    {
        public CharacterSheet Build(ICharacter character)
        {
            Guard.Against.ArgumentNull(character, nameof(character));

            var characterSheet = new CharacterSheet();

            SetAttributes(characterSheet, character);
            SetFeatures(characterSheet, character);
            characterSheet.Race = character.Race;
            characterSheet.Classes = character.Classes;
            characterSheet.Level = character.Level;

            return characterSheet;
        }

        private void SetFeatures(CharacterSheet characterSheet, ICharacter character)
        {
            characterSheet.Features = character.Features;
        }

        private void SetAttributes(CharacterSheet characterSheet, ICharacter character)
        {
            characterSheet.Strength = character.BaseStrength;
            characterSheet.Intelligence = character.BaseIntelligence;
            characterSheet.Charisma = character.BaseCharisma;
            characterSheet.Consitution = character.BaseConstitution;
            characterSheet.Dexterity = character.BaseDexterity;
            characterSheet.Wisdom = character.BaseWisdom;

            foreach (var adjustment in character.Race.AbilityAdjustments)
            {
                AdjustAbility(characterSheet, adjustment);
            }
        }

        private void AdjustAbility(CharacterSheet characterSheet, IAbilityAdjustment adjustment)
        {
            Guard.Against.ArgumentNull(characterSheet, nameof(characterSheet));
            Guard.Against.ArgumentNull(adjustment, nameof(adjustment));

            switch (adjustment.AbilityName)
            {
                case AbilityName.Constitution:
                    characterSheet.Consitution += adjustment.Adjustment;
                    break;
                case AbilityName.Strength:
                    characterSheet.Strength += adjustment.Adjustment;
                    break;
                case AbilityName.Dexterity:
                    characterSheet.Dexterity += adjustment.Adjustment;
                    break;
                case AbilityName.Wisdom:
                    characterSheet.Wisdom += adjustment.Adjustment;
                    break;
                case AbilityName.Intelligence:
                    characterSheet.Intelligence += adjustment.Adjustment;
                    break;
                case AbilityName.Charisma:
                    characterSheet.Charisma += adjustment.Adjustment;
                    break;
                default:
                    throw new ArgumentException($"Cannot Adjust ability, unknown ability '{adjustment.AbilityName}'");
            }
        }
    }
}
