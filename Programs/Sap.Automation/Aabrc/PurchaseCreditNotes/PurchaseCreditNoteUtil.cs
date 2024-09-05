using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.PurchaseCreditNotes;
using Sap.Automation;
using ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.PurchaseCreditNotes;

namespace Sap.Aabrc.Automation
{
	public partial class PurchaseCreditNoteUtil
	{
		private readonly PurchaseCreditNoteService _purchaseCreditNoteService = new PurchaseCreditNoteService();

		public async Task GetAllPurchaseCreditNotes(SLConnection serviceLayer)
		{
			Common.nLog.Trace("Begin method GetAllPurchaseCreditNotes().");
			var list = await serviceLayer.Request(PurchaseCreditNoteRequest.ACTION).GetAllAsync<PurchaseCreditNote>();

			if (list == null || list.Count == 0) {
				Common.nLog.Warn("List is empty.");
				return;
			}
			else {
				_purchaseCreditNoteService.TruncateTable();

				foreach (var v in list) {
					try {
						_purchaseCreditNoteService.Insert(Common._aabrcMapper.ToSql(v));
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
