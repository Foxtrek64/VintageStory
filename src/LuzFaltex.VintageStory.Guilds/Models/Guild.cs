//
//  Guild.cs
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
using LuzFaltex.VintageStory.Guilds.Abstractions.Models;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

namespace LuzFaltex.VintageStory.Guilds
{
    /// <summary>
    /// Provides a concrete model for a Guild.
    /// </summary>
    /// <param name="Owner">The creator/owner of the guild.</param>
    /// <param name="Name">The display name of the guild.</param>
    public sealed record class Guild
    (
        IServerPlayer Owner,
        string Name
    )
        : IGuild
    {
        /// <inheritdoc/>
        public Guid Id { get; } = Guid.NewGuid();

        /// <inheritdoc/>
        public IServerPlayer Owner { get; private set; } = Owner;

        /// <inheritdoc/>
        public string Name { get; private set; } = Name;

        /// <inheritdoc/>
        public IServerPlayer? Heir { get; set; }

        /// <inheritdoc/>
        public IReadOnlyList<IServerPlayer> Members => _players.AsReadOnly();

        private readonly List<IServerPlayer> _players = new();

        /// <inheritdoc/>
        public bool IsTaxationEnabled
        {
            get
            {
                // This is determined by three factors:
                // 1. Does CoreLib report that an economy mod is present?
                // 2. Is taxation enabled globally?
                // 3. Is taxation enabled in the guild?
                return false;

                // TODO: Update logic
            }
        }

        /// <summary>
        /// Sets the assigned heir.
        /// </summary>
        /// <param name="heir">The server player to assign.</param>
        public void SetHeir(IServerPlayer heir)
        {
            Heir = heir;
        }

        /// <summary>
        /// Specifies a new player to be the owner of the guild.
        /// </summary>
        /// <param name="owner">The new owner.</param>
        public void TransferOwnership(IServerPlayer owner)
        {
            Owner = owner;
        }

        /// <summary>
        /// Changes the name of the guild.
        /// </summary>
        /// <param name="name">The new name.</param>
        public void ChangeName(string name)
        {
            Name = name;
        }
    }
}
