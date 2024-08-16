using System;
using Sap.Api.Http;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.Invoices;

namespace Sap.Automation
{
	public partial class InvoiceUtil
	{
		private readonly InvoiceService _invoiceService = new InvoiceService();

		public void GetAllInvoices()
		{
			Common.logger.Trace("Begin method GetAllInvoices().");
			var client = new SapClient(Common.BaseUrl);
			var _ = client.Login(Common.CompanyDb, Common.Username, Common.Password);
			var list = client.ListInvoices();

			if (list == null || list.Count == 0) {
				Common.logger.Warn("List is empty.");
				return;
			}
			else {
				_invoiceService.TruncateTable();

				foreach (var v in list) {
					try {
						_invoiceService.Insert(Common._mapper.ToSql(v));

						foreach (var line in v.DocumentLines) {
							try {
								_invoiceService.InsertDocumentLine(Common._mapper.ToSql(line));
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
