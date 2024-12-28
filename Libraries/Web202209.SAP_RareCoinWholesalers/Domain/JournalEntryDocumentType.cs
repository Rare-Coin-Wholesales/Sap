namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JournalEntryDocumentType")]
    public partial class JournalEntryDocumentType
    {
        [Key]
        [StringLength(255)]
        public string JournalEntryType { get; set; }

        [StringLength(255)]
        public string DocTypeDescription { get; set; }

        [StringLength(255)]
        public string ShortName { get; set; }
    }
}
