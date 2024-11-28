using System;
using System.Threading.Tasks;
using Sap.Api.Domain.PurchaseTaxInvoices;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.PurchaseTaxInvoices;

namespace Aabw.Sap
{
	public partial class PurchaseTaxInvoiceUtil
	{
		private readonly PurchaseTaxInvoiceService _purchaseTaxInvoiceService = new PurchaseTaxInvoiceService();

		public async Task GetAllPurchaseTaxInvoices()
		{
			Program.nLog.Trace("Begin method GetAllPurchaseTaxInvoices().");
			var list = await Program._serviceLayer.Request(PurchaseTaxInvoiceRequest.ACTION).GetAllAsync<PurchaseTaxInvoice>();

			if (list == null || list.Count == 0) {
				Program.nLog.Warn("List is empty.");
				return;
			}
			else {
				_purchaseTaxInvoiceService.TruncateTable();

				foreach (var v in list) {
					try {
						_purchaseTaxInvoiceService.Insert(Program._mapper.ToSql(v));
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
