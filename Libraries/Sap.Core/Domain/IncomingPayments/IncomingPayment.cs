using Sap.Core.Domain.Common;

namespace Sap.Core.Domain.IncomingPayments
{
	public partial class IncomingPayment : BaseEntity
	{
		#region Fields
		public BillOfExchange BillOfExchange;
		public DateTime? DocDate;
		public DateTime? DueDate;
		public DateTime? TaxDate;
		public DateTime? TransferDate;
		public DateTime? VatDate;
		public double? BankChargeAmount;
		public double? BankChargeAmountInFC;
		public double? BankChargeAmountInSC;
		public double? BillOfExchangeAmount;
		public double? BillOfExchangeAmountFC;
		public double? BillOfExchangeAmountSC;
		public double? CashSum;
		public double? CashSumFC;
		public double? CashSumSys;
		public double? DeductionPercent;
		public double? DeductionSum;
		public double? DiscountPercent;
		public double? DocRate;
		public double? TransferRealAmount;
		public double? TransferSum;
		public double? UnderOverpaymentdifference;
		public double? UnderOverpaymentdiffFC;
		public double? UnderOverpaymentdiffSC;
		public double? WTAmount;
		public double? WTAmountFC;
		public double? WTAmountSC;
		public double? WtBaseSum;
		public double? WtBaseSumFC;
		public double? WtBaseSumSC;
		public double? WTTaxableAmount;
		public IList<CashFlowAssignment> CashFlowAssignments;
		public IList<object> ElectronicProtocols;
		public IList<object> PaymentAccounts;
		public IList<object> PaymentChecks;
		public IList<object> PaymentCreditCards;
		public IList<object> PaymentsApprovalRequests;
		public IList<object> WithholdingTaxCertificatesCollection;
		public IList<object> WithholdingTaxDataWTXCollection;
		public IList<PaymentDocumentReferencesCollection> PaymentDocumentReferencesCollection;
		public IList<PaymentInvoice> PaymentInvoices;
		public int? DocEntry;
		public int? DocNum;
		public int? Series;
		public string? Address;
		public string? ApplyVAT;
		public string? AttachmentEntry;
		public string? AuthorizationStatus;
		public string? BankAccount;
		public string? BankCode;
		public string? BillOfExchangeAgent;
		public string? BillofExchangeStatus;
		public string? BlanketAgreement;
		public string? BoeAccount;
		public string? BPLID;
		public string? BPLName;
		public string? Cancelled;
		public string? CardCode;
		public string? CardName;
		public string? CashAccount;
		public string? CertificationNumber;
		public string? CheckAccount;
		public string? Cig;
		public string? ContactPersonCode;
		public string? ControlAccount;
		public string? CounterReference;
		public string? Cup;
		public string? CurrencyIsLocal;
		public string? DocCurrency;
		public string? DocObjectCode;
		public string? DocType;
		public string? DocTypte;
		public string? EDocExportFormat;
		public string? ElecCommMessage;
		public string? ElecCommStatus;
		public string? HandWritten;
		public string? IsPayToBank;
		public string? JournalRemarks;
		public string? LocalCurrency;
		public string? LocationCode;
		public string? PaymentByWTCertif;
		public string? PaymentPriority;
		public string? PaymentType;
		public string? PayToBankAccountNo;
		public string? PayToBankBranch;
		public string? PayToBankCode;
		public string? PayToBankCountry;
		public string? PayToCode;
		public string? Printed;
		public string? PrivateKeyVersion;
		public string? Proforma;
		public string? ProjectCode;
		public string? Reference1;
		public string? Reference2;
		public string? Remarks;
		public string? SignatureDigest;
		public string? SignatureInputMessage;
		public string? SplitTransaction;
		public string? SplitVendorCreditRow;
		public string? TaxGroup;
		public string? TransactionCode;
		public string? TransferAccount;
		public string? TransferReference;
		public string? VATRegNum;
		public string? WTAccount;
		public string? WTCode;
		#endregion

		public IncomingPayment()
		{
			BillOfExchange = new BillOfExchange();
			CashFlowAssignments = new List<CashFlowAssignment>();
			ElectronicProtocols = new List<object>();
			PaymentAccounts = new List<object>();
			PaymentChecks = new List<object>();
			PaymentCreditCards = new List<object>();
			PaymentsApprovalRequests = new List<object>();
			WithholdingTaxCertificatesCollection = new List<object>();
			WithholdingTaxDataWTXCollection = new List<object>();
			PaymentDocumentReferencesCollection = new List<PaymentDocumentReferencesCollection>();
			PaymentInvoices = new List<PaymentInvoice>();
		}
	}

	#region Helper Classes
	public class BillOfExchange
	{
	}

	public class PaymentDocumentReferencesCollection
	{
		public int? DocEntry;
		public int? LineNumber;
		public int? ReferencedDocEntry;
		public int? ReferencedDocNumber;
		public string? ExternalReferencedDocNumber;
		public string? ReferencedObjectType;
		public DateTime? IssueDate;
		public string? Remark;
	}
	public class PaymentInvoice
	{
		#region Fields
		public int? LineNum;
		public int? DocEntry;
		public int? DocNum;
		public double? SumApplied;
		public double? AppliedFC;
		public double? AppliedSys;
		public double? DocRate;
		public int? DocLine;
		public string? InvoiceType;
		public double? DiscountPercent;
		public double? PaidSum;
		public int? InstallmentId;
		public double? WitholdingTaxApplied;
		public double? WitholdingTaxAppliedFC;
		public double? WitholdingTaxAppliedSC;
		public string? LinkDate;
		public string? DistributionRule;
		public string? DistributionRule2;
		public string? DistributionRule3;
		public string? DistributionRule4;
		public string? DistributionRule5;
		public double? TotalDiscount;
		public double? TotalDiscountFC;
		public double? TotalDiscountSC;
		#endregion
	}
	#endregion
}