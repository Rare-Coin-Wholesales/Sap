using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace Sap.ApiToScarAabwMapper
{
	public partial class Mapper
	{
		public virtual FAAccountDetermination ToSql(Api.Domain.FAAccountDeterminations.FAAccountDetermination x)
		{
			return new FAAccountDetermination {
				AccumulatedOrdinaryDepr = x.AccumulatedOrdinaryDepr,
				AccumulatedSpecialDepr = x.AccumulatedSpecialDepr,
				AccumulatedUnplannedDepr = x.AccumulatedUnplannedDepr,
				AssetBalanceSheetAccount = x.AssetBalanceSheetAccount,
				ClearingAccountAcquisition = x.ClearingAccountAcquisition,
				Code = x.Code,
				Description = x.Description,
				LeavewithExpenseNBVGross = x.LeavewithExpenseNBVGross,
				LeavewithRevenueNBVGross = x.LeavewithRevenueNBVGross,
				OrdinaryDepreciation = x.OrdinaryDepreciation,
				RetirementwithExpenseNet = x.RetirementwithExpenseNet,
				RetirementwithRevenueNet = x.RetirementwithRevenueNet,
				RevaluationReserveAccount = x.RevaluationReserveAccount,
				RevaluationReserveClearing = x.RevaluationReserveClearing,
				RevenueAccountforRetirement = x.RevenueAccountforRetirement,
				RevenueClearingAccount = x.RevenueClearingAccount,
				RevenuefromAssetSalesNet = x.RevenuefromAssetSalesNet,
				SpecialDepreciation = x.SpecialDepreciation,
				UnplannedDepreciation = x.UnplannedDepreciation,
			};
		}
	}
}