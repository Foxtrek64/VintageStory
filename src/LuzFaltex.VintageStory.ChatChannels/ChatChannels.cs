using System;
using Vintagestory.API.Common;
using Vintagestory.API.Datastructures;
using Vintagestory.API.Server;

[assembly: ModInfo("LuzFaltex.VintageStory.ChatChannels",
                    Authors = new string[] { "Unknown" },
                    Description = "This is a sample mod",
                    Version = "1.0.0")]

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
            // Sample code
            string channelFormat = GetChannel(channelId).Format;
            var originalMessage = message;

            message = channelFormat.Replace("{Player}", sender.PlayerName).Replace("{Message}", originalMessage);
            PlaceholderAPI.PerformReplacements(ref message);
            // End sample code

            if (channelId != 0)
            {
                return;
            }
        }
    }
}
