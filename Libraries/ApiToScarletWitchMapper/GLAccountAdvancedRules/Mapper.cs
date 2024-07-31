using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ApiToScarletWitchMapper
{
	public partial class Mapper
	{
		public virtual GLAccountAdvancedRule ToSql(Sap.Api.Domain.GLAccountAdvancedRules.GLAccountAdvancedRule x)
		{
			return new GLAccountAdvancedRule {
				AbsoluteEntry = x.AbsoluteEntry,
				FinancialYear = x.FinancialYear,
				BeginningofFinancialYear = x.BeginningofFinancialYear,
				Code = x.Code,
				Description = x.Description,
				EUExpensesAccount = x.EUExpensesAccount,
				EURevenuesAccount = x.EURevenuesAccount,
				ExpenseClearingAct = x.ExpenseClearingAct,
				ExpensesAccount = x.ExpensesAccount,
				ForeignExpensAcc = x.ForeignExpensAcc,
				ForeignRevenueAcc = x.ForeignRevenueAcc,
				FromDate = x.FromDate,
				IsActive = x.IsActive,
				Period = x.Period,
				RevenuesAccount = x.RevenuesAccount,
				ToDate = x.ToDate,
				Warehouse = x.Warehouse,
			};
		}
	}
}