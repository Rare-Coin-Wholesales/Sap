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
		public virtual bool TryInsert(TradingAccountTransaction ent, out string errorMsg)
		{
			if (ent == null) {
				errorMsg = "Something happened with your connection. Refresh the page and try again.";
				return false;
			}

			errorMsg = string.Empty;

			try {
				_dbContext.TradingAccountTransactions.Add(ent);
				_dbContext.SaveChanges();
				return true;
			}

			catch (Exception ex) {
				errorMsg = GetFullErrorText(ex, "TryInsert(TradingAccountTransaction ent, out string errorMsg)");
				return false;
			}
		}

		/// <inheritdoc/>
		public virtual void Update()
		{
			try {
				_dbContext.Database.CommandTimeout = 337;
				_dbContext.Database.ExecuteSqlCommand("[dbo].[TradingAccountTransactionUpdate]");
				_dbContext.Database.CommandTimeout = null;
			}

			catch (Exception ex) {
				throw new Exception(GetFullErrorText(ex, "TradingAccountTransactionService.Update()"));
			}
		}
	}
}