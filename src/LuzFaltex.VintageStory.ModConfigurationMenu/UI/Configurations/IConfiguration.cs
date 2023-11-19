//
//  IConfiguration.cs
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

namespace LuzFaltex.VintageStory.ModConfigurationMenu.UI.Configurations
{
    /// <summary>
    /// Represents a basic configuration type.
    /// </summary>
    /// <typeparam name="TValue">The underlying type of the value.</typeparam>
    public interface IConfiguration<TValue>
    {
        /// <summary>
        /// Gets the name of the configuration option.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets an optional description of the configuration option.
        /// </summary>
        public string? Description { get; }

        /// <summary>
        /// Gets the underlying value of the configuration option.
        /// </summary>
        public TValue Value { get; }
    }
}
