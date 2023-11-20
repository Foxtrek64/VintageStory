﻿//
//  CoreServerAPIExtensions.cs
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
using Vintagestory.API.Server;

namespace LuzFaltex.VintageStory.Commands
{
    /// <summary>
    /// Provides a set of extensions for <see cref="ICoreServerAPI"/>.
    /// </summary>
    public static class CoreServerAPIExtensions
    {
        /// <summary>
        /// Registers all commands with the command system.
        /// </summary>
        /// <param name="api">The <see cref="ICoreServerAPI"/> to modify.</param>
        /// <returns>The current <see cref="ICoreServerAPI"/> for chaining.</returns>
        public static ICoreServerAPI AddCommands(this ICoreServerAPI api)
        {
            throw new NotImplementedException();
        }
    }
}
