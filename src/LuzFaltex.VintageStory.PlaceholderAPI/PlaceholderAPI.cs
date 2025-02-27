﻿//
//  PlaceholderAPI.cs
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

using Vintagestory.API.Common;

/*
[assembly: ModInfo("LuzFaltex.VintageStory.PlaceholderAPI",
                    Authors = new string[] { "Unknown" },
                    Description = "This is a sample mod",
                    Version = "1.0.0")]
*/

namespace LuzFaltex.VintageStory.PlaceholderAPI
{
    /// <summary>
    /// A recreation of the PlaceholderAPI plugin from Minecraft.
    /// </summary>
    /// <seealso href="https://github.com/PlaceholderAPI/PlaceholderAPI"/>
    public class PlaceholderAPI : ModSystem
    {
        /// <summary>
        /// Gets the placeholder helper.
        /// </summary>
        public PlaceholderLib PlaceholderLib { get; } = new PlaceholderLib();
    }
}
