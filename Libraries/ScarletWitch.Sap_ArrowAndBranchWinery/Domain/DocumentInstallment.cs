namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DocumentInstallment")]
    public partial class DocumentInstallment
    {
        public int Id { get; set; }

        public decimal? Percentage { get; set; }

        public decimal? Total { get; set; }

        [StringLength(255)]
        public string DunningLevel { get; set; }

        [StringLength(255)]
        public string InstallmentId { get; set; }

        [StringLength(255)]
        public string LastDunningDate { get; set; }

        [StringLength(255)]
        public string PaymentOrdered { get; set; }

        [StringLength(255)]
        public string TotalFC { get; set; }
    }
}
