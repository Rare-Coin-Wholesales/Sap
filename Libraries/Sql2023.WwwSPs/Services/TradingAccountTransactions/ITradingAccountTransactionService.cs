using System.Collections.Generic;
using Sql2023.WwwSPs.Domain;

namespace Sql2023.WwwSPs.Services.TradingAccountTransactions
{
	/// <summary>
	/// TradingAccountTransaction interface
	/// </summary>
	public partial interface ITradingAccountTransactionService
	{
		/// <summary>
		/// Gets all AP <see cref="TradingAccountTransaction"/>s.
		/// </summary>
		IList<TradingAccountTransaction> GetAPs();
		/// <summary>
		/// Gets all AR <see cref="TradingAccountTransaction"/>s.
		/// </summary>
		IList<TradingAccountTransaction> GetARs();
		/// <summary>
		/// Inserts a <see cref="TradingAccountTransaction"/>.
		/// </summary>
		/// <param name="ent">The <see cref="TradingAccountTransaction"/> to insert.</param>
		void Insert(TradingAccountTransaction ent);
	}
}