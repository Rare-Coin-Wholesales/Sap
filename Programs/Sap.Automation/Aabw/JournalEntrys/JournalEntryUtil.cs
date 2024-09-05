using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.JournalEntries;
using Sap.Automation;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.JournalEntries;

namespace Sap.Aabw.Automation
{
	public partial class JournalEntryUtil
	{
		private readonly JournalEntryService _journalEntryService = new JournalEntryService();

		public async Task GetAllJournalEntrys(SLConnection serviceLayer)
		{
			Common.nLog.Trace("Begin method GetAllJournalEntrys().");
			var list = await serviceLayer.Request(JournalEntryRequest.ACTION).GetAllAsync<JournalEntry>();

			if (list == null || list.Count == 0) {
				Common.nLog.Warn("List is empty.");
				return;
			}
			else {
				_journalEntryService.TruncateTable();

				foreach (var v in list) {
					try {
						_journalEntryService.Insert(Common._aabwMapper.ToSql(v));

						foreach (var line in v.JournalEntryLines) {
							try {
								line.JdtNum = v.JdtNum;
								_journalEntryService.InsertJournalEntryLine(Common._aabwMapper.ToSql(line));
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
