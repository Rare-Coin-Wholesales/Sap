namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CreditLine")]
    public partial class CreditLine
    {
        public int Id { get; set; }

        public int? AbsId { get; set; }
    }
}
