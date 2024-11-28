using System;
using System.Threading.Tasks;
using Sap.Api.Domain.PurchaseQuotations;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.PurchaseQuotations;

namespace Aabw.Sap
{
	public partial class PurchaseQuotationUtil
	{
		private readonly PurchaseQuotationService _purchaseQuotationService = new PurchaseQuotationService();

		public async Task GetAllPurchaseQuotations()
		{
			Program.nLog.Trace("Begin method GetAllPurchaseQuotations().");
			var list = await Program._serviceLayer.Request(PurchaseQuotationRequest.ACTION).GetAllAsync<PurchaseQuotation>();

			if (list == null || list.Count == 0) {
				Program.nLog.Warn("List is empty.");
				return;
			}
			else {
				_purchaseQuotationService.TruncateTable();

				foreach (var v in list) {
					try {
						_purchaseQuotationService.Insert(Program._mapper.ToSql(v));
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
