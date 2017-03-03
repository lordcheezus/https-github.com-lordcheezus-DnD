﻿using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The TongueOfTheSunAndMoon Special.
    /// </summary>
    public class TongueOfTheSunAndMoon : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire TongueOfTheSunAndMoon.
        /// </summary>
        public override int? MinimumLevelRequirement => 17;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.TongueOfTheSunAndMoon;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.TongueOfTheSunAndMoon;
    }
}
