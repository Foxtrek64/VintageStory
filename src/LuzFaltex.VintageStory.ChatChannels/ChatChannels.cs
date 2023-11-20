//
//  ChatChannels.cs
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
using Vintagestory.API.Common;
using Vintagestory.API.Datastructures;
using Vintagestory.API.Server;

[assembly: ModInfo
(
    "LuzFaltex.VintageStory.ChatChannels",
    Authors = new string[] { "Unknown" },
    Description = "This is a sample mod",
    Version = "1.0.0"
)
]

namespace LuzFaltex.VintageStory.ChatChannels
{
    /// <summary>
    /// A plugin that allows for chatting in multiple, configurable chat channels.
    /// </summary>
    public class ChatChannels : ModSystem
    {
        /// <inheritdoc/>
        public override void AssetsFinalize(ICoreAPI api)
        {
            // TODO: Load chat channels here.
        }

        /// <inheritdoc/>
        public override void StartServerSide(ICoreServerAPI api)
        {
            api.Event.PlayerChat += OnChatMessage;

            api.ChatCommands.Create("tp")
                .RequiresPlayer()
                .HandleWith(HandleTeleport);
        }

        private TextCommandResult HandleTeleport(TextCommandCallingArgs args)
        {
            // Teleport the player
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fired when a player sends a chat message.
        /// </summary>
        /// <param name="sender">The player who sent the chat message.</param>
        /// <param name="channelId">The id of the channel the message is being sent in.</param>
        /// <param name="message">The chat message.</param>
        /// <param name="data">Context attached to the message.</param>
        /// <param name="handled">If <see langword="true"/>, the event is considered handled and will not be processed further.</param>
        private void OnChatMessage(IServerPlayer sender, int channelId, ref string message, ref string data, BoolRef handled)
        {
            /* Sample code
            string channelFormat = GetChannel(channelId).Format;
            var originalMessage = message;

            message = channelFormat.Replace("{Player}", sender.PlayerName).Replace("{Message}", originalMessage);
            PlaceholderAPI.PerformReplacements(ref message, sender, data);
            */
            // End sample code
            if (channelId != 0)
            {
                return;
            }
        }
    }
}
