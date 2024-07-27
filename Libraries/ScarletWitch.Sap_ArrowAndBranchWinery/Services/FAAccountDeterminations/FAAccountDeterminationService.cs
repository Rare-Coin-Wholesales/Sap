using System;
using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchWinery.Services.FAAccountDeterminations
{
	/// <summary>
	/// FAAccountDetermination service
	/// </summary>
	public partial class FAAccountDeterminationService : BaseService, IFAAccountDeterminationService
	{
		/// <inheritdoc/>
		public virtual void Insert(FAAccountDetermination x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			if (x.Code == null)
				throw new Exception("'Code' is required.");
			#endregion

			try {
				_dbContext.FAAccountDeterminations.Add(x);
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
			base.TruncateTable("FAAccountDetermination");
		}
	}
}