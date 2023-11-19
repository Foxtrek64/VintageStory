//
//  IChatChannel.cs
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
using System.Drawing;

namespace LuzFaltex.VintageStory.ChatChannels.Models
{
    /// <summary>
    /// Describes a configurable chat channel.
    /// </summary>
    public interface IChatChannel
    {
        /// <summary>
        /// Gets the name of the channel.
        /// </summary>
        public Guid ChannelId { get; }

        /// <summary>
        /// Gets the color of the channel.
        /// </summary>
        public Color Color { get; }

        /// <summary>
        /// Gets the color of the chat message sent in the channel.
        /// </summary>
        public Color ChatColor { get; }

        /// <summary>
        /// Gets a value indicating whether a new player should automatically subscribe to the channel.
        /// </summary>
        public bool AutoJoin { get; }

        /// <summary>
        /// Gets a short-hand name for selecting.
        /// </summary>
        public string DisplayName { get; }

        /// <summary>
        /// Gets a value that determines the distance (in blocks) of a ranged chat channel. Set to 0 for a global channel.
        /// </summary>
        public double Distance { get; }

        /// <summary>
        /// Gets a time which must elapse before a player can send another message.
        /// </summary>
        public TimeSpan Cooldown { get; }

        /// <summary>
        /// Gets the prefix for the channel.
        /// </summary>
        public string ChannelPrefix { get; }

        /// <summary>
        /// Gets the suffix for the channel.
        /// </summary>
        public string ChannelSuffix { get; }
    }
}
