using System;
using ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.Common
{
	/// <summary>
	/// DocumentInstallment service
	/// </summary>
	public partial class DocumentInstallmentService : BaseService
	{
		/// <inheritdoc/>
		public virtual void Insert(DocumentInstallment x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			#endregion

			try {
				_dbContext.DocumentInstallments.Add(x);
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
			base.TruncateTable("DocumentInstallment");
		}
	}
}