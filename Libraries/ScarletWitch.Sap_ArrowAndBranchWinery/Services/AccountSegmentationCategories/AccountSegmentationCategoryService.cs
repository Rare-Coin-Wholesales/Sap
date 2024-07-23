using System;
using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchWinery.Services.AccountSegmentationCategories
{
	/// <summary>
	/// AccountSegmentationCategory service
	/// </summary>
	public partial class AccountSegmentationCategoryService : BaseService, IAccountSegmentationCategoryService
	{
		/// <inheritdoc/>
		public virtual void Insert(AccountSegmentationCategory x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			if (x.SegmentID == null)
				throw new Exception("'SegmentID' is required.");
			if (String.IsNullOrWhiteSpace(x.Code))
				throw new Exception("'Code' is required.");
			#endregion

			try {
				_dbContext.AccountSegmentationCategories.Add(x);
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
			base.TruncateTable("AccountSegmentationCategory");
		}
	}
}