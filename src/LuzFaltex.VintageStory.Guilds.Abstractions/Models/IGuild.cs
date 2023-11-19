//
//  IGuild.cs
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
using JetBrains.Annotations;
using Vintagestory.API.Common;

namespace LuzFaltex.VintageStory.Guilds.Abstractions.Models
{
    /// <summary>
    /// Describes a guild.
    /// </summary>
    [PublicAPI]
    public interface IGuild
    {
        /// <summary>
        /// Gets the unique identifier of this guild.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Gets the owner of this guild.
        /// </summary>
        public IPlayer Owner { get; }

        /// <summary>
        /// Gets the name of the guild.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets a list of players who are members of the guild.
        /// </summary>
        public IReadOnlyList<IPlayer> Members { get; }

        /// <summary>
        /// Gets a value indicating whether taxation is enabled in the guild.
        /// </summary>
        /// <remarks>
        /// Relies on economy integration.
        /// </remarks>
        public bool IsTaxationEnabled { get; }
    }
}
