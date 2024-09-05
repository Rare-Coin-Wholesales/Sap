using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.CreditNotes;
using Sap.Automation;
using ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.CreditNotes;

namespace Sap.Aabrc.Automation
{
	public partial class CreditNoteUtil
	{
		private readonly CreditNoteService _creditNoteService = new CreditNoteService();

		public async Task GetAllCreditNotes(SLConnection serviceLayer)
		{
			Common.nLog.Trace("Begin method GetAllCreditNotes().");
			var list = await serviceLayer.Request(CreditNoteRequest.ACTION).GetAllAsync<CreditNote>();

			if (list == null || list.Count == 0) {
				Common.nLog.Warn("List is empty.");
				return;
			}
			else {
				_creditNoteService.TruncateTable();

				foreach (var v in list) {
					try {
						_creditNoteService.Insert(Common._aabrcMapper.ToSql(v));
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
