using Sap.Core.Domain.Common;

namespace Sap.Core.Domain.IncomingPayments
{
	public partial class IncomingPayment : BaseEntity
	{
		#region Fields
		public int? DocEntry;
		public int? DocNum;
		public int? Series;
		public BillOfExchange BillOfExchange;
		public DateTime? DocDate;
		public DateTime? DueDate;
		public DateTime? TaxDate;
		public DateTime? TransferDate;
		public DateTime? VatDate;
		public decimal? BankChargeAmount;
		public decimal? BankChargeAmountInFC;
		public decimal? BankChargeAmountInSC;
		public decimal? BillOfExchangeAmount;
		public decimal? BillOfExchangeAmountFC;
		public decimal? BillOfExchangeAmountSC;
		public decimal? CashSum;
		public decimal? CashSumFC;
		public decimal? CashSumSys;
		public decimal? DeductionPercent;
		public decimal? DeductionSum;
		public decimal? DiscountPercent;
		public decimal? DocRate;
		public decimal? TransferRealAmount;
		public decimal? TransferSum;
		public decimal? UnderOverpaymentdifference;
		public decimal? UnderOverpaymentdiffFC;
		public decimal? UnderOverpaymentdiffSC;
		public decimal? WTAmount;
		public decimal? WTAmountFC;
		public decimal? WTAmountSC;
		public decimal? WtBaseSum;
		public decimal? WtBaseSumFC;
		public decimal? WtBaseSumSC;
		public decimal? WTTaxableAmount;
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
}