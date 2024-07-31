using Sap.Core;

namespace Sap.Api.Domain.FAAccountDeterminations
{
	public partial class FAAccountDeterminationRequest : BaseRequest
	{
		#region Fields
		public const string ACTION = "FAAccountDeterminations";
		public string AccumulatedOrdinaryDepr;
		public string AccumulatedSpecialDepr;
		public string AccumulatedUnplannedDepr;
		public string AssetBalanceSheetAccount;
		public string ClearingAccountAcquisition;
		public string Code;
		public string Description;
		public string LeavewithExpenseNBVGross;
		public string LeavewithRevenueNBVGross;
		public string OrdinaryDepreciation;
		public string RetirementwithExpenseNet;
		public string RetirementwithRevenueNet;
		public string RevaluationReserveAccount;
		public string RevaluationReserveClearing;
		public string RevenueAccountforRetirement;
		public string RevenueClearingAccount;
		public string RevenuefromAssetSalesNet;
		public string SpecialDepreciation;
		public string UnplannedDepreciation;
		#endregion

		public FAAccountDeterminationRequest() { }

		public FAAccountDeterminationRequest(string code)
		{
			Code = code;
		}

		public FAAccountDeterminationRequest(FAAccountDetermination x)
		{
			AccumulatedOrdinaryDepr = x.AccumulatedOrdinaryDepr;
			AccumulatedSpecialDepr = x.AccumulatedSpecialDepr;
			AccumulatedUnplannedDepr = x.AccumulatedUnplannedDepr;
			AssetBalanceSheetAccount = x.AssetBalanceSheetAccount;
			ClearingAccountAcquisition = x.ClearingAccountAcquisition;
			Code = x.Code;
			Description = x.Description;
			LeavewithExpenseNBVGross = x.LeavewithExpenseNBVGross;
			LeavewithRevenueNBVGross = x.LeavewithRevenueNBVGross;
			OrdinaryDepreciation = x.OrdinaryDepreciation;
			RetirementwithExpenseNet = x.RetirementwithExpenseNet;
			RetirementwithRevenueNet = x.RetirementwithRevenueNet;
			RevaluationReserveAccount = x.RevaluationReserveAccount;
			RevaluationReserveClearing = x.RevaluationReserveClearing;
			RevenueAccountforRetirement = x.RevenueAccountforRetirement;
			RevenueClearingAccount = x.RevenueClearingAccount;
			RevenuefromAssetSalesNet = x.RevenuefromAssetSalesNet;
			SpecialDepreciation = x.SpecialDepreciation;
			UnplannedDepreciation = x.UnplannedDepreciation;
		}
	}
}