namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChecksforPaymentLine")]
    public partial class ChecksforPaymentLine
    {
        public int Id { get; set; }

        [StringLength(4000)]
        public string CheckKey { get; set; }

        [StringLength(4000)]
        public string RowNumber { get; set; }

        [StringLength(4000)]
        public string RowDetails { get; set; }

        [StringLength(4000)]
        public string RowTotal { get; set; }

        [StringLength(4000)]
        public string RowCurrency { get; set; }

        [StringLength(4000)]
        public string TaxDefinition { get; set; }

        [StringLength(4000)]
        public string TaxPercent { get; set; }

        [StringLength(4000)]
        public string CreditedAccount { get; set; }

        [StringLength(4000)]
        public string LineTotal { get; set; }
    }
}
