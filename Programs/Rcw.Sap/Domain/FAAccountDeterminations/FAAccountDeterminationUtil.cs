using System;
using System.Threading.Tasks;
using Sap.Api.Domain.FAAccountDeterminations;
using ScarletWitch.Sap_RareCoinWholesalers.Services.FAAccountDeterminations;

namespace Rcw.Sap
{
	public partial class FAAccountDeterminationUtil
	{
		private readonly FAAccountDeterminationService _fAAccountDeterminationService = new FAAccountDeterminationService();

		public async Task GetAllFAAccountDeterminations()
		{
			Program.nLog.Trace("Begin method GetAllFAAccountDeterminations().");
			var list = await Program._serviceLayer.Request(FAAccountDeterminationRequest.ACTION).GetAllAsync<FAAccountDetermination>();

			if (list == null || list.Count == 0) {
				Program.nLog.Warn("List is empty.");
				return;
			}
			else {
				_fAAccountDeterminationService.TruncateTable();

				foreach (var v in list) {
					try {
						_fAAccountDeterminationService.Insert(Program._mapper.ToSql(v));
					}

					catch (Exception ex) {
						#region Log
						if (ex.InnerException == null)
							Program.nLog.Warn("{0}{2}Exception thrown running _service.Insert(Program._mapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
						else
							throw;
						#endregion
					}
				}
			}
		}
	}
}
