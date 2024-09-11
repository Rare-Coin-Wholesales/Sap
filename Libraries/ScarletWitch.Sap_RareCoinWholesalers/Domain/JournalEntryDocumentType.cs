namespace ScarletWitch.Sap_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JournalEntryDocumentType")]
    public partial class JournalEntryDocumentType
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string JournalEntryType { get; set; }

        [StringLength(255)]
        public string DocTypeDescription { get; set; }

        [StringLength(255)]
        public string ShortName { get; set; }
    }
}
