using Sjerrul.CharacterForge.Core.Abilities;
using Sjerrul.CharacterForge.Core.Races;
using System;
using System.Linq;

namespace Sjerrul.CharacterForge.Core
{
    public class Character : ICharacter
    {
        public Race Race => this.race.Race;

        private IRace race;

        public int Strength { get; private set; }
        public int Charisma { get; private set; }
        public int Dexterity { get; private set; }
        public int Intelligence { get; private set; }
        public int Wisdom { get; private set; }
        public int Constitution { get; private set; }

        public int Proficiency { get; private set; }

        public Character()
        {
            this.Strength = 10;
            this.Charisma = 10;
            this.Dexterity = 10;
            this.Intelligence = 10;
            this.Wisdom = 10;
            this.Constitution = 10;

            this.Proficiency = +2;

            this.race = new UndefinedRace();
        }

        public void SetRace(Race race)
        {
            switch (race)
            {
                case Race.Dwarf:
                    this.race = new Dwarf();
                    break;
                case Race.Dragonborn:
                    this.race = new Dragonborn();
                    break;
                default:
                    throw new InvalidOperationException($"Unable to set race, unknown race '{race}'");
            }
        }

        public void SetBaseBaseAbilityScore(AbilityName ability, int score)
        {
            switch (ability)
            {
                case AbilityName.Charisma:
                    this.Charisma = score;
                    break;
                case AbilityName.Constitution:
                    this.Constitution = score;
                    break;
                case AbilityName.Dexterity:
                    this.Dexterity = score;
                    break;
                case AbilityName.Intelligence:
                    this.Intelligence = score;
                    break;
                case AbilityName.Strength:
                    this.Strength = score;
                    break;
                case AbilityName.Wisdom:
                    this.Wisdom = score;
                    break;
                default:
                    throw new ArgumentException($"Unknown ability {ability}", nameof(ability));
            }
        }

        public int GetAbilityScore(AbilityName ability)
        {
            int score;

            switch (ability)
            {
                case AbilityName.Charisma:
                    score = this.Charisma;
                    break;
                case AbilityName.Constitution:
                    score = this.Constitution;
                    break;
                case AbilityName.Dexterity:
                    score = this.Dexterity;
                    break;
                case AbilityName.Intelligence:
                    score = this.Intelligence;
                    break;
                case AbilityName.Strength:
                    score = this.Strength;
                    break;
                case AbilityName.Wisdom:
                    score = this.Wisdom;
                    break;
                default:
                    throw new ArgumentException($"Unknown ability {ability}", nameof(ability));
            }

            foreach (var modifier in this.race.AbilityModifiers.Where(x => x.AbilityName == ability))
            {
                score = modifier.Modify(score);
            }

            return score;
        }
    }
}
