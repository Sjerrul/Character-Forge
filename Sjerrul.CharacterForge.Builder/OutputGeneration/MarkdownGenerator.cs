using Sjerrul.CharacterForge.Builder.Violations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Builder.OutputGeneration
{
    public class MarkdownGenerator : IGenerateOutput<string>
    {
        public string Generate(CharacterSheet characterSheet)
        {
            StringBuilder output = BuildCharacterMarkdown(characterSheet);

            return output.ToString();
        }

        public string Generate(CharacterSheet characterSheet, IEnumerable<IViolation> violations)
        {
            StringBuilder output = BuildCharacterMarkdown(characterSheet);

            if (violations != null && violations.Any())
            {
                AppendViolationBlock(output, violations);
            }

            return output.ToString();
        }

        private StringBuilder BuildCharacterMarkdown(CharacterSheet characterSheet)
        {
            StringBuilder output = new StringBuilder();

            AppendBaseDescription(output, characterSheet);
            AppendAbilityBlock(output, characterSheet);
            AppendFeatureBlock(output, characterSheet);

            return output;
        }

        private void AppendBaseDescription(StringBuilder output, CharacterSheet sheet)
        {
            string classesDescription = string.Join("/", sheet.Classes.Select(x => x.Name));
            output.AppendLine($"# {sheet.Race.RaceName} {classesDescription} (Level {sheet.Level})");
        }

        private void AppendAbilityBlock(StringBuilder output, CharacterSheet sheet)
        {
            output.AppendLine("STR|DEX|WIS|INT|CON|CHA");
            output.AppendLine("---|---|---|---|---|---");
            output.AppendLine(GetAbilityRow(sheet));
            output.AppendLine(GetAbilityModifierRow(sheet));
        }

        private void AppendFeatureBlock(StringBuilder output, CharacterSheet sheet)
        {
            output.AppendLine("# Features");
            foreach (var feature in sheet.Race.Features)
            {
                output.AppendLine(feature.Description);
            }
        }

        private void AppendViolationBlock(StringBuilder output, IEnumerable<IViolation> violations)
        {
            output.AppendLine("# Rule Violations");
            foreach (var violation in violations)
            {
                output.AppendLine(violation.Description);
            }
        }

        private string GetAbilityRow(CharacterSheet sheet)
        {
            return $"{sheet.Strength}|{sheet.Dexterity}|{sheet.Wisdom}|{sheet.Intelligence}|{sheet.Consitution}|{sheet.Charisma}";
        }

        private string GetAbilityModifierRow(CharacterSheet sheet)
        {
            return $"{sheet.StrengthModifier}|{sheet.DexterityModifier}|{sheet.WisdomModifier}|{sheet.IntelligenceModifier}|{sheet.ConsitutionModifier}|{sheet.CharismaModifier}";
        }
    }
}
