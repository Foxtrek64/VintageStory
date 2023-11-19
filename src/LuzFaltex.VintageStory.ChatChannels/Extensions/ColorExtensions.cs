//
//  ColorExtensions.cs
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

using System.Drawing;

namespace LuzFaltex.VintageStory.ChatChannels.Extensions
{
    /// <summary>
    /// Provides a set of extensions for <see cref="Color"/>.
    /// </summary>
    public static class ColorExtensions
    {
        /// <summary>
        /// Formats the color as a hexadecimal string.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <returns>The color's RGB values formatted as #RRGGBB.</returns>
        public static string ToHexadecimal(this Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }
    }
}
