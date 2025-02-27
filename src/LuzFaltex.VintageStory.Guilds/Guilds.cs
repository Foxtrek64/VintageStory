﻿//
//  Guilds.cs
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

using System.Collections.Generic;
using LuzFaltex.VintageStory.Guilds.Abstractions.Models;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

namespace LuzFaltex.VintageStory.Guilds
{
    /// <summary>
    /// Provides a <see cref="ModSystem"/> for the Guilded Empire mod.
    /// </summary>
    public class Guilds : ModSystem
    {
        /// <summary>
        /// Gets a readonly list of guilds managed by this system.
        /// </summary>
        public IReadOnlyList<IGuild> ManagedGuilds => _guilds.AsReadOnly();

        private readonly List<IGuild> _guilds = new();

        /// <inheritdoc/>
        public override void StartServerSide(ICoreServerAPI api)
        {
        }
    }
}
