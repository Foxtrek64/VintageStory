//
//  PlaceholderLib.cs
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
using LuzFaltex.VintageStory.PlaceholderAPI.Errors;
using Remora.Results;
using Vintagestory.API.Server;

namespace LuzFaltex.VintageStory.PlaceholderAPI
{
    /// <summary>
    /// Provides a set of tools for managing replacements.
    /// </summary>
    public sealed class PlaceholderLib
    {
        /// <summary>
        /// Gets a collection of currently registered handlers.
        /// </summary>
        public IReadOnlyDictionary<string, IReplacementHandler> Handlers => _handlers.AsReadOnly();

        private readonly Dictionary<string, IReplacementHandler> _handlers = new();

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
            if (!format.Contains("{message}", StringComparison.InvariantCultureIgnoreCase))
            {
                return new ArgumentFormatError(nameof(format), "The format string must contain a \"{Message}\" token.");
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Performs a replacement of the placeholders in the message. If a placeholder is not found for the token it is ignored.
        /// </summary>
        /// <param name="format">The format string for the message.</param>
        /// <returns>A result containing the formatted string or an error message.</returns>
        public Result<string> PerformReplacementRaw(string format)
        {
            throw new NotImplementedException();
        }
    }
}
