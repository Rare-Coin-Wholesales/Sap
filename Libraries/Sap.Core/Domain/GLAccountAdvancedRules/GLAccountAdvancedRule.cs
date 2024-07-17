namespace Sap.Core.Domain.GLAccountAdvancedRules
{
	public partial class GLAccountAdvancedRule : BaseEntity
	{
		public int? AbsoluteEntry;
		public int? FinancialYear;
		public string? BeginningofFinancialYear;
		public string? Code;
		public string? Description;
		public string? EUExpensesAccount;
		public string? EURevenuesAccount;
		public string? ExpenseClearingAct;
		public string? ExpensesAccount;
		public string? ForeignExpensAcc;
		public string? ForeignRevenueAcc;
		public string? FromDate;
		public string? IsActive;
		public string? Period;
		public string? RevenuesAccount;
		public string? ToDate;
		public string? Warehouse;
	}
}