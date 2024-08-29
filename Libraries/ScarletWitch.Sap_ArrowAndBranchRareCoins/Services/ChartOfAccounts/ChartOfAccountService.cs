using System;
using ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.ChartOfAccounts
{
	/// <summary>
	/// ChartOfAccount service
	/// </summary>
	public partial class ChartOfAccountService : BaseService, IChartOfAccountService
	{
		/// <inheritdoc/>
		public virtual void Insert(ChartOfAccount x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			if (x.Code == null)
				throw new Exception("'Code' is required.");
			#endregion

			try {
				_dbContext.ChartOfAccounts.Add(x);
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
			base.TruncateTable("ChartOfAccount");
		}
	}
}