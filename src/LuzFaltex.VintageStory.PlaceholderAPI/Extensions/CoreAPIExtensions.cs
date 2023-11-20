//
//  CoreAPIExtensions.cs
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

using Vintagestory.API.Common;

namespace LuzFaltex.VintageStory.PlaceholderAPI.Extensions
{
    /// <summary>
    /// Provides a set of extensions for <see cref="ICoreAPI"/>.
    /// </summary>
    public static class CoreAPIExtensions
    {
        /// <summary>
        /// Gets the placeholder API helper used for registering placeholders and replacements.
        /// </summary>
        /// <param name="api">The API to attach to.</param>
        /// <returns>The helper tool for placeholders.</returns>
        public static PlaceholderLib GetPlaceholderAPI(this ICoreAPI api)
        {
            return api.ModLoader.GetModSystem<PlaceholderAPI>().PlaceholderLib;
        }
    }
}
