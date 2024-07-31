using Sap.Core;

namespace Sap.Api.Domain.Common
{
	public partial class DownPaymentsToDrawDetail
	{
		public int? DocEntry;
		public int? DocInternalID;
		public int? RowNum;
		public int? SeqNum;
		public decimal? AmountToDraw;
		public decimal? AmountToDrawSC;
		public decimal? GrossAmountToDraw;
		public decimal? GrossAmountToDrawFC;
		public decimal? GrossAmountToDrawSC;
		public decimal? Tax;
		public decimal? TaxSC;
		public decimal? VatPercent;
		public string AmountToDrawFC;
		public string IsGrossLine;
		public string LineType;
		public string TaxAdjust;
		public string TaxFC;
		public string VatGroupCode;
	}
}
