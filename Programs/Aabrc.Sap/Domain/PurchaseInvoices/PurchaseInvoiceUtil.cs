using System;
using System.Threading.Tasks;
using ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.PurchaseInvoices;

namespace Aabrc.Sap
{
	public partial class PurchaseInvoiceUtil
	{
		private readonly PurchaseInvoiceService _purchaseInvoiceService = new PurchaseInvoiceService();

		public async Task GetAllPurchaseInvoices()
		{
			Program.nLog.Trace("Begin method GetAllPurchaseInvoices().");
			var list = await Program._serviceLayer.GetAllPurchaseInvoicesAsync();

			if (list == null || list.Count == 0) {
				Program.nLog.Warn("List is empty.");
				return;
			}
			else {
				_purchaseInvoiceService.TruncateTable();

				foreach (var v in list) {
					try {
						_purchaseInvoiceService.Insert(Program._mapper.ToSql(v));

						foreach (var line in v.DocumentLines) {
							try {
								_purchaseInvoiceService.Insert(Program._mapper.ToSql(line));
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
