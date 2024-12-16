using Sap.Core;

namespace Sap.Api.Domain.IncomingPayments
{
	public partial class PaymentInvoice : BaseEntity
	{
		#region Fields
		public int? DocEntry;
		public int? LineNum;
		public int? DocNum;
		public decimal? SumApplied;
		public decimal? AppliedFC;
		public decimal? AppliedSys;
		public decimal? DocRate;
		public int? DocLine;
		public string InvoiceType;
		public decimal? DiscountPercent;
		public decimal? PaidSum;
		public int? InstallmentId;
		public decimal? WitholdingTaxApplied;
		public decimal? WitholdingTaxAppliedFC;
		public decimal? WitholdingTaxAppliedSC;
		public string LinkDate;
		public string DistributionRule;
		public string DistributionRule2;
		public string DistributionRule3;
		public string DistributionRule4;
		public string DistributionRule5;
		public decimal? TotalDiscount;
		public decimal? TotalDiscountFC;
		public decimal? TotalDiscountSC;
		#endregion
	}
}