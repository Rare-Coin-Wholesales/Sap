using System;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.Common
{
	public partial class PaymentDocumentReferencesCollection
	{
		public DateTime? IssueDate;
		public int? DocEntry;
		public int? LineNumber;
		public int? ReferencedDocEntry;
		public int? ReferencedDocNumber;
		public string ExternalReferencedDocNumber;
		public string ReferencedObjectType;
		public string Remark;
	}
}