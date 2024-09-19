using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace Sap.ApiToScarRcwMapper
{
	public partial class Mapper
	{
		public virtual JournalEntryDocumentType ToSql(Api.Domain.JournalEntryDocumentTypes.JournalEntryDocumentType x)
		{
			return new JournalEntryDocumentType {
				JournalEntryType = x.JournalEntryType,
				DocTypeDescription = x.DocTypeDescription,
				ShortName = x.ShortName,
			};
		}
	}
}