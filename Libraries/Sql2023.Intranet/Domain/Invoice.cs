namespace Sql2023.Intranet.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Invoice
    {
        [Key]
        public int IID { get; set; }

        public int InvoiceID { get; set; }

        [Column("Cust#")]
        [StringLength(50)]
        public string Cust_ { get; set; }

        [StringLength(4000)]
        public string ShipToName1 { get; set; }

        [StringLength(4000)]
        public string ShipToName2 { get; set; }

        [StringLength(4000)]
        public string ShipToAddress1 { get; set; }

        [StringLength(50)]
        public string ShipToAddress2 { get; set; }

        [StringLength(50)]
        public string ShipToCity { get; set; }

        [StringLength(50)]
        public string ShipToState { get; set; }

        [StringLength(50)]
        public string ShipToZip { get; set; }

        [StringLength(50)]
        public string Territory { get; set; }

        [StringLength(50)]
        public string SalesRep { get; set; }

        [StringLength(50)]
        public string Terms { get; set; }

        [StringLength(50)]
        public string OrderNumber { get; set; }

        [StringLength(50)]
        public string TaxCode { get; set; }

        public DateTime? DateEntered { get; set; }

        public DateTime? DateInvoiced { get; set; }

        public DateTime? DateShipped { get; set; }

        [StringLength(50)]
        public string CustomerPO { get; set; }

        [StringLength(50)]
        public string ShipVia { get; set; }

        [StringLength(100)]
        public string ShipTracking { get; set; }

        public DateTime? ShipDateActual { get; set; }

        public decimal? TotalSales { get; set; }

        public decimal? TotalSalesTaxable { get; set; }

        public decimal? TotalCost { get; set; }

        public decimal? TotalRock { get; set; }

        public decimal? TaxAmount { get; set; }
    }
}
