using System;
using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchWinery.Services.ChecksforPayments
{
	/// <summary>
	/// ChecksforPayment service
	/// </summary>
	public partial class ChecksforPaymentService : BaseService, IChecksforPaymentService
	{
		/// <inheritdoc/>
		public virtual void Insert(ChecksforPayment x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			if (x.CheckKey == null)
				throw new Exception("'CheckKey' is required.");
			#endregion

			try {
				_dbContext.ChecksforPayments.Add(x);
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
		public virtual void Insert(ChecksforPaymentLine x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			if (x.CheckKey == null)
				throw new Exception("'CheckKey' is required.");
			#endregion

			try {
				_dbContext.ChecksforPaymentLines.Add(x);
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
			base.TruncateTable("ChecksforPayment");
			base.TruncateTable("ChecksforPaymentLine");
		}
	}
}