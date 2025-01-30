namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InternalReconciliationRow
    {
        public int Id { get; set; }

        public int? ReconNum { get; set; }

        public int? LineSeq { get; set; }

        [StringLength(50)]
        public string ShortName { get; set; }

        public int? TransId { get; set; }

        public int? TransRowId { get; set; }

        [StringLength(10)]
        public string SrcObjTyp { get; set; }

        public int? SrcObjAbs { get; set; }

        [StringLength(20)]
        public string CreditOrDebit { get; set; }

        public decimal? ReconcileAmount { get; set; }

        public decimal? CashDiscount { get; set; }

        public virtual InternalReconciliation InternalReconciliation { get; set; }
    }
}
