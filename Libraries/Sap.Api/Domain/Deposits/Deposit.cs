using System;
using System.Collections.Generic;
using Sap.Core;

namespace Sap.Api.Domain.Deposits
{
	public partial class Deposit : BaseEntity
	{
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

		public Deposit()
		{
			CheckLines = new List<CheckLine>();
			CreditLines = new List<object>();
			BOELines = new List<object>();
		}
	}
}