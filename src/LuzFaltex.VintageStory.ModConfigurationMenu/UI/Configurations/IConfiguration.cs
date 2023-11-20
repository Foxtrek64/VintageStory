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

#pragma warning disable SA1402

using System;
using Remora.Results;

namespace LuzFaltex.VintageStory.ModConfigurationMenu.UI.Configurations
{
    /// <summary>
    /// Represents a basic configuration type.
    /// </summary>
    /// <typeparam name="TValue">The underlying type of the value.</typeparam>
    public interface IConfiguration<TValue> : IConfiguration
    {
        /// <summary>
        /// Gets the underlying value of the configuration option.
        /// </summary>
        public TValue Value { get; }

        /// <summary>
        /// Sets the function which will handle updating the value.
        /// </summary>
        /// <param name="updateFunction">The function which will update the option in the mod configuration.</param>
        /// <returns>The current configuration, for chaining.</returns>
        public IConfiguration<TValue> HandleWith(Func<TValue, Result> updateFunction);
    }

    /// <summary>
    /// Represents a basic configuration type.
    /// </summary>
    public interface IConfiguration
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
        /// Gets the permission node required to edit this item.
        /// </summary>
        public string Permission { get; }
    }
}
