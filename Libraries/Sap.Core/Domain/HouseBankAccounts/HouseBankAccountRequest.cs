namespace Sap.Core.Domain.HouseBankAccounts
{
	public partial class HouseBankAccountRequest : BaseRequest
	{
		#region Fields
		public const string ACTION = "HouseBankAccounts";
		public double? DiscountLimit;
		public double? MaxAmountofBillofExchan;
		public double? MinAmountofBillofExchang;
		public int? AbsoluteEntry;
		public int? BankKey;
		public int? IncomingPaymentSeries;
		public int? ISRType;
		public int? JournalEntrySeries;
		public int? OutgoingPaymentSeries;
		public string? AccNo;
		public string? AccountCheckDigit;
		public string? AccountName;
		public string? AddressType;
		public string? AgreementNumber;
		public string? BankCode;
		public string? BankonCollection;
		public string? BankonDiscounted;
		public string? BICSwiftCode;
		public string? BISR;
		public string? Block;
		public string? Branch;
		public string? BranchCheckDigit;
		public string? Building;
		public string? City;
		public string? CollectionCode;
		public string? ControlKey;
		public string? Country;
		public string? County;
		public string? CustomerIdNumber;
		public string? DaysInAdvance;
		public string? DebtofDiscountedBillofExc;
		public string? DiscountAccount;
		public string? DSC1STREETALIAS;
		public string? ECheck;
		public string? FileSeqNextNumber;
		public string? FineAccount;
		public string? GLAccount;
		public string? GLInterimAccount;
		public string? IBAN;
		public string? ImportFileName;
		public string? InterestAccount;
		public string? IOFTaxAccount;
		public string? ISRBillerID;
		public string? LockChecksPrinting;
		public string? MaximumLines;
		public string? NextCheckNo;
		public string? NoValidationForStartingEndingBal;
		public string? OtherExpensesAccount;
		public string? OtherIncomesAccount;
		public string? OurNumber;
		public string? PrintOn;
		public string? RetornoFileName;
		public string? ServiceFeeAccount;
		public string? State;
		public string? StreetNo;
		public string? TemplateName;
		public string? ToleranceDays;
		public string? UserNo1;
		public string? UserNo2;
		public string? UserNo3;
		public string? UserNo4;
		public string? ZipCode;
		#endregion

		public HouseBankAccountRequest() { }

		public HouseBankAccountRequest(string bankCode)
		{
			BankCode = bankCode;
		}

		public HouseBankAccountRequest(HouseBankAccount x)
		{
			BankCode = x.BankCode;
			AccNo = x.AccNo;
			Branch = x.Branch;
			NextCheckNo = x.NextCheckNo;
			GLAccount = x.GLAccount;
			DSC1STREETALIAS = x.DSC1STREETALIAS;
			Block = x.Block;
			ZipCode = x.ZipCode;
			City = x.City;
			County = x.County;
			Country = x.Country;
			State = x.State;
			BISR = x.BISR;
			ControlKey = x.ControlKey;
			UserNo1 = x.UserNo1;
			UserNo2 = x.UserNo2;
			UserNo3 = x.UserNo3;
			UserNo4 = x.UserNo4;
			IBAN = x.IBAN;
			DebtofDiscountedBillofExc = x.DebtofDiscountedBillofExc;
			ToleranceDays = x.ToleranceDays;
			MinAmountofBillofExchang = x.MinAmountofBillofExchang;
			MaxAmountofBillofExchan = x.MaxAmountofBillofExchan;
			DiscountLimit = x.DiscountLimit;
			DaysInAdvance = x.DaysInAdvance;
			BankonCollection = x.BankonCollection;
			BankonDiscounted = x.BankonDiscounted;
			GLInterimAccount = x.GLInterimAccount;
			AbsoluteEntry = x.AbsoluteEntry;
			BankKey = x.BankKey;
			LockChecksPrinting = x.LockChecksPrinting;
			TemplateName = x.TemplateName;
			MaximumLines = x.MaximumLines;
			PrintOn = x.PrintOn;
			CustomerIdNumber = x.CustomerIdNumber;
			ISRBillerID = x.ISRBillerID;
			ISRType = x.ISRType;
			AccountCheckDigit = x.AccountCheckDigit;
			OurNumber = x.OurNumber;
			AgreementNumber = x.AgreementNumber;
			AddressType = x.AddressType;
			StreetNo = x.StreetNo;
			Building = x.Building;
			IncomingPaymentSeries = x.IncomingPaymentSeries;
			OutgoingPaymentSeries = x.OutgoingPaymentSeries;
			JournalEntrySeries = x.JournalEntrySeries;
			ImportFileName = x.ImportFileName;
			AccountName = x.AccountName;
			BICSwiftCode = x.BICSwiftCode;
			FineAccount = x.FineAccount;
			InterestAccount = x.InterestAccount;
			DiscountAccount = x.DiscountAccount;
			ServiceFeeAccount = x.ServiceFeeAccount;
			IOFTaxAccount = x.IOFTaxAccount;
			OtherExpensesAccount = x.OtherExpensesAccount;
			OtherIncomesAccount = x.OtherIncomesAccount;
			RetornoFileName = x.RetornoFileName;
			BranchCheckDigit = x.BranchCheckDigit;
			CollectionCode = x.CollectionCode;
			FileSeqNextNumber = x.FileSeqNextNumber;
			NoValidationForStartingEndingBal = x.NoValidationForStartingEndingBal;
			ECheck = x.ECheck;
		}
	}
}