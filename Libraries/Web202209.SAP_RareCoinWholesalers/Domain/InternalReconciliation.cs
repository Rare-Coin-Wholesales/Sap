namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InternalReconciliation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InternalReconciliation()
        {
            InternalReconciliationRows = new HashSet<InternalReconciliationRow>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReconNum { get; set; }

        public DateTime? ReconDate { get; set; }

        [StringLength(50)]
        public string CardOrAccount { get; set; }

        [StringLength(50)]
        public string ReconType { get; set; }

        public decimal? Total { get; set; }

        public int? CancelAbs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InternalReconciliationRow> InternalReconciliationRows { get; set; }
    }
}
