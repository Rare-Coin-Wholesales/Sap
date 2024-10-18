using System.Collections.Generic;
using Sql2023.WwwSPs.Domain;

namespace Sql2023.WwwSPs.Services.TradingAccounts
{
	/// <summary>
	/// TradingAccount interface
	/// </summary>
	public partial interface ITradingAccountService
	{
		/// <summary>
		/// Gets all <see cref="TradingAccount"/>s.
		/// </summary>
		/// <returns>An <see cref="IList{T}"/> of <see cref="TradingAccount"/>s.</returns>
		IList<TradingAccount> GetAll();
	}
}