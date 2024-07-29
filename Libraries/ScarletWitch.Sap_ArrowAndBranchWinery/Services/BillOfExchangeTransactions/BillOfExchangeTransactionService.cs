using System;
using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchWinery.Services.BillOfExchangeTransactions
{
	/// <summary>
	/// BillOfExchangeTransaction service
	/// </summary>
	public partial class BillOfExchangeTransactionService : BaseService, IBillOfExchangeTransactionService
	{
		/// <inheritdoc/>
		public virtual void Insert(BillOfExchangeTransaction x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			if (x.BOETransactionkey == null)
				throw new Exception("'BOETransactionkey' is required.");
			#endregion

			try {
				_dbContext.BillOfExchangeTransactions.Add(x);
				_dbContext.SaveChanges();
			}

			catch (Exception ex) {
				#region Handle Exception
				var msg = GetFullErrorText(ex);

				if (String.IsNullOrWhiteSpace(msg))
					throw;
				else
					throw new Exception(msg);
				#endregion
			}
		}

		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("BillOfExchangeTransaction");
		}
	}
}