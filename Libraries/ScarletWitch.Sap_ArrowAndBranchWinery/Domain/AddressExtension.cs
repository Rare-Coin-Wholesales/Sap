namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AddressExtension")]
    public partial class AddressExtension
    {
        public int Id { get; set; }

        public int? DocEntry { get; set; }

        [StringLength(255)]
        public string BillToAddress2 { get; set; }

        [StringLength(255)]
        public string BillToAddress3 { get; set; }

        [StringLength(255)]
        public string BillToAddressType { get; set; }

        [StringLength(255)]
        public string BillToBlock { get; set; }

        [StringLength(255)]
        public string BillToBuilding { get; set; }

        [StringLength(255)]
        public string BillToCity { get; set; }

        [StringLength(255)]
        public string BillToCountry { get; set; }

        [StringLength(255)]
        public string BillToCounty { get; set; }

        [StringLength(255)]
        public string BillToGlobalLocationNumber { get; set; }

        [StringLength(255)]
        public string BillToState { get; set; }

        [StringLength(255)]
        public string BillToStreet { get; set; }

        [StringLength(255)]
        public string BillToStreetNo { get; set; }

        [StringLength(255)]
        public string BillToZipCode { get; set; }

        [StringLength(255)]
        public string DeliveryPlaceBlock { get; set; }

        [StringLength(255)]
        public string DeliveryPlaceBP { get; set; }

        [StringLength(255)]
        public string DeliveryPlaceBuilding { get; set; }

        [StringLength(255)]
        public string DeliveryPlaceCity { get; set; }

        [StringLength(255)]
        public string DeliveryPlaceCNPJ { get; set; }

        [StringLength(255)]
        public string DeliveryPlaceCountry { get; set; }

        [StringLength(255)]
        public string DeliveryPlaceCounty { get; set; }

        [StringLength(255)]
        public string DeliveryPlaceCPF { get; set; }

        [StringLength(255)]
        public string DeliveryPlaceDepartureDate { get; set; }

        [StringLength(255)]
        public string DeliveryPlaceEMail { get; set; }

        [StringLength(255)]
        public string DeliveryPlacePhone { get; set; }

        [StringLength(255)]
        public string DeliveryPlaceState { get; set; }

        [StringLength(255)]
        public string DeliveryPlaceStreet { get; set; }

        [StringLength(255)]
        public string DeliveryPlaceStreetNo { get; set; }

        [StringLength(255)]
        public string DeliveryPlaceZip { get; set; }

        [StringLength(255)]
        public string GoodsIssuePlaceBlock { get; set; }

        [StringLength(255)]
        public string GoodsIssuePlaceBP { get; set; }

        [StringLength(255)]
        public string GoodsIssuePlaceBuilding { get; set; }

        [StringLength(255)]
        public string GoodsIssuePlaceCity { get; set; }

        [StringLength(255)]
        public string GoodsIssuePlaceCNPJ { get; set; }

        [StringLength(255)]
        public string GoodsIssuePlaceCountry { get; set; }

        [StringLength(255)]
        public string GoodsIssuePlaceCounty { get; set; }

        [StringLength(255)]
        public string GoodsIssuePlaceCPF { get; set; }

        [StringLength(255)]
        public string GoodsIssuePlaceDepartureDate { get; set; }

        [StringLength(255)]
        public string GoodsIssuePlaceEMail { get; set; }

        [StringLength(255)]
        public string GoodsIssuePlacePhone { get; set; }

        [StringLength(255)]
        public string GoodsIssuePlaceState { get; set; }

        [StringLength(255)]
        public string GoodsIssuePlaceStreet { get; set; }

        [StringLength(255)]
        public string GoodsIssuePlaceStreetNo { get; set; }

        [StringLength(255)]
        public string GoodsIssuePlaceZip { get; set; }

        [StringLength(255)]
        public string PlaceOfSupply { get; set; }

        [StringLength(255)]
        public string PurchasePlaceOfSupply { get; set; }

        [StringLength(255)]
        public string ShipToAddress2 { get; set; }

        [StringLength(255)]
        public string ShipToAddress3 { get; set; }

        [StringLength(255)]
        public string ShipToAddressType { get; set; }

        [StringLength(255)]
        public string ShipToBlock { get; set; }

        [StringLength(255)]
        public string ShipToBuilding { get; set; }

        [StringLength(255)]
        public string ShipToCity { get; set; }

        [StringLength(255)]
        public string ShipToCountry { get; set; }

        [StringLength(255)]
        public string ShipToCounty { get; set; }

        [StringLength(255)]
        public string ShipToGlobalLocationNumber { get; set; }

        [StringLength(255)]
        public string ShipToState { get; set; }

        [StringLength(255)]
        public string ShipToStreet { get; set; }

        [StringLength(255)]
        public string ShipToStreetNo { get; set; }

        [StringLength(255)]
        public string ShipToZipCode { get; set; }
    }
}
