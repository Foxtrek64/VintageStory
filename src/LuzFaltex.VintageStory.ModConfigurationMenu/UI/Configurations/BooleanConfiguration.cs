//
//  BooleanConfiguration.cs
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

namespace LuzFaltex.VintageStory.ModConfigurationMenu.UI.Configurations
{
    /// <summary>
    /// Provides an option that is a boolean configuration, that is, an option that accepts true/false or yes/no.
    /// </summary>
    public sealed record class BooleanConfiguration(string Name, string? Description = null) : IConfiguration<bool>
    {
        /// <inheritdoc/>
        public bool Value { get; set; }

        /// <summary>
        /// Gets or sets the text used for the truthy value.
        /// </summary>
        public string TrueText { get; set; } = "True";

        /// <summary>
        /// Gets or sets the string used for the falsy value.
        /// </summary>
        public string FalseText { get; set; } = "False";
    }
}
