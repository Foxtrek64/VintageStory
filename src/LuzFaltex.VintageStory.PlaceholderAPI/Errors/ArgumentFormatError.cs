//
//  ArgumentFormatError.cs
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
using JetBrains.Annotations;
using Remora.Results;

namespace LuzFaltex.VintageStory.PlaceholderAPI.Errors
{
    /// <summary>
    /// An error which arises from an invalid format.
    /// </summary>
    /// <remarks>
    /// Use in place of <see cref="FormatException"/>.
    /// </remarks>
    /// <param name="Name">The name of the argument.</param>
    /// <param name="Message">The error message.</param>
    public sealed record class ArgumentFormatError([InvokerParameterName] string Name, string Message) : ArgumentError(Name, Message);
}
