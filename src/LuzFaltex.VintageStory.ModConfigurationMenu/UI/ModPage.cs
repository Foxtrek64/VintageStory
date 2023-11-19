//
//  ModPage.cs
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Vintagestory.API.Common;

namespace LuzFaltex.VintageStory.ModConfigurationMenu.UI
{
    /// <summary>
    /// Creates a mod page for the specified <typeparamref name="TModSystem"/>.
    /// </summary>
    /// <typeparam name="TModSystem">The mod system this page exists for.</typeparam>
    [PublicAPI]
    public sealed class ModPage<TModSystem>
        where TModSystem : ModSystem
    {
        /// <summary>
        /// The mod is uncategorized.
        /// </summary>
        public const string Uncategorized = nameof(Uncategorized);

        /// <summary>
        /// Gets or sets the category this page will be sorted under.
        /// </summary>
        public string Category { get; set; } = Uncategorized;

        /// <summary>
        /// Gets or sets a value indicating whether to hide empty sections.
        /// A section is considered to be empty if:
        /// <list type="bullet">
        /// <item>There are no configuration options in the section.</item>
        /// <item>The user does not have permission to configure the option and the configuration's <see cref="OptionVisibility"/> is set to <see cref="OptionVisibility.Collapsed"/>.</item>
        /// </list>
        /// </summary>
        public bool HideEmptySections { get; set; }

        public IReadOnlyList<Section>

        public ModPage<TModSystem> 
    }
}
