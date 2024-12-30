using System;
using System.Collections.Generic;

namespace Sap.Api.Domain.Deposits
{
	public partial class DepositRequest : BaseRequest
	{
		public const string ACTION = "Deposits";
		#region Fields
		public int? DepositNumber;
		public int? AbsEntry;
		public string DepositType;
		public DateTime? DepositDate;
		public string DepositCurrency;
		public string DepositAccount;
		public string DepositorName;
		public string Bank;
		public string BankAccountNum;
		public string BankBranch;
		public string BankReference;
		public string JournalRemarks;
		public decimal? TotalLC;
		public decimal? TotalFC;
		public decimal? TotalSC;
		public string AllocationAccount;
		public decimal? DocRate;
		public string TaxAccount;
		public decimal? TaxAmount;
		public string CommissionAccount;
		public decimal? Commission;
		public string CommissionDate;
		public string TaxCode;
		public string DepositAccountType;
		public string ReconcileAfterDeposit;
		public string VoucherAccount;
		public int? Series;
		public string Project;
		public string DistributionRule;
		public string DistributionRule2;
		public string DistributionRule3;
		public string DistributionRule4;
		public string DistributionRule5;
		public string CommissionCurrency;
		public decimal? CommissionSC;
		public decimal? CommissionFC;
		public decimal? TaxAmountSC;
		public decimal? TaxAmountFC;
		public string BPLID;
		public string CheckDepositType;
		public string AttachmentEntry;
		public string IncomeTaxAccount;
		public decimal? IncomeTaxAmount;
		public decimal? IncomeTaxAmountSC;
		public decimal? IncomeTaxAmountFC;
		public IList<CheckLine> CheckLines;
		public IList<object> CreditLines;
		public IList<object> BOELines;
		#endregion

		public DepositRequest()
		{
			CheckLines = new List<CheckLine>();
			CreditLines = new List<object>();
			BOELines = new List<object>();
		}

		public DepositRequest(int absEntry)
		{
			AbsEntry = absEntry;
			CheckLines = new List<CheckLine>();
			CreditLines = new List<object>();
			BOELines = new List<object>();
		}

		public DepositRequest(Deposit x)
		{
			DepositNumber = x.DepositNumber;
			AbsEntry = x.AbsEntry;
			DepositType = x.DepositType;
			DepositDate = x.DepositDate;
			DepositCurrency = x.DepositCurrency;
			DepositAccount = x.DepositAccount;
			DepositorName = x.DepositorName;
			Bank = x.Bank;
			BankAccountNum = x.BankAccountNum;
			BankBranch = x.BankBranch;
			BankReference = x.BankReference;
			JournalRemarks = x.JournalRemarks;
			TotalLC = x.TotalLC;
			TotalFC = x.TotalFC;
			TotalSC = x.TotalSC;
			AllocationAccount = x.AllocationAccount;
			DocRate = x.DocRate;
			TaxAccount = x.TaxAccount;
			TaxAmount = x.TaxAmount;
			CommissionAccount = x.CommissionAccount;
			Commission = x.Commission;
			CommissionDate = x.CommissionDate;
			TaxCode = x.TaxCode;
			DepositAccountType = x.DepositAccountType;
			ReconcileAfterDeposit = x.ReconcileAfterDeposit;
			VoucherAccount = x.VoucherAccount;
			Series = x.Series;
			Project = x.Project;
			DistributionRule = x.DistributionRule;
			DistributionRule2 = x.DistributionRule2;
			DistributionRule3 = x.DistributionRule3;
			DistributionRule4 = x.DistributionRule4;
			DistributionRule5 = x.DistributionRule5;
			CommissionCurrency = x.CommissionCurrency;
			CommissionSC = x.CommissionSC;
			CommissionFC = x.CommissionFC;
			TaxAmountSC = x.TaxAmountSC;
			TaxAmountFC = x.TaxAmountFC;
			BPLID = x.BPLID;
			CheckDepositType = x.CheckDepositType;
			AttachmentEntry = x.AttachmentEntry;
			IncomeTaxAccount = x.IncomeTaxAccount;
			IncomeTaxAmount = x.IncomeTaxAmount;
			IncomeTaxAmountSC = x.IncomeTaxAmountSC;
			IncomeTaxAmountFC = x.IncomeTaxAmountFC;
			CheckLines = x.CheckLines;
			CreditLines = x.CreditLines;
			BOELines = x.BOELines;
		}
	}
}