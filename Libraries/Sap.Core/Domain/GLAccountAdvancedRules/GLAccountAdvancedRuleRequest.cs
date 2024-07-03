namespace Sap.Core.Domain.GLAccountAdvancedRules
{
	public partial class GLAccountAdvancedRuleRequest : BaseRequest
	{
		public const string ACTION = "GLAccountAdvancedRules";
		public int? AbsoluteEntry;
		public string? BeginningofFinancialYear;
		public string? Code;
		public string? Description;
		public string? EUExpensesAccount;
		public string? EURevenuesAccount;
		public string? ExpenseClearingAct;
		public string? ExpensesAccount;
		public int? FinancialYear;
		public string? ForeignExpensAcc;
		public string? ForeignRevenueAcc;
		public string? FromDate;
		public string? IsActive;
		public string? Period;
		public string? RevenuesAccount;
		public string? ToDate;
		public string? Warehouse;

		public GLAccountAdvancedRuleRequest() { }

		public GLAccountAdvancedRuleRequest(int absoluteEntry)
		{
			AbsoluteEntry = absoluteEntry;
		}

		public GLAccountAdvancedRuleRequest(GLAccountAdvancedRule x)
		{
			AbsoluteEntry = x.AbsoluteEntry;
			BeginningofFinancialYear = x.BeginningofFinancialYear;
			Code = x.Code;
			Description = x.Description;
			EUExpensesAccount = x.EUExpensesAccount;
			EURevenuesAccount = x.EURevenuesAccount;
			ExpenseClearingAct = x.ExpenseClearingAct;
			ExpensesAccount = x.ExpensesAccount;
			FinancialYear = x.FinancialYear;
			ForeignExpensAcc = x.ForeignExpensAcc;
			ForeignRevenueAcc = x.ForeignRevenueAcc;
			FromDate = x.FromDate;
			IsActive = x.IsActive;
			Period = x.Period;
			RevenuesAccount = x.RevenuesAccount;
			ToDate = x.ToDate;
			Warehouse = x.Warehouse;
		}
	}
}