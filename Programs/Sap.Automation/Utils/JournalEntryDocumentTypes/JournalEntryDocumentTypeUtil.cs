using System;
using Sap.Api.Http;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.JournalEntryDocumentTypes;

namespace Sap.Automation
{
	public partial class JournalEntryDocumentTypeUtil
	{
		private readonly JournalEntryDocumentTypeService _journalEntryDocumentTypeService = new JournalEntryDocumentTypeService();

		public void GetAllJournalEntryDocumentTypes()
		{
			Common.logger.Trace("Begin method GetAllJournalEntryDocumentTypes().");
			var client = new SapClient(Common.BaseUrl);
			var _ = client.Login(Common.CompanyDb, Common.Username, Common.Password);
			var list = client.ListJournalEntryDocumentTypes();

			if (list == null || list.Count == 0) {
				Common.logger.Warn("List is empty.");
				return;
			}
			else {
				_journalEntryDocumentTypeService.TruncateTable();

				foreach (var v in list) {
					try {
						_journalEntryDocumentTypeService.Insert(Common._mapper.ToSql(v));
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
