namespace ScarletWitch.Sap_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BPIntrastatExtension")]
    public partial class BPIntrastatExtension
    {
        public int Id { get; set; }
    }
}
