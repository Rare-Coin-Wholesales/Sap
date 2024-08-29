namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BPAddress")]
    public partial class BPAddress
    {
        public int Id { get; set; }

        [StringLength(4000)]
        public string AddressName { get; set; }

        [StringLength(4000)]
        public string Street { get; set; }

        [StringLength(4000)]
        public string Block { get; set; }

        [StringLength(4000)]
        public string ZipCode { get; set; }

        [StringLength(4000)]
        public string City { get; set; }

        [StringLength(4000)]
        public string County { get; set; }

        [StringLength(4000)]
        public string Country { get; set; }

        [StringLength(4000)]
        public string State { get; set; }

        [StringLength(4000)]
        public string FederalTaxID { get; set; }

        [StringLength(4000)]
        public string TaxCode { get; set; }

        [StringLength(4000)]
        public string BuildingFloorRoom { get; set; }

        [StringLength(4000)]
        public string AddressType { get; set; }

        [StringLength(4000)]
        public string AddressName2 { get; set; }

        [StringLength(4000)]
        public string AddressName3 { get; set; }

        [StringLength(4000)]
        public string TypeOfAddress { get; set; }

        [StringLength(4000)]
        public string StreetNo { get; set; }

        [StringLength(4000)]
        public string BPCode { get; set; }

        [StringLength(4000)]
        public string RowNum { get; set; }

        [StringLength(4000)]
        public string GlobalLocationNumber { get; set; }

        [StringLength(4000)]
        public string Nationality { get; set; }

        [StringLength(4000)]
        public string TaxOffice { get; set; }

        [StringLength(4000)]
        public string GSTIN { get; set; }

        [StringLength(4000)]
        public string GstType { get; set; }

        [StringLength(4000)]
        public string CreateDate { get; set; }

        [StringLength(4000)]
        public string CreateTime { get; set; }

        [StringLength(4000)]
        public string MYFType { get; set; }

        [StringLength(4000)]
        public string TaasEnabled { get; set; }
    }
}
