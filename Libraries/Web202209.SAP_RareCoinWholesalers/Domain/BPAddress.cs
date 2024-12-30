namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BPAddress")]
    public partial class BPAddress
    {
        [StringLength(400)]
        public string AddressName { get; set; }

        [StringLength(400)]
        public string Street { get; set; }

        [StringLength(400)]
        public string Block { get; set; }

        [StringLength(400)]
        public string ZipCode { get; set; }

        [StringLength(400)]
        public string City { get; set; }

        [StringLength(400)]
        public string County { get; set; }

        [StringLength(400)]
        public string Country { get; set; }

        [StringLength(400)]
        public string State { get; set; }

        [StringLength(400)]
        public string FederalTaxID { get; set; }

        [StringLength(400)]
        public string TaxCode { get; set; }

        [StringLength(400)]
        public string BuildingFloorRoom { get; set; }

        [StringLength(400)]
        public string AddressType { get; set; }

        [StringLength(400)]
        public string AddressName2 { get; set; }

        [StringLength(400)]
        public string AddressName3 { get; set; }

        [StringLength(400)]
        public string TypeOfAddress { get; set; }

        [StringLength(400)]
        public string StreetNo { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(400)]
        public string BPCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RowNum { get; set; }

        [StringLength(400)]
        public string GlobalLocationNumber { get; set; }

        [StringLength(400)]
        public string Nationality { get; set; }

        [StringLength(400)]
        public string TaxOffice { get; set; }

        [StringLength(400)]
        public string GSTIN { get; set; }

        [StringLength(400)]
        public string GstType { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(400)]
        public string CreateTime { get; set; }

        [StringLength(400)]
        public string MYFType { get; set; }

        [StringLength(400)]
        public string TaasEnabled { get; set; }
    }
}
