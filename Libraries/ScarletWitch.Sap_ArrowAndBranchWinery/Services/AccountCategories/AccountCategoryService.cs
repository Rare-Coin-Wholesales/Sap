using System;
using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchWinery.Services.AccountCategories
{
	/// <summary>
	/// AccountCategory service
	/// </summary>
	public partial class AccountCategoryService : BaseService, IAccountCategoryService
	{
		/// <inheritdoc/>
		public virtual void Insert(AccountCategory x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			if (x.CategoryCode == null)
				throw new Exception("'CategoryCode' is required.");
			#endregion

			try {
				_dbContext.AccountCategories.Add(x);
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
			base.TruncateTable("AccountCategory");
		}
	}
}