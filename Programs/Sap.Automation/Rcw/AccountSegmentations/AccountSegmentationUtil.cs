using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.AccountSegmentations;
using Sap.Automation;
using ScarletWitch.Sap_RareCoinWholesalers.Services.AccountSegmentations;

namespace Sap.Rcw.Automation
{
	public partial class AccountSegmentationUtil
	{
		private readonly AccountSegmentationService _accountSegmentationService = new AccountSegmentationService();

		public async Task GetAllAccountSegmentations(SLConnection serviceLayer)
		{
			Common.nLog.Trace("Begin method GetAllAccountSegmentations().");
			var list = await serviceLayer.Request(AccountSegmentationRequest.ACTION).GetAllAsync<AccountSegmentation>();
			_accountSegmentationService.TruncateTable();

			foreach (var v in list) {
				try {
					_accountSegmentationService.Insert(Common._rcwMapper.ToSql(v));
				}

				catch (Exception ex) {
					#region Log
					if (ex.InnerException == null)
						Common.nLog.Warn("{0}{2}Exception thrown running _accountSegmentationService.Insert(Common._rcwMapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
					else
						throw;
					#endregion
				}
			}
		}
	}
}
