namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FAAccountDetermination")]
    public partial class FAAccountDetermination
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string AccumulatedOrdinaryDepr { get; set; }

        [StringLength(255)]
        public string AccumulatedSpecialDepr { get; set; }

        [StringLength(255)]
        public string AccumulatedUnplannedDepr { get; set; }

        [StringLength(255)]
        public string AssetBalanceSheetAccount { get; set; }

        [StringLength(255)]
        public string ClearingAccountAcquisition { get; set; }

        [StringLength(255)]
        public string Code { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(255)]
        public string LeavewithExpenseNBVGross { get; set; }

        [StringLength(255)]
        public string LeavewithRevenueNBVGross { get; set; }

        [StringLength(255)]
        public string OrdinaryDepreciation { get; set; }

        [StringLength(255)]
        public string RetirementwithExpenseNet { get; set; }

        [StringLength(255)]
        public string RetirementwithRevenueNet { get; set; }

        [StringLength(255)]
        public string RevaluationReserveAccount { get; set; }

        [StringLength(255)]
        public string RevaluationReserveClearing { get; set; }

        [StringLength(255)]
        public string RevenueAccountforRetirement { get; set; }

        [StringLength(255)]
        public string RevenueClearingAccount { get; set; }

        [StringLength(255)]
        public string RevenuefromAssetSalesNet { get; set; }

        [StringLength(255)]
        public string SpecialDepreciation { get; set; }

        [StringLength(255)]
        public string UnplannedDepreciation { get; set; }
    }
}
