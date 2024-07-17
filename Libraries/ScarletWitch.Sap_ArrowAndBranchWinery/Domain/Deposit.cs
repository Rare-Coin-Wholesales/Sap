namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Deposit")]
    public partial class Deposit
    {
        public int Id { get; set; }

        public int? AbsEntry { get; set; }

        [StringLength(255)]
        public string DepositAccount { get; set; }

        [StringLength(255)]
        public string DepositNumber { get; set; }

        [StringLength(255)]
        public string DepositType { get; set; }

        [StringLength(255)]
        public string JournalRemarks { get; set; }

        [StringLength(255)]
        public string VoucherAccount { get; set; }
    }
}
