using Sap.Core;

namespace Sap.Api.Domain.HouseBankAccounts
{
	public partial class HouseBankAccount : BaseEntity
	{
		#region Fields
		public int? AbsoluteEntry;
		public int? BankKey;
		public int? IncomingPaymentSeries;
		public int? ISRType;
		public int? JournalEntrySeries;
		public int? OutgoingPaymentSeries;
		public decimal? DiscountLimit;
		public decimal? MaxAmountofBillofExchan;
		public decimal? MinAmountofBillofExchang;
		public string AccNo;
		public string AccountCheckDigit;
		public string AccountName;
		public string AddressType;
		public string AgreementNumber;
		public string BankCode;
		public string BankonCollection;
		public string BankonDiscounted;
		public string BICSwiftCode;
		public string BISR;
		public string Block;
		public string Branch;
		public string BranchCheckDigit;
		public string Building;
		public string City;
		public string CollectionCode;
		public string ControlKey;
		public string Country;
		public string County;
		public string CustomerIdNumber;
		public string DaysInAdvance;
		public string DebtofDiscountedBillofExc;
		public string DiscountAccount;
		public string DSC1STREETALIAS;
		public string ECheck;
		public string FileSeqNextNumber;
		public string FineAccount;
		public string GLAccount;
		public string GLInterimAccount;
		public string IBAN;
		public string ImportFileName;
		public string InterestAccount;
		public string IOFTaxAccount;
		public string ISRBillerID;
		public string LockChecksPrinting;
		public string MaximumLines;
		public string NextCheckNo;
		public string NoValidationForStartingEndingBal;
		public string OtherExpensesAccount;
		public string OtherIncomesAccount;
		public string OurNumber;
		public string PrintOn;
		public string RetornoFileName;
		public string ServiceFeeAccount;
		public string State;
		public string StreetNo;
		public string TemplateName;
		public string ToleranceDays;
		public string UserNo1;
		public string UserNo2;
		public string UserNo3;
		public string UserNo4;
		public string ZipCode;
		#endregion
	}
}