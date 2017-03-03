﻿using DnD.Classes.CharacterClasses;
using DnD.Enums.ClassFeats;
using DnD.Enums.Stats;
using System.Collections.Generic;

namespace DnD.Classes.HeroFeats
{
    /// <summary>
    /// The ForgeRing Feat.
    /// </summary>
    public class ForgeRing : BaseFeat
    {
        /// <summary>
        /// Returns the value of required base attack for the ForgeRing feat.
        /// </summary>
        public override int? AttackBonusPrerequisites => null;

        /// <summary>
        /// Returns the associated List of required Feats that the ForgeRing feat requires.
        /// Null if no required Feats.
        /// </summary>
        public override List<BaseFeat> FeatPrerequisites => null;

        /// <summary>
        /// Returns a Class type with a Level if there is a required Class restriction on this feat.
        /// </summary>
        public override BaseCharacterClass ClassLevelPrerequisites => new Caster {ClassLevel = 12};

        /// <summary>
        /// Returns a dictionary where KEY represents the required stat and VALUE = the value of that stat.
        /// </summary>
        public override Dictionary<Stats, int> MinimumRequiredStat => null;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.FeatStrings.ForgeRing;

        /// <summary>
        /// Returns the enumeration type of Feat this particular Feat represents.
        /// </summary>
        public override ClassFeats FeatType => ClassFeats.ForgeRing;
    }
}
