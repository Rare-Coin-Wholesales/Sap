namespace Sap.Api.Domain.ChartOfAccounts
{
	public partial class ChartOfAccountRequest : BaseRequest
	{
		public const string ACTION = "ChartOfAccounts";
		#region Fields
		public string Code;
		public string Name;
		public string Balance;
		public string CashAccount;
		public string BudgetAccount;
		public string ActiveAccount;
		public string PrimaryAccount;
		public string AccountLevel;
		public string DataExportCode;
		public string FatherAccountKey;
		public string ExternalCode;
		public string RateConversion;
		public string TaxLiableAccount;
		public string TaxExemptAccount;
		public string ExternalReconNo;
		public string InternalReconNo;
		public string AccountType;
		public string AcctCurrency;
		public string BalanceSyscurr;
		public string BalanceFrgnCurr;
		public string Protected;
		public string ReconciledAccount;
		public string LiableForAdvances;
		public string ForeignName;
		public string Details;
		public string ProjectCode;
		public string RevaluationCoordinated;
		public string LockManualTransaction;
		public string FormatCode;
		public string AllowChangeVatGroup;
		public string DefaultVatGroup;
		public string Category;
		public string TransactionCode;
		public string LoadingType;
		public string LoadingFactorCode;
		public string LoadingFactorCode2;
		public string LoadingFactorCode3;
		public string LoadingFactorCode4;
		public string LoadingFactorCode5;
		public string PlanningLevel;
		public string DatevAccount;
		public string DatevAutoAccount;
		public string DatevFirstDataEntry;
		public string AllowMultipleLinking;
		public string ProjectRelevant;
		public string DistributionRuleRelevant;
		public string DistributionRule2Relevant;
		public string DistributionRule3Relevant;
		public string DistributionRule4Relevant;
		public string DistributionRule5Relevant;
		public string BPLID;
		public string BPLName;
		public string VATRegNum;
		public string AccountPurposeCode;
		public string ReferentialAccountCode;
		public string ValidFor;
		public string ValidFrom;
		public string ValidTo;
		public string ValidRemarks;
		public string FrozenFor;
		public string FrozenFrom;
		public string FrozenTo;
		public string FrozenRemarks;
		public string BlockManualPosting;
		public string CashFlowRelevant;
		public string PCN874ReportRelevant;
		public string PrimaryClosingAccount;
		public string CostAccountingOnly;
		public string CostElementRelevant;
		public string CostElementCode;
		public string StandardAccountCode;
		public string TaxonomyCode;
		public string IncomeClassificationCategory;
		public string IncomeClassificationType;
		public string ExpenseClassificationCategory;
		public string ExpenseClassificationType;
		public string OfficialAccountCode;
		public string UINV;
		#endregion

		public ChartOfAccountRequest() { }

		public ChartOfAccountRequest(string code)
		{
			Code = code;
		}

		public ChartOfAccountRequest(ChartOfAccount x)
		{
			Code = x.Code;
			Name = x.Name;
			Balance = x.Balance;
			CashAccount = x.CashAccount;
			BudgetAccount = x.BudgetAccount;
			ActiveAccount = x.ActiveAccount;
			PrimaryAccount = x.PrimaryAccount;
			AccountLevel = x.AccountLevel;
			DataExportCode = x.DataExportCode;
			FatherAccountKey = x.FatherAccountKey;
			ExternalCode = x.ExternalCode;
			RateConversion = x.RateConversion;
			TaxLiableAccount = x.TaxLiableAccount;
			TaxExemptAccount = x.TaxExemptAccount;
			ExternalReconNo = x.ExternalReconNo;
			InternalReconNo = x.InternalReconNo;
			AccountType = x.AccountType;
			AcctCurrency = x.AcctCurrency;
			BalanceSyscurr = x.BalanceSyscurr;
			BalanceFrgnCurr = x.BalanceFrgnCurr;
			Protected = x.Protected;
			ReconciledAccount = x.ReconciledAccount;
			LiableForAdvances = x.LiableForAdvances;
			ForeignName = x.ForeignName;
			Details = x.Details;
			ProjectCode = x.ProjectCode;
			RevaluationCoordinated = x.RevaluationCoordinated;
			LockManualTransaction = x.LockManualTransaction;
			FormatCode = x.FormatCode;
			AllowChangeVatGroup = x.AllowChangeVatGroup;
			DefaultVatGroup = x.DefaultVatGroup;
			Category = x.Category;
			TransactionCode = x.TransactionCode;
			LoadingType = x.LoadingType;
			LoadingFactorCode = x.LoadingFactorCode;
			LoadingFactorCode2 = x.LoadingFactorCode2;
			LoadingFactorCode3 = x.LoadingFactorCode3;
			LoadingFactorCode4 = x.LoadingFactorCode4;
			LoadingFactorCode5 = x.LoadingFactorCode5;
			PlanningLevel = x.PlanningLevel;
			DatevAccount = x.DatevAccount;
			DatevAutoAccount = x.DatevAutoAccount;
			DatevFirstDataEntry = x.DatevFirstDataEntry;
			AllowMultipleLinking = x.AllowMultipleLinking;
			ProjectRelevant = x.ProjectRelevant;
			DistributionRuleRelevant = x.DistributionRuleRelevant;
			DistributionRule2Relevant = x.DistributionRule2Relevant;
			DistributionRule3Relevant = x.DistributionRule3Relevant;
			DistributionRule4Relevant = x.DistributionRule4Relevant;
			DistributionRule5Relevant = x.DistributionRule5Relevant;
			BPLID = x.BPLID;
			BPLName = x.BPLName;
			VATRegNum = x.VATRegNum;
			AccountPurposeCode = x.AccountPurposeCode;
			ReferentialAccountCode = x.ReferentialAccountCode;
			ValidFor = x.ValidFor;
			ValidFrom = x.ValidFrom;
			ValidTo = x.ValidTo;
			ValidRemarks = x.ValidRemarks;
			FrozenFor = x.FrozenFor;
			FrozenFrom = x.FrozenFrom;
			FrozenTo = x.FrozenTo;
			FrozenRemarks = x.FrozenRemarks;
			BlockManualPosting = x.BlockManualPosting;
			CashFlowRelevant = x.CashFlowRelevant;
			PCN874ReportRelevant = x.PCN874ReportRelevant;
			PrimaryClosingAccount = x.PrimaryClosingAccount;
			CostAccountingOnly = x.CostAccountingOnly;
			CostElementRelevant = x.CostElementRelevant;
			CostElementCode = x.CostElementCode;
			StandardAccountCode = x.StandardAccountCode;
			TaxonomyCode = x.TaxonomyCode;
			IncomeClassificationCategory = x.IncomeClassificationCategory;
			IncomeClassificationType = x.IncomeClassificationType;
			ExpenseClassificationCategory = x.ExpenseClassificationCategory;
			ExpenseClassificationType = x.ExpenseClassificationType;
			OfficialAccountCode = x.OfficialAccountCode;
			UINV = x.UINV;
		}
	}
}