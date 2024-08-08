using System.Collections.Generic;
using Sap.Core;

namespace Sap.Api.Domain.VendorPayments
{
	public partial class VendorPayment : BaseEntity
	{
		#region Fields
		public string DocNum;
		public string DocType;
		public string HandWritten;
		public string Printed;
		public string DocDate;
		public string CardCode;
		public string CardName;
		public string Address;
		public string CashAccount;
		public string DocCurrency;
		public string CashSum;
		public string CheckAccount;
		public string TransferAccount;
		public string TransferSum;
		public string TransferDate;
		public string TransferReference;
		public string LocalCurrency;
		public string DocRate;
		public string Reference1;
		public string Reference2;
		public string CounterReference;
		public string Remarks;
		public string JournalRemarks;
		public string SplitTransaction;
		public string ContactPersonCode;
		public string ApplyVAT;
		public string TaxDate;
		public string Series;
		public string BankCode;
		public string BankAccount;
		public string DiscountPercent;
		public string ProjectCode;
		public string CurrencyIsLocal;
		public string DeductionPercent;
		public string DeductionSum;
		public string CashSumFC;
		public string CashSumSys;
		public string BoeAccount;
		public string BillOfExchangeAmount;
		public string BillofExchangeStatus;
		public string BillOfExchangeAmountFC;
		public string BillOfExchangeAmountSC;
		public string BillOfExchangeAgent;
		public string WTCode;
		public string WTAmount;
		public string WTAmountFC;
		public string WTAmountSC;
		public string WTAccount;
		public string WTTaxableAmount;
		public string Proforma;
		public string PayToBankCode;
		public string PayToBankBranch;
		public string PayToBankAccountNo;
		public string PayToCode;
		public string PayToBankCountry;
		public string IsPayToBank;
		public string DocEntry;
		public string PaymentPriority;
		public string TaxGroup;
		public string BankChargeAmount;
		public string BankChargeAmountInFC;
		public string BankChargeAmountInSC;
		public string UnderOverpaymentdifference;
		public string UnderOverpaymentdiffSC;
		public string WtBaseSum;
		public string WtBaseSumFC;
		public string WtBaseSumSC;
		public string VatDate;
		public string TransactionCode;
		public string PaymentType;
		public string TransferRealAmount;
		public string DocObjectCode;
		public string DocTypte;
		public string DueDate;
		public string LocationCode;
		public string Cancelled;
		public string ControlAccount;
		public string UnderOverpaymentdiffFC;
		public string AuthorizationStatus;
		public string BPLID;
		public string BPLName;
		public string VATRegNum;
		public string BlanketAgreement;
		public string PaymentByWTCertif;
		public string Cig;
		public string Cup;
		public string AttachmentEntry;
		public string SignatureInputMessage;
		public string SignatureDigest;
		public string CertificationNumber;
		public string PrivateKeyVersion;
		public string EDocExportFormat;
		public string ElecCommStatus;
		public string ElecCommMessage;
		public string SplitVendorCreditRow;
		public IList<PaymentCheck> PaymentChecks;
		public IList<PaymentInvoice> PaymentInvoices;
		public IList<object> PaymentCreditCards;
		public IList<object> PaymentAccounts;
		public IList<object> PaymentDocumentReferencesCollection;
		public BillOfExchange BillOfExchange;
		public IList<object> WithholdingTaxCertificatesCollection;
		public IList<object> ElectronicProtocols;
		public IList<object> CashFlowAssignments;
		public IList<object> PaymentsApprovalRequests;
		public IList<object> WithholdingTaxDataWTXCollection;
		#endregion

		public VendorPayment()
		{
			BillOfExchange = new BillOfExchange();
			CashFlowAssignments = new List<object>();
			ElectronicProtocols = new List<object>();
			PaymentAccounts = new List<object>();
			PaymentChecks = new List<PaymentCheck>();
			PaymentCreditCards = new List<object>();
			PaymentDocumentReferencesCollection = new List<object>();
			PaymentInvoices = new List<PaymentInvoice>();
			PaymentsApprovalRequests = new List<object>();
			WithholdingTaxCertificatesCollection = new List<object>();
			WithholdingTaxDataWTXCollection = new List<object>();
		}
	}
}