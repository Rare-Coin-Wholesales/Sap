namespace Sql2023.Intranet.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InvoiceLineItem
    {
        [Key]
        public int ILID { get; set; }

        public int InvoiceID { get; set; }

        public int? InvoiceLine { get; set; }

        public int? CoinID { get; set; }

        public int? QtyOrdered { get; set; }

        public decimal? Price { get; set; }

        public decimal? Cost { get; set; }

        public decimal? Rock { get; set; }
    }
}
