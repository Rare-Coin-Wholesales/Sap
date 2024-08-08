using Newtonsoft.Json;
using Sap.Core;

namespace Sap.Api.Domain.ChartOfAccounts
{
	public partial class ChartOfAccount : BaseEntity
	{
		#region Fields
		[JsonProperty("Code")]
		public string Code;

		[JsonProperty("Name")]
		public string Name;

		[JsonProperty("Balance")]
		public string Balance;

		[JsonProperty("CashAccount")]
		public string CashAccount;

		[JsonProperty("BudgetAccount")]
		public string BudgetAccount;

		[JsonProperty("ActiveAccount")]
		public string ActiveAccount;

		[JsonProperty("PrimaryAccount")]
		public string PrimaryAccount;

		[JsonProperty("AccountLevel")]
		public string AccountLevel;

		[JsonProperty("DataExportCode")]
		public string DataExportCode;

		[JsonProperty("FatherAccountKey")]
		public string FatherAccountKey;

		[JsonProperty("ExternalCode")]
		public string ExternalCode;

		[JsonProperty("RateConversion")]
		public string RateConversion;

		[JsonProperty("TaxLiableAccount")]
		public string TaxLiableAccount;

		[JsonProperty("TaxExemptAccount")]
		public string TaxExemptAccount;

		[JsonProperty("ExternalReconNo")]
		public string ExternalReconNo;

		[JsonProperty("InternalReconNo")]
		public string InternalReconNo;

		[JsonProperty("AccountType")]
		public string AccountType;

		[JsonProperty("AcctCurrency")]
		public string AcctCurrency;

		[JsonProperty("Balance_syscurr")]
		public string BalanceSyscurr;

		[JsonProperty("Balance_FrgnCurr")]
		public string BalanceFrgnCurr;

		[JsonProperty("Protected")]
		public string Protected;

		[JsonProperty("ReconciledAccount")]
		public string ReconciledAccount;

		[JsonProperty("LiableForAdvances")]
		public string LiableForAdvances;

		[JsonProperty("ForeignName")]
		public string ForeignName;

		[JsonProperty("Details")]
		public string Details;

		[JsonProperty("ProjectCode")]
		public string ProjectCode;

		[JsonProperty("RevaluationCoordinated")]
		public string RevaluationCoordinated;

		[JsonProperty("LockManualTransaction")]
		public string LockManualTransaction;

		[JsonProperty("FormatCode")]
		public string FormatCode;

		[JsonProperty("AllowChangeVatGroup")]
		public string AllowChangeVatGroup;

		[JsonProperty("DefaultVatGroup")]
		public string DefaultVatGroup;

		[JsonProperty("Category")]
		public string Category;

		[JsonProperty("TransactionCode")]
		public string TransactionCode;

		[JsonProperty("LoadingType")]
		public string LoadingType;

		[JsonProperty("LoadingFactorCode")]
		public string LoadingFactorCode;

		[JsonProperty("LoadingFactorCode2")]
		public string LoadingFactorCode2;

		[JsonProperty("LoadingFactorCode3")]
		public string LoadingFactorCode3;

		[JsonProperty("LoadingFactorCode4")]
		public string LoadingFactorCode4;

		[JsonProperty("LoadingFactorCode5")]
		public string LoadingFactorCode5;

		[JsonProperty("PlanningLevel")]
		public string PlanningLevel;

		[JsonProperty("DatevAccount")]
		public string DatevAccount;

		[JsonProperty("DatevAutoAccount")]
		public string DatevAutoAccount;

		[JsonProperty("DatevFirstDataEntry")]
		public string DatevFirstDataEntry;

		[JsonProperty("AllowMultipleLinking")]
		public string AllowMultipleLinking;

		[JsonProperty("ProjectRelevant")]
		public string ProjectRelevant;

		[JsonProperty("DistributionRuleRelevant")]
		public string DistributionRuleRelevant;

		[JsonProperty("DistributionRule2Relevant")]
		public string DistributionRule2Relevant;

		[JsonProperty("DistributionRule3Relevant")]
		public string DistributionRule3Relevant;

		[JsonProperty("DistributionRule4Relevant")]
		public string DistributionRule4Relevant;

		[JsonProperty("DistributionRule5Relevant")]
		public string DistributionRule5Relevant;

		[JsonProperty("BPLID")]
		public string BPLID;

		[JsonProperty("BPLName")]
		public string BPLName;

		[JsonProperty("VATRegNum")]
		public string VATRegNum;

		[JsonProperty("AccountPurposeCode")]
		public string AccountPurposeCode;

		[JsonProperty("ReferentialAccountCode")]
		public string ReferentialAccountCode;

		[JsonProperty("ValidFor")]
		public string ValidFor;

		[JsonProperty("ValidFrom")]
		public string ValidFrom;

		[JsonProperty("ValidTo")]
		public string ValidTo;

		[JsonProperty("ValidRemarks")]
		public string ValidRemarks;

		[JsonProperty("FrozenFor")]
		public string FrozenFor;

		[JsonProperty("FrozenFrom")]
		public string FrozenFrom;

		[JsonProperty("FrozenTo")]
		public string FrozenTo;

		[JsonProperty("FrozenRemarks")]
		public string FrozenRemarks;

		[JsonProperty("BlockManualPosting")]
		public string BlockManualPosting;

		[JsonProperty("CashFlowRelevant")]
		public string CashFlowRelevant;

		[JsonProperty("PCN874ReportRelevant")]
		public string PCN874ReportRelevant;

		[JsonProperty("PrimaryClosingAccount")]
		public string PrimaryClosingAccount;

		[JsonProperty("CostAccountingOnly")]
		public string CostAccountingOnly;

		[JsonProperty("CostElementRelevant")]
		public string CostElementRelevant;

		[JsonProperty("CostElementCode")]
		public string CostElementCode;

		[JsonProperty("StandardAccountCode")]
		public string StandardAccountCode;

		[JsonProperty("TaxonomyCode")]
		public string TaxonomyCode;

		[JsonProperty("IncomeClassificationCategory")]
		public string IncomeClassificationCategory;

		[JsonProperty("IncomeClassificationType")]
		public string IncomeClassificationType;

		[JsonProperty("ExpenseClassificationCategory")]
		public string ExpenseClassificationCategory;

		[JsonProperty("ExpenseClassificationType")]
		public string ExpenseClassificationType;

		[JsonProperty("OfficialAccountCode")]
		public string OfficialAccountCode;

		[JsonProperty("U_INV")]
		public string UINV;
		#endregion
	}
}