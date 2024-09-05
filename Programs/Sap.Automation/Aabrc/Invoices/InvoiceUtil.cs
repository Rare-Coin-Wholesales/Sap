using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Automation;
using ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.Invoices;

namespace Sap.Aabrc.Automation
{
	public partial class InvoiceUtil
	{
		private readonly InvoiceService _invoiceService = new InvoiceService();

		public async Task GetAllInvoices(SLConnection serviceLayer)
		{
			Common.nLog.Trace("Begin method GetAllInvoices().");
			var list = await new Api.Services.InvoiceService(serviceLayer).GetAll();

			if (list == null || list.Count == 0) {
				Common.nLog.Warn("List is empty.");
				return;
			}
			else {
				_invoiceService.TruncateTable();

				foreach (var v in list) {
					try {
						_invoiceService.Insert(Common._aabrcMapper.ToSql(v));

						foreach (var line in v.DocumentLines) {
							try {
								_invoiceService.InsertDocumentLine(Common._aabrcMapper.ToSql(line));
							}

							catch (Exception ex) {
								#region Log
								if (ex.InnerException == null)
									Common.nLog.Warn("{0}{2}Exception thrown running _service.Insert(Common._aabrcMapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
								else
									throw;
								#endregion
							}
						}
					}

					catch (Exception ex) {
						#region Log
						if (ex.InnerException == null)
							Common.nLog.Warn("{0}{2}Exception thrown running _service.Insert(Common._aabrcMapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
						else
							throw;
						#endregion
					}
				}
			}
		}
	}
}
