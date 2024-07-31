using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ApiToScarletWitchMapper
{
	public partial class Mapper
	{
		public virtual JournalEntryDocumentType ToSql(Sap.Api.Domain.JournalEntryDocumentTypes.JournalEntryDocumentType x)
		{
			return new JournalEntryDocumentType {
				JournalEntryType = x.JournalEntryType,
				DocTypeDescription = x.DocTypeDescription,
				ShortName = x.ShortName,
			};
		}
	}
}