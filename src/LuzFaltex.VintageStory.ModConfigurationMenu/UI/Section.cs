//
//  Section.cs
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

using System.Collections.Generic;
using LuzFaltex.VintageStory.ModConfigurationMenu.UI.Configurations;

namespace LuzFaltex.VintageStory.ModConfigurationMenu.UI
{
    /// <summary>
    /// Represents a configuration section on a mod page.
    /// </summary>
    public sealed record class Section
    {
        /// <summary>
        /// Gets the name of this section.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// Gets the description of this section.
        /// </summary>
        public string? Description { get; internal set; }

        /// <summary>
        /// Gets a collection of configuration options in this section.
        /// </summary>
        public IReadOnlyList<IConfiguration> Configurations => _configurations.AsReadOnly();

        private readonly List<IConfiguration> _configurations = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="Section"/> class.
        /// </summary>
        /// <param name="name">The name of the section.</param>
        /// <param name="description">The description of the section.</param>
        public Section(string name, string? description)
        {
            Name = name;
            Description = description;
        }

        /// <summary>
        /// Adds a configuration item to this section.
        /// </summary>
        /// <typeparam name="TResult">The return type of the configuration item.</typeparam>
        /// <param name="buildConfiguration">An operation to create and build the configuration item.</param>
        /// <returns>The current section, for chaining.</returns>
        public Section AddConfiguration<TResult>(System.Func<IConfiguration<TResult>> buildConfiguration)
        {
            var config = buildConfiguration();
            _configurations.Add(config);
            return this;
        }

        /// <summary>
        /// Sets the name of this section.
        /// </summary>
        /// <param name="name">The section name.</param>
        /// <returns>The current <see cref="Section"/> for chaining.</returns>
        public Section WithName(string name)
        {
            Name = name;
            return this;
        }

        /// <summary>
        /// Sets the description of this section.
        /// </summary>
        /// <param name="description">The description.</param>
        /// <returns>The current <see cref="Section"/> for chaining.</returns>
        public Section WithDescription(string description)
        {
            Description = description;
            return this;
        }
    }
}
