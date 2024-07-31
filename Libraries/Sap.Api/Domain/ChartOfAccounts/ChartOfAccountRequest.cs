using Sap.Core;

namespace Sap.Api.Domain.ChartOfAccounts
{
	public partial class ChartOfAccountRequest : BaseRequest
	{
		#region Fields
		public const string ACTION = "ChartOfAccounts";
		public int? AccountLevel;
		public int? InternalReconNo;
		public decimal? Balance;
		public decimal? BalanceFrgnCurr;
		public decimal? BalanceSyscurr;
		public string AccountPurposeCode;
		public string AccountType;
		public string AcctCurrency;
		public string ActiveAccount;
		public string AllowChangeVatGroup;
		public string AllowMultipleLinking;
		public string BlockManualPosting;
		public string BPLID;
		public string BPLName;
		public string BudgetAccount;
		public string CashAccount;
		public string CashFlowRelevant;
		public string Category;
		public string Code;
		public string CostAccountingOnly;
		public string CostElementCode;
		public string CostElementRelevant;
		public string DataExportCode;
		public string DatevAccount;
		public string DatevAutoAccount;
		public string DatevFirstDataEntry;
		public string DefaultVatGroup;
		public string Details;
		public string DistributionRule2Relevant;
		public string DistributionRule3Relevant;
		public string DistributionRule4Relevant;
		public string DistributionRule5Relevant;
		public string DistributionRuleRelevant;
		public string ExpenseClassificationCategory;
		public string ExpenseClassificationType;
		public string ExternalCode;
		public string ExternalReconNo;
		public string FatherAccountKey;
		public string ForeignName;
		public string FormatCode;
		public string FrozenFor;
		public string FrozenFrom;
		public string FrozenRemarks;
		public string FrozenTo;
		public string IncomeClassificationCategory;
		public string IncomeClassificationType;
		public string LiableForAdvances;
		public string LoadingFactorCode;
		public string LoadingFactorCode2;
		public string LoadingFactorCode3;
		public string LoadingFactorCode4;
		public string LoadingFactorCode5;
		public string LoadingType;
		public string LockManualTransaction;
		public string Name;
		public string OfficialAccountCode;
		public string PCN874ReportRelevant;
		public string PlanningLevel;
		public string PrimaryAccount;
		public string PrimaryClosingAccount;
		public string ProjectCode;
		public string ProjectRelevant;
		public string Protected;
		public string RateConversion;
		public string ReconciledAccount;
		public string ReferentialAccountCode;
		public string RevaluationCoordinated;
		public string StandardAccountCode;
		public string TaxExemptAccount;
		public string TaxLiableAccount;
		public string TaxonomyCode;
		public string TransactionCode;
		public string ValidFor;
		public string ValidFrom;
		public string ValidRemarks;
		public string ValidTo;
		public string VATRegNum;
		#endregion

		public ChartOfAccountRequest() { }

		public ChartOfAccountRequest(string code)
		{
			Code = code;
		}

		public ChartOfAccountRequest(ChartOfAccount x)
		{
			Balance = x.Balance;
			BalanceFrgnCurr = x.BalanceFrgnCurr;
			BalanceSyscurr = x.BalanceSyscurr;
			AccountLevel = x.AccountLevel;
			InternalReconNo = x.InternalReconNo;
			AccountPurposeCode = x.AccountPurposeCode;
			AccountType = x.AccountType;
			AcctCurrency = x.AcctCurrency;
			ActiveAccount = x.ActiveAccount;
			AllowChangeVatGroup = x.AllowChangeVatGroup;
			AllowMultipleLinking = x.AllowMultipleLinking;
			BlockManualPosting = x.BlockManualPosting;
			BPLID = x.BPLID;
			BPLName = x.BPLName;
			BudgetAccount = x.BudgetAccount;
			CashAccount = x.CashAccount;
			CashFlowRelevant = x.CashFlowRelevant;
			Category = x.Category;
			Code = x.Code;
			CostAccountingOnly = x.CostAccountingOnly;
			CostElementCode = x.CostElementCode;
			CostElementRelevant = x.CostElementRelevant;
			DataExportCode = x.DataExportCode;
			DatevAccount = x.DatevAccount;
			DatevAutoAccount = x.DatevAutoAccount;
			DatevFirstDataEntry = x.DatevFirstDataEntry;
			DefaultVatGroup = x.DefaultVatGroup;
			Details = x.Details;
			DistributionRule2Relevant = x.DistributionRule2Relevant;
			DistributionRule3Relevant = x.DistributionRule3Relevant;
			DistributionRule4Relevant = x.DistributionRule4Relevant;
			DistributionRule5Relevant = x.DistributionRule5Relevant;
			DistributionRuleRelevant = x.DistributionRuleRelevant;
			ExpenseClassificationCategory = x.ExpenseClassificationCategory;
			ExpenseClassificationType = x.ExpenseClassificationType;
			ExternalCode = x.ExternalCode;
			ExternalReconNo = x.ExternalReconNo;
			FatherAccountKey = x.FatherAccountKey;
			ForeignName = x.ForeignName;
			FormatCode = x.FormatCode;
			FrozenFor = x.FrozenFor;
			FrozenFrom = x.FrozenFrom;
			FrozenRemarks = x.FrozenRemarks;
			FrozenTo = x.FrozenTo;
			IncomeClassificationCategory = x.IncomeClassificationCategory;
			IncomeClassificationType = x.IncomeClassificationType;
			LiableForAdvances = x.LiableForAdvances;
			LoadingFactorCode = x.LoadingFactorCode;
			LoadingFactorCode2 = x.LoadingFactorCode2;
			LoadingFactorCode3 = x.LoadingFactorCode3;
			LoadingFactorCode4 = x.LoadingFactorCode4;
			LoadingFactorCode5 = x.LoadingFactorCode5;
			LoadingType = x.LoadingType;
			LockManualTransaction = x.LockManualTransaction;
			Name = x.Name;
			OfficialAccountCode = x.OfficialAccountCode;
			PCN874ReportRelevant = x.PCN874ReportRelevant;
			PlanningLevel = x.PlanningLevel;
			PrimaryAccount = x.PrimaryAccount;
			PrimaryClosingAccount = x.PrimaryClosingAccount;
			ProjectCode = x.ProjectCode;
			ProjectRelevant = x.ProjectRelevant;
			Protected = x.Protected;
			RateConversion = x.RateConversion;
			ReconciledAccount = x.ReconciledAccount;
			ReferentialAccountCode = x.ReferentialAccountCode;
			RevaluationCoordinated = x.RevaluationCoordinated;
			StandardAccountCode = x.StandardAccountCode;
			TaxExemptAccount = x.TaxExemptAccount;
			TaxLiableAccount = x.TaxLiableAccount;
			TaxonomyCode = x.TaxonomyCode;
			TransactionCode = x.TransactionCode;
			ValidFor = x.ValidFor;
			ValidFrom = x.ValidFrom;
			ValidRemarks = x.ValidRemarks;
			ValidTo = x.ValidTo;
			VATRegNum = x.VATRegNum;
		}
	}
}