using System;
using System.Collections.Generic;
using System.Linq;
using Sql2023.WwwSPs.Domain;

namespace Sql2023.WwwSPs.Services.TradingAccountTransactions
{
	/// <summary>
	/// TradingAccountTransaction service
	/// </summary>
	public partial class TradingAccountTransactionService : BaseService, ITradingAccountTransactionService
	{
		public const string AP = "AP";
		public const string AR = "AR";

		/// <inheritdoc/>
		public virtual IList<TradingAccountTransaction> GetAPs()
		{
			return (from x in _dbContext.TradingAccountTransactions
					where x.TransactionType == AP
					select x).ToList();
		}

		/// <inheritdoc/>
		public virtual IList<TradingAccountTransaction> GetARs()
		{
			return (from x in _dbContext.TradingAccountTransactions
					where x.TransactionType == AR
					select x).ToList();
		}

		/// <inheritdoc/>
		public virtual void Insert(TradingAccountTransaction ent)
		{
			if (ent == null)
				throw new ArgumentNullException("ent", "Something happened with your connection. Refresh the page and try again.");

			try {
				_dbContext.TradingAccountTransactions.Add(ent);
				_dbContext.SaveChanges();
			}

			catch (Exception ex) {
				throw new Exception(GetFullErrorText(ex, "TradingAccountTransactionService.Update()"));
			}
		}

		/// <inheritdoc/>
		public virtual void Update()
		{
			try {
				_dbContext.Database.ExecuteSqlCommand("[dbo].[TradingAccountTransactionUpdate]");
			}

			catch (Exception ex) {
				throw new Exception(GetFullErrorText(ex, "TradingAccountTransactionService.Update()"));
			}
		}
	}
}