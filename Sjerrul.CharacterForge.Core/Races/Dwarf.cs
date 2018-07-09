﻿using Sjerrul.CharacterForge.Core.Abilities;
using Sjerrul.CharacterForge.Core.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Core.Races
{
    public class Dwarf : BaseRace
    {
        public override Race Race => Race.Dwarf;

        public Dwarf()
            : base()
        {
            this.Features = new List<IFeature>
            {
                new SpeedModification(25),
                new Darkvision(60),
            };

            this.AbilityModifiers = new List<IAbilityModifier>
            {
                new AbilityModifier(AbilityName.Constitution, +2)
            };
        }
    }
}
