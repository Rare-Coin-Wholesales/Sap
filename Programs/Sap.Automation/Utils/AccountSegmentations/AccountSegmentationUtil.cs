using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.AccountSegmentations;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.AccountSegmentations;

namespace Sap.Automation
{
	public partial class AccountSegmentationUtil
	{
		private readonly AccountSegmentationService _accountSegmentationService = new AccountSegmentationService();

		public async Task GetAllAccountSegmentations(SLConnection serviceLayer)
		{
			Common.logger.Trace("Begin method GetAllAccountSegmentations().");
			var list = await serviceLayer.Request(AccountSegmentationRequest.ACTION).GetAllAsync<AccountSegmentation>();
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
