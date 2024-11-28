using System;
using System.Threading.Tasks;
using Sap.Api.Domain.AccountSegmentations;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.AccountSegmentations;

namespace Aabw.Sap
{
	public partial class AccountSegmentationUtil
	{
		private readonly AccountSegmentationService _accountSegmentationService = new AccountSegmentationService();

		public async Task GetAllAccountSegmentations()
		{
			Program.nLog.Trace("Begin method GetAllAccountSegmentations().");
			var list = await Program._serviceLayer.Request(AccountSegmentationRequest.ACTION).GetAllAsync<AccountSegmentation>();
			_accountSegmentationService.TruncateTable();

			foreach (var v in list) {
				try {
					_accountSegmentationService.Insert(Program._mapper.ToSql(v));
				}

				catch (Exception ex) {
					#region Log
					if (ex.InnerException == null)
						Program.nLog.Warn("{0}{2}Exception thrown running _accountSegmentationService.Insert(Program._mapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
					else
						throw;
					#endregion
				}
			}
		}
	}
}
