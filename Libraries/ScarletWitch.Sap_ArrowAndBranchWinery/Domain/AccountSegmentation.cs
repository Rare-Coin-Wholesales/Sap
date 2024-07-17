namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("AccountSegmentation")]
    public partial class AccountSegmentation
    {
        public int Id { get; set; }

        public int? Numerator { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public int? Size { get; set; }

        [StringLength(255)]
        public string Type { get; set; }
    }
}
