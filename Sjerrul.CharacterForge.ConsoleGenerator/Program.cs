using Sjerrul.CharacterForge.Builder;
using Sjerrul.CharacterForge.Builder.Factories;
using Sjerrul.CharacterForge.Builder.OutputGeneration;
using Sjerrul.CharacterForge.Builder.Violations;
using Sjerrul.CharacterForge.Core;
using Sjerrul.CharacterForge.Core.Decorators;
using Sjerrul.CharacterForge.Core.Races.Dragonborn;
using Sjerrul.CharacterForge.Core.Races.Dwarf;
using System;
using System.Collections.Generic;
using System.IO;

namespace Sjerrul.CharacterForge.ConsoleGenerator
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CHARACTERFORGE - A D&D Character Generator");
            Console.WriteLine("==========================================");
            Console.WriteLine("This application currently only used as a");
            Console.WriteLine("test driver application and will generate a");
            Console.WriteLine("pre-defined character sheet");

            ICharacter character = BuildCharacter();

            CharacterSheetBuilder builder = new CharacterSheetBuilder();
            CharacterSheet sheet = builder.Build(character);

            IRulebook rules = new Rulebook(new RulesFactory());
            IEnumerable<IViolation> violations = rules.CheckRules(character);

            MarkdownGenerator generator = new MarkdownGenerator();
            string output = generator.Generate(sheet, violations);

            File.WriteAllText("charactersheet.md", output);
        }

        private static ICharacter BuildCharacter()
        {
            ICharacter character = new Character
            {
                BaseStrength = 17,
                BaseDexterity = 8,
                BaseWisdom = 10,
                BaseIntelligence = 14,
                BaseConstitution = 12,
                BaseCharisma = 10,
            };

            character.SetRace(new HillDwarf());
            character = new WizardDecorator(character);

            return character;
        }
    }
}
