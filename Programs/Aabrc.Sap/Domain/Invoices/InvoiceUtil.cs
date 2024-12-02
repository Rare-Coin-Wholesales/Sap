using System;
using System.Threading.Tasks;
using ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.Invoices;

namespace Aabrc.Sap
{
	public partial class InvoiceUtil
	{
		private readonly InvoiceService _invoiceService = new InvoiceService();

		public async Task GetAllInvoices()
		{
			Program.nLog.Trace("Begin method GetAllInvoices().");
			var list = await Program._serviceLayer.GetAllInvoicesAsync();

			if (list == null || list.Count == 0) {
				Program.nLog.Warn("List is empty.");
				return;
			}
			else {
				_invoiceService.TruncateTable();

				foreach (var v in list) {
					try {
						_invoiceService.Insert(Program._mapper.ToSql(v));

						foreach (var line in v.DocumentLines) {
							try {
								_invoiceService.InsertDocumentLine(Program._mapper.ToSql(line));
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
