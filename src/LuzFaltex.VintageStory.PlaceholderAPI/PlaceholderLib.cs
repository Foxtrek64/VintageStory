using Remora.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vintagestory.API.Server;

namespace LuzFaltex.VintageStory.PlaceholderAPI
{
    public sealed class PlaceholderLib
    {
        public IReadOnlyDictionary<string, IReplacementHandler> Handlers => _handlers.AsReadOnly();

        private Dictionary<string, IReplacementHandler> _handlers;

        public PlaceholderLib()
        {
            _handlers = new Dictionary<string, IReplacementHandler>();
        }

        /// <summary>
        /// Regsiter a replacement handler.
        /// </summary>
        /// <param name="replacement">The tag to replace, without brackets.</param>
        /// <param name="handler">The handler to use to perform the replacement.</param>
        public void RegisterHandler(string replacement, IReplacementHandler handler)
        {
            _handlers[replacement] = handler;
        }

        /// <summary>
        /// Performs replacement of the placeholders in the chat message.
        /// </summary>
        /// <param name="format">The format string. Must contain a token for the message.</param>
        /// <param name="message">The raw message.</param>
        /// <param name="player">The player who sent the message.</param>
        /// <returns>A result containing the formatted string or an error message.</returns>
        public Result<string> PerformChatMessageReplacement(string format, string message, IServerPlayer player)
        {

        }

        /// <summary>
        /// Performs a replacement of the placeholders in the message. If a placeholder is not found for the token it is ignored.
        /// </summary>
        /// <param name="format">The format string for the message.</param>
        /// <returns>A result containing the formatted string or an error message.</returns>
        public Result<string> PerformReplacementRaw(string format)
        {

        }
    }
}
