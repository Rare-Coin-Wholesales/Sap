using Newtonsoft.Json;
using Sap.Core;

namespace Sap.Api.Domain.CreditNotes
{
	public partial class LineTaxJurisdiction : BaseEntity
	{
		#region Fields
		[JsonProperty("JurisdictionCode")]
		public string JurisdictionCode;

		[JsonProperty("JurisdictionType")]
		public int? JurisdictionType;

		[JsonProperty("TaxAmount")]
		public decimal? TaxAmount;

		[JsonProperty("TaxAmountSC")]
		public decimal? TaxAmountSC;

		[JsonProperty("TaxAmountFC")]
		public decimal? TaxAmountFC;

		[JsonProperty("TaxRate")]
		public decimal? TaxRate;

		[JsonProperty("DocEntry")]
		public int? DocEntry;

		[JsonProperty("LineNumber")]
		public int? LineNumber;

		[JsonProperty("RowSequence")]
		public int? RowSequence;

		[JsonProperty("ExternalCalcTaxRate")]
		public decimal? ExternalCalcTaxRate;

		[JsonProperty("ExternalCalcTaxAmount")]
		public decimal? ExternalCalcTaxAmount;

		[JsonProperty("ExternalCalcTaxAmountFC")]
		public decimal? ExternalCalcTaxAmountFC;

		[JsonProperty("ExternalCalcTaxAmountSC")]
		public decimal? ExternalCalcTaxAmountSC;

		[JsonProperty("BaseSum")]
		public decimal? BaseSum;

		[JsonProperty("TaxInPrice")]
		public string TaxInPrice;

		[JsonProperty("NonDeductiblePercent")]
		public decimal? NonDeductiblePercent;

		[JsonProperty("TaxOnReserveInvoice")]
		public string TaxOnReserveInvoice;

		[JsonProperty("Exempt")]
		public string Exempt;

		[JsonProperty("Unencumbered")]
		public string Unencumbered;
		#endregion
	}
}