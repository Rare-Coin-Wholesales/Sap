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
		/// Gets all TA Document IDs.
		/// </summary>
		/// <returns>A list of TA Document IDs.</returns>
		IList<string> GetAllTaDocumentIds();
		/// <summary>
		/// Inserts a <see cref="TradingAccountTransaction"/>.
		/// </summary>
		/// <param name="ent">The <see cref="TradingAccountTransaction"/> to insert.</param>
		void Insert(TradingAccountTransaction ent);
	}
}