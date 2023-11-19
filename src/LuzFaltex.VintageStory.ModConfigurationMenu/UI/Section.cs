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

namespace LuzFaltex.VintageStory.ModConfigurationMenu.UI
{
    /// <summary>
    /// Represents a configuration section on a mod page.
    /// </summary>
    public sealed record class Section(string Name, string Description)
    {
        public IReadOnlyList<IConfiguration> Configurations => _configurations.AsReadOnly();

        private List<IConfiguration> _configurations = new();

        public Section AddConfiguration<TConfiguration>(TConfiguration configuration)
            where TConfiguration : IConfiguration
        {
            _configurations.Add(configuration);
        }
    }
}
