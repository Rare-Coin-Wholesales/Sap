namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentDocumentReferencesCollection")]
    public partial class PaymentDocumentReferencesCollection
    {
        public int Id { get; set; }

        public DateTime? IssueDate { get; set; }

        public int? DocEntry { get; set; }

        public int? LineNumber { get; set; }

        public int? ReferencedDocEntry { get; set; }

        public int? ReferencedDocNumber { get; set; }

        [StringLength(255)]
        public string ExternalReferencedDocNumber { get; set; }

        [StringLength(255)]
        public string ReferencedObjectType { get; set; }

        [StringLength(255)]
        public string Remark { get; set; }
    }
}
