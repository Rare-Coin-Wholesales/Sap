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
		public const string TA = "TA";

		/// <inheritdoc/>
		public virtual IList<string> GetAllTaDocumentIds()
		{
			return (from x in _dbContext.TradingAccountTransactions
					where x.TransactionType == TA
					select x.DocumentId).ToList();
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

			#region catch (Exception ex)
			catch (Exception ex) {
				if (ex.InnerException == null) {
					var log = string.Empty;
					log = $"{log}{ex.Message}{Environment.NewLine}{Environment.NewLine}";
					log = $"{log}Exception thrown in TradingAccountTransactionService.Insert(TradingAccountTransaction ent).{Environment.NewLine}{Environment.NewLine}";
					log = $"{log}{ex}{Environment.NewLine}{Environment.NewLine}";
					throw new Exception(log);
				}

				else throw;
			}
			#endregion
		}
	}
}