//
//  PlayerConfiguration.cs
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

using Vintagestory.API.Server;

namespace LuzFaltex.VintageStory.ModConfigurationMenu.UI.Configurations
{
    /// <summary>
    /// Provides a configuration that accepts a player, with autocomplete support.
    /// </summary>
    /// <param name="Name">The name of the option.</param>
    /// <param name="Description">A description of the option.</param>
    public sealed record class PlayerConfiguration(string Name, string? Description = null) : IConfiguration<IServerPlayer?>
    {
        /// <inheritdoc/>
        public IServerPlayer? Value { get; set; } = null;
    }
}
