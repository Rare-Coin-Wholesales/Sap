using System;
using System.Data.Entity.Validation;
using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchWinery.Services.AccountCategories
{
	/// <summary>
	/// AccountCategory service
	/// </summary>
	public partial class AccountCategoryService : IAccountCategoryService
	{
		private readonly Sap_ArrowAndBranchWineryDb _dbContext;

		#region Constructor
		public AccountCategoryService()
		{
			_dbContext = new Sap_ArrowAndBranchWineryDb();
		}
		#endregion

		#region Methods
		/// <inheritdoc/>
		public virtual void Insert(AccountCategory accountCategory)
		{
			#region Input check
			if (accountCategory == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			if (accountCategory.CategoryCode == null)
				throw new Exception("'CategoryCode' is required.");
			#endregion

			try {
				_dbContext.AccountCategories.Add(accountCategory);
				_dbContext.SaveChanges();
			}

			catch (DbEntityValidationException dbEx) {
				var msg = String.Empty;

				foreach (var validationErrors in dbEx.EntityValidationErrors)
					foreach (var er in validationErrors.ValidationErrors)
						msg = String.Format("{0}Property: {1} Error: {2}{3}", msg, er.PropertyName, er.ErrorMessage, Environment.NewLine);

				throw new Exception(msg, dbEx);
			}
		}
		#endregion
	}
}