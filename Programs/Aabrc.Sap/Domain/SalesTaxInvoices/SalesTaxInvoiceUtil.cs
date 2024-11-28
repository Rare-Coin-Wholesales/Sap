using System;
using System.Threading.Tasks;
using Sap.Api.Domain.SalesTaxInvoices;
using ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.SalesTaxInvoices;

namespace Aabrc.Sap
{
	public partial class SalesTaxInvoiceUtil
	{
		private readonly SalesTaxInvoiceService _salesTaxInvoiceService = new SalesTaxInvoiceService();

		public async Task GetAllSalesTaxInvoices()
		{
			Program.nLog.Trace("Begin method GetAllSalesTaxInvoices().");
			var list = await Program._serviceLayer.Request(SalesTaxInvoiceRequest.ACTION).GetAllAsync<SalesTaxInvoice>();

			if (list == null || list.Count == 0) {
				Program.nLog.Warn("List is empty.");
				return;
			}
			else {
				_salesTaxInvoiceService.TruncateTable();

				foreach (var v in list) {
					try {
						_salesTaxInvoiceService.Insert(Program._mapper.ToSql(v));
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
