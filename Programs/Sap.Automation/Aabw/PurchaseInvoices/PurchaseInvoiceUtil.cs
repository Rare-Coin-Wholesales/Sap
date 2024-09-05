using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Automation;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.PurchaseInvoices;

namespace Sap.Aabw.Automation
{
	public partial class PurchaseInvoiceUtil
	{
		private readonly PurchaseInvoiceService _purchaseInvoiceService = new PurchaseInvoiceService();

		public async Task GetAllPurchaseInvoices(SLConnection serviceLayer)
		{
			Common.nLog.Trace("Begin method GetAllPurchaseInvoices().");
			var list = await new Api.Services.PurchaseInvoiceService(serviceLayer).GetAll();

			if (list == null || list.Count == 0) {
				Common.nLog.Warn("List is empty.");
				return;
			}
			else {
				_purchaseInvoiceService.TruncateTable();

				foreach (var v in list) {
					try {
						_purchaseInvoiceService.Insert(Common._aabwMapper.ToSql(v));

						foreach (var line in v.DocumentLines) {
							try {
								_purchaseInvoiceService.Insert(Common._aabwMapper.ToSql(line));
							}

							catch (Exception ex) {
								#region Log
								if (ex.InnerException == null)
									Common.nLog.Warn("{0}{2}Exception thrown running _service.Insert(Common._aabwMapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
								else
									throw;
								#endregion
							}
						}
					}

					catch (Exception ex) {
						#region Log
						if (ex.InnerException == null)
							Common.nLog.Warn("{0}{2}Exception thrown running _service.Insert(Common._aabwMapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
						else
							throw;
						#endregion
					}
				}
			}
		}
	}
}
