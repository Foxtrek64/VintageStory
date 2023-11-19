//
//  IEconomyProvider.cs
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
using System.Numerics;
using LuzFaltex.VintageStory.CoreLib.Models;
using Remora.Results;
using Vintagestory.API.Common;

namespace LuzFaltex.VintageStory.CoreLib.Providers
{
    /// <summary>
    /// Describes a base economy service provider.
    /// </summary>
    public interface IEconomyProvider
    {
        /// <summary>
        /// Gets the name of the registered economy plugin.
        /// </summary>
        /// <remarks>
        /// Used primarily for logging purposes.
        /// </remarks>
        public string Name { get; }

        /// <summary>
        /// Gets the default currency name for <see cref="System.Globalization.CultureInfo.InvariantCulture"/>.
        /// </summary>
        public NamingScheme InvariantCurrencyName { get; }

        /// <summary>
        /// Gets a set of currency names.
        /// </summary>
        /// <remarks>
        /// The key is the name of the language, such as "en-US". Use <see cref="System.Globalization.CultureInfo.Name"/>.
        /// The value is a <see cref="NamingScheme"/> with values for the provided language.
        /// </remarks>
        public IReadOnlyDictionary<string, NamingScheme> CurrencyName { get; }

        /// <summary>
        /// Credits (deposits to) the account with the specified account key with the specified amount of money.
        /// </summary>
        /// <typeparam name="TAmount">The kind of the numeric amount. Designed to give flexibility for systems that use or don't use fractional values. For fractional values with cents, use <see cref="decimal"/>.</typeparam>
        /// <param name="owner">player that owns the account.</param>
        /// <param name="amount">The amount to credit the account. Accepts negative numbers to allow debiting operations.</param>
        /// <returns>A result indicating success or failure of the action.</returns>
        public Result CreditPlayerAccount<TAmount>(IPlayer owner, TAmount amount)
            where TAmount : ISignedNumber<TAmount>;

        /// <summary>
        /// Debits (withdraws from) the account with the specified account key with the specified amount of money.
        /// </summary>
        /// <typeparam name="TAmount">The kind of the numeric amount. Designed to give flexibility for systems that use or don't use fractional values. For fractional values with cents, use <see cref="decimal"/>.</typeparam>
        /// <param name="owner">player that owns the account.</param>
        /// <param name="amount">The amount to credit the account. Accepts negative numbers to allow debiting operations.</param>
        /// <returns>A result indicating success or failure of the action.</returns>
        public Result DebitPlayerAccount<TAmount>(IPlayer owner, TAmount amount)
            where TAmount : ISignedNumber<TAmount>;

        /// <summary>
        /// Gets the current account balance for the specified player.
        /// </summary>
        /// <typeparam name="TAmount">The kind of the numeric amount. Designed to give flexibility for systems that use or don't use fractional values. For fractional values with cents, use <see cref="decimal"/>.</typeparam>
        /// <param name="owner">player that owns the account.</param>
        /// <returns>A result containing the current account balance or an error.</returns>
        public Result<TAmount> GetPlayerAccountBalance<TAmount>(IPlayer owner)
            where TAmount : ISignedNumber<TAmount>;

        // TODO: Add methods for accounts not tied to specific players.
    }
}
