using System;
using ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.GLAccountAdvancedRules
{
	/// <summary>
	/// GLAccountAdvancedRule service
	/// </summary>
	public partial class GLAccountAdvancedRuleService : BaseService, IGLAccountAdvancedRuleService
	{
		/// <inheritdoc/>
		public virtual void Insert(GLAccountAdvancedRule x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			if (x.AbsoluteEntry == null)
				throw new Exception("'AbsoluteEntry' is required.");
			#endregion

			try {
				_dbContext.GLAccountAdvancedRules.Add(x);
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
			base.TruncateTable("GLAccountAdvancedRule");
		}
	}
}