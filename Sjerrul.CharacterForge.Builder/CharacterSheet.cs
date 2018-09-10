using Sjerrul.CharacterForge.Builder.Calculators;
using Sjerrul.CharacterForge.Core.Classes;
using Sjerrul.CharacterForge.Core.Features;
using Sjerrul.CharacterForge.Core.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Builder
{
    public class CharacterSheet
    {
        public int Level { get; internal set; }
        public IRace Race { get; internal set; }
        public IEnumerable<IClass> Classes { get; internal set; }
        public IEnumerable<IFeature> Features { get; internal set; }

        public int Hitpoints => HitpointCalculator.CalculateHitpoints(this.Classes);

        public int Strength { get; internal set; }
        public int Consitution { get; internal set; }
        public int Wisdom { get; internal set; }
        public int Intelligence { get; internal set; }
        public int Dexterity { get; internal set; }
        public int Charisma { get; internal set; }

        public int StrengthModifier => AbilityModifierCalculator.CalculateAbilityModifier(this.Strength);
        public int ConsitutionModifier => AbilityModifierCalculator.CalculateAbilityModifier(this.Consitution);
        public int WisdomModifier => AbilityModifierCalculator.CalculateAbilityModifier(this.Wisdom);
        public int IntelligenceModifier => AbilityModifierCalculator.CalculateAbilityModifier(this.Intelligence);
        public int DexterityModifier => AbilityModifierCalculator.CalculateAbilityModifier(this.Dexterity);
        public int CharismaModifier => AbilityModifierCalculator.CalculateAbilityModifier(this.Charisma);

        public int Proficiency => ProficiencyCalculator.CalculateProficiency(this.Level);
    }
}
