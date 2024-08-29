using System;
using ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.Deposits
{
	/// <summary>
	/// Deposit service
	/// </summary>
	public partial class DepositService : BaseService, IDepositService
	{
		/// <inheritdoc/>
		public virtual void Insert(Deposit x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			if (x.AbsEntry == null)
				throw new Exception("'AbsEntry' is required.");
			#endregion

			try {
				_dbContext.Deposits.Add(x);
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
			base.TruncateTable("Deposit");
		}
	}
}