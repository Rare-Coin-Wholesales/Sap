namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("GLAccountAdvancedRule")]
    public partial class GLAccountAdvancedRule
    {
        public int Id { get; set; }

        public int? AbsoluteEntry { get; set; }

        public int? FinancialYear { get; set; }

        [StringLength(255)]
        public string BeginningofFinancialYear { get; set; }

        [StringLength(255)]
        public string Code { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(255)]
        public string EUExpensesAccount { get; set; }

        [StringLength(255)]
        public string EURevenuesAccount { get; set; }

        [StringLength(255)]
        public string ExpenseClearingAct { get; set; }

        [StringLength(255)]
        public string ExpensesAccount { get; set; }

        [StringLength(255)]
        public string ForeignExpensAcc { get; set; }

        [StringLength(255)]
        public string ForeignRevenueAcc { get; set; }

        [StringLength(255)]
        public string FromDate { get; set; }

        [StringLength(255)]
        public string IsActive { get; set; }

        [StringLength(255)]
        public string Period { get; set; }

        [StringLength(255)]
        public string RevenuesAccount { get; set; }

        [StringLength(255)]
        public string ToDate { get; set; }

        [StringLength(255)]
        public string Warehouse { get; set; }
    }
}
