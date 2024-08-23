using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.FAAccountDeterminations;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.FAAccountDeterminations;

namespace Sap.Automation
{
	public partial class FAAccountDeterminationUtil
	{
		private readonly FAAccountDeterminationService _fAAccountDeterminationService = new FAAccountDeterminationService();

		public async Task GetAllFAAccountDeterminations(SLConnection serviceLayer)
		{
			Common.logger.Trace("Begin method GetAllFAAccountDeterminations().");
			var list = await serviceLayer.Request(FAAccountDeterminationRequest.ACTION).GetAllAsync<FAAccountDetermination>();

			if (list == null || list.Count == 0) {
				Common.logger.Warn("List is empty.");
				return;
			}
			else {
				_fAAccountDeterminationService.TruncateTable();

				foreach (var v in list) {
					try {
						_fAAccountDeterminationService.Insert(Common._mapper.ToSql(v));
					}

					catch (Exception ex) {
						#region Log
						if (ex.InnerException == null)
							Common.logger.Warn("{0}{2}Exception thrown running _service.Insert(Common._mapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
						else
							throw;
						#endregion
					}
				}
			}
		}
	}
}
