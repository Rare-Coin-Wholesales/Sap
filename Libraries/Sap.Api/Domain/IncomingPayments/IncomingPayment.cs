using System;
using System.Collections.Generic;
using Sap.Core;

namespace Sap.Api.Domain.IncomingPayments
{
	public partial class IncomingPayment : BaseEntity
	{
		#region Fields
		public int? DocEntry;
		public int? DocNum;
		public string DocType;
		public string HandWritten;
		public string Printed;
		public DateTime? DocDate;
		public string CardCode;
		public string CardName;
		public string Address;
		public string CashAccount;
		public string DocCurrency;
		public decimal? CashSum;
		public string CheckAccount;
		public string TransferAccount;
		public decimal? TransferSum;
		public DateTime? TransferDate;
		public string TransferReference;
		public string LocalCurrency;
		public decimal? DocRate;
		public string Reference1;
		public string Reference2;
		public string CounterReference;
		public string Remarks;
		public string JournalRemarks;
		public string SplitTransaction;
		public int? ContactPersonCode;
		public string ApplyVAT;
		public DateTime? TaxDate;
		public int? Series;
		public string BankCode;
		public string BankAccount;
		public decimal? DiscountPercent;
		public string ProjectCode;
		public string CurrencyIsLocal;
		public decimal? DeductionPercent;
		public decimal? DeductionSum;
		public decimal? CashSumFC;
		public decimal? CashSumSys;
		public string BoeAccount;
		public decimal? BillOfExchangeAmount;
		public string BillofExchangeStatus;
		public decimal? BillOfExchangeAmountFC;
		public decimal? BillOfExchangeAmountSC;
		public string BillOfExchangeAgent;
		public string WTCode;
		public decimal? WTAmount;
		public decimal? WTAmountFC;
		public decimal? WTAmountSC;
		public string WTAccount;
		public decimal? WTTaxableAmount;
		public string Proforma;
		public string PayToBankCode;
		public string PayToBankBranch;
		public string PayToBankAccountNo;
		public string PayToCode;
		public string PayToBankCountry;
		public string IsPayToBank;
		public string PaymentPriority;
		public string TaxGroup;
		public decimal? BankChargeAmount;
		public decimal? BankChargeAmountInFC;
		public decimal? BankChargeAmountInSC;
		public decimal? UnderOverpaymentdifference;
		public decimal? UnderOverpaymentdiffSC;
		public decimal? WtBaseSum;
		public decimal? WtBaseSumFC;
		public decimal? WtBaseSumSC;
		public DateTime? VatDate;
		public string TransactionCode;
		public string PaymentType;
		public decimal? TransferRealAmount;
		public string DocObjectCode;
		public string DocTypte;
		public DateTime? DueDate;
		public string LocationCode;
		public string Cancelled;
		public string ControlAccount;
		public decimal? UnderOverpaymentdiffFC;
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
		public BillOfExchange BillOfExchange;
		public IList<PaymentCheck> PaymentChecks;
		public IList<PaymentInvoice> PaymentInvoices;
		public IList<object> PaymentCreditCards;
		public IList<object> PaymentAccounts;
		public IList<object> PaymentDocumentReferencesCollection;
		public IList<object> WithholdingTaxCertificatesCollection;
		public IList<object> ElectronicProtocols;
		public IList<CashFlowAssignment> CashFlowAssignments;
		public IList<object> PaymentsApprovalRequests;
		public IList<object> WithholdingTaxDataWTXCollection;
		#endregion

		public IncomingPayment()
		{
			BillOfExchange = new BillOfExchange();
			CashFlowAssignments = new List<CashFlowAssignment>();
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