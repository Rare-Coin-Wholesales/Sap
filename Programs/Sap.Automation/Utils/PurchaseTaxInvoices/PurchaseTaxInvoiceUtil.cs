using System;
using Sap.Api.Http;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.PurchaseTaxInvoices;

namespace Sap.Automation
{
	public partial class PurchaseTaxInvoiceUtil
	{
		private readonly PurchaseTaxInvoiceService _purchaseTaxInvoiceService = new PurchaseTaxInvoiceService();

		public void GetAllPurchaseTaxInvoices()
		{
			Common.logger.Trace("Begin method GetAllPurchaseTaxInvoices().");
			var client = new SapClient(Common.BaseUrl);
			var _ = client.Login(Common.CompanyDb, Common.Username, Common.Password);
			var list = client.ListPurchaseTaxInvoices();

			if (list == null || list.Count == 0) {
				Common.logger.Warn("List is empty.");
				return;
			}
			else {
				_purchaseTaxInvoiceService.TruncateTable();

				foreach (var v in list) {
					try {
						_purchaseTaxInvoiceService.Insert(Common._mapper.ToSql(v));
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
