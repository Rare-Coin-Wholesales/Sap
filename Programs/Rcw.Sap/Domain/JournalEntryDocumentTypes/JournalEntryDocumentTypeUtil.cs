using System;
using System.Threading.Tasks;
using Sap.Api.Domain.JournalEntryDocumentTypes;
using ScarletWitch.Sap_RareCoinWholesalers.Services.JournalEntryDocumentTypes;

namespace Rcw.Sap
{
	public partial class JournalEntryDocumentTypeUtil
	{
		private readonly JournalEntryDocumentTypeService _journalEntryDocumentTypeService = new JournalEntryDocumentTypeService();

		public async Task GetAllJournalEntryDocumentTypes()
		{
			Program.nLog.Trace("Begin method GetAllJournalEntryDocumentTypes().");
			var list = await Program._serviceLayer.Request(JournalEntryDocumentTypeRequest.ACTION).GetAllAsync<JournalEntryDocumentType>();

			if (list == null || list.Count == 0) {
				Program.nLog.Warn("List is empty.");
				return;
			}
			else {
				_journalEntryDocumentTypeService.TruncateTable();

				foreach (var v in list) {
					try {
						_journalEntryDocumentTypeService.Insert(Program._mapper.ToSql(v));
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
