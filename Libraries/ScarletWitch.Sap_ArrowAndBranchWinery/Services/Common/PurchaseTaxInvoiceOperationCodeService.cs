using System;
using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchWinery.Services.Common
{
	/// <summary>
	/// PurchaseTaxInvoiceOperationCode service
	/// </summary>
	public partial class PurchaseTaxInvoiceOperationCodeService : BaseService
	{
		/// <inheritdoc/>
		public virtual void Insert(PurchaseTaxInvoiceOperationCode x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			#endregion

			try {
				_dbContext.PurchaseTaxInvoiceOperationCodes.Add(x);
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
			base.TruncateTable("PurchaseTaxInvoiceOperationCode");
		}
	}
}