using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.JournalEntryDocumentTypes;
using Sap.Automation;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.JournalEntryDocumentTypes;

namespace Sap.Aabw.Automation
{
	public partial class JournalEntryDocumentTypeUtil
	{
		private readonly JournalEntryDocumentTypeService _journalEntryDocumentTypeService = new JournalEntryDocumentTypeService();

		public async Task GetAllJournalEntryDocumentTypes(SLConnection serviceLayer)
		{
			Common.nLog.Trace("Begin method GetAllJournalEntryDocumentTypes().");
			var list = await serviceLayer.Request(JournalEntryDocumentTypeRequest.ACTION).GetAllAsync<JournalEntryDocumentType>();

			if (list == null || list.Count == 0) {
				Common.nLog.Warn("List is empty.");
				return;
			}
			else {
				_journalEntryDocumentTypeService.TruncateTable();

				foreach (var v in list) {
					try {
						_journalEntryDocumentTypeService.Insert(Common._aabwMapper.ToSql(v));
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
