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

using LuzFaltex.VintageStory.CoreLib.Providers;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

namespace LuzFaltex.VintageStory.CoreLib.Extensions
{
    /// <summary>
    /// Provides a set of extensions for the <see cref="ICoreAPI"/> and derivitives.
    /// </summary>
    public static class CoreAPIExtensions
    {
        /// <summary>
        /// Gets the Provider Tracker for the server or client instance.
        /// </summary>
        /// <param name="api">The api to modify.</param>
        /// <returns>A <see cref="ProviderLibrary"/> instance which tracks available providers.</returns>
        public static ProviderLibrary GetProviderLibrary(this ICoreServerAPI api)
        {
            return api.ModLoader.GetModSystem<CoreLib>().ProviderLibrary;
        }
    }
}
