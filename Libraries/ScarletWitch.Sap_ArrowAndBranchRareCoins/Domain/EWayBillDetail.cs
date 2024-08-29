namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EWayBillDetail")]
    public partial class EWayBillDetail
    {
        public int Id { get; set; }
    }
}
