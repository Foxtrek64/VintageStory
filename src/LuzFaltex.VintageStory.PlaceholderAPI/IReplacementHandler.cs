//
//  IReplacementHandler.cs
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

using System.Threading.Tasks;
using Remora.Results;

namespace LuzFaltex.VintageStory.PlaceholderAPI
{
    /// <summary>
    /// Describes a type that handles replacement.
    /// </summary>
    public interface IReplacementHandler
    {
        /// <summary>
        /// Gets a replacement value for the provided token.
        /// </summary>
        /// <param name="token">The token to find a replacement for.</param>
        /// <returns>A result containing the replacement string or an error describing why getting the replacement value failed.</returns>
        public ValueTask<Result<string>> GetReplacement(string token);
    }
}
