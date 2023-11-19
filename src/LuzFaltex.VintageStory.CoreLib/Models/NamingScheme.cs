//
//  NamingScheme.cs
//
//  Author:
//       LuzFaltex Contributors <support@luzfaltes.com>
//
//  Copyright (c) LuzFaltex, LLC.
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

namespace LuzFaltex.VintageStory.CoreLib.Models
{
    /// <summary>
    /// Provides a naming scheme for an item.
    /// </summary>
    /// <param name="SingularLowercaseNoun">The name of a singular kind of item, all lower case. Example: record.</param>
    /// <param name="PluralLowercaseNoun">The name of group of items, all lower case. Example: records.</param>
    /// <param name="SingularCapitalizedNoun">The name of a singular kind of item, capitalized. Example: Record.</param>
    /// <param name="PluralCapitalizedNoun">The name of a group of items, capitalized. Example: Records.</param>
    /// <param name="IndefiniteArticle">The indefinite article used for a single record, typically "a" or "an".</param>
    public sealed record class NamingScheme
    (
        string SingularLowercaseNoun,
        string PluralLowercaseNoun,
        string SingularCapitalizedNoun,
        string PluralCapitalizedNoun,
        string IndefiniteArticle
    )
    {
        /// <summary>
        /// Gets the name of a singular kind of item, all lower case.
        /// </summary>
        /// <remarks>Example: record.</remarks>
        /// <example>
        /// record.
        /// </example>
        public string SingularLowercaseNoun { get; } = SingularLowercaseNoun;

        /// <summary>
        /// Gets the name of a group of items, all lower case.
        /// </summary>
        /// <remarks>
        /// Example: records.
        /// </remarks>
        public string PluralLowercaseNoun { get; } = PluralLowercaseNoun;

        /// <summary>
        /// Gets the name of a singular kind of item, capitalized.
        /// </summary>
        /// <remarks>
        /// Example: Record.
        /// </remarks>
        public string SingularCapitalizedNoun { get; } = SingularCapitalizedNoun;

        /// <summary>
        /// Gets the name of a group of items, capitalized.
        /// </summary>
        /// <remarks>
        /// Example: Records.
        /// </remarks>
        public string PluralCapitalizedNoun { get; } = PluralCapitalizedNoun;

        /// <summary>
        /// Gets the indefinite article used for a single record, typically "a" or "an".
        /// </summary>
        /// <remarks>
        /// Used in logging as {IndefiniteArticle} {CurrencyNameSingularLower}, which should result in "a septim" or "an aureus".
        /// </remarks>
        public string IndefiniteArticle { get; } = IndefiniteArticle;
    }
}
