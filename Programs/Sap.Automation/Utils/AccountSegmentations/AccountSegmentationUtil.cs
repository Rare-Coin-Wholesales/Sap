using System;
using Sap.Api.Http;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.AccountSegmentations;

namespace Sap.Automation
{
	public partial class AccountSegmentationUtil
	{
		private readonly AccountSegmentationService _accountSegmentationService = new AccountSegmentationService();

		public void GetAllAccountSegmentations()
		{
			Common.logger.Trace("Begin method GetAllAccountSegmentations().");
			var client = new SapClient(Common.BaseUrl);
			var _ = client.Login(Common.CompanyDb, Common.Username, Common.Password);
			var list = client.ListAccountSegmentations();
			_accountSegmentationService.TruncateTable();

			foreach (var v in list) {
				try {
					_accountSegmentationService.Insert(Common._mapper.ToSql(v));
				}

				catch (Exception ex) {
					#region Log
					if (ex.InnerException == null)
						Common.logger.Warn("{0}{2}Exception thrown running _accountSegmentationService.Insert(Common._mapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
					else
						throw;
					#endregion
				}
			}
		}
	}
}
