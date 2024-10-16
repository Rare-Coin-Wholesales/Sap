namespace Sql2023.Intranet.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inventory")]
    public partial class Inventory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InventoryID { get; set; }

        [StringLength(10)]
        public string InventoryOwner { get; set; }

        public decimal? InventoryCost { get; set; }

        public decimal? InventoryBaseCost { get; set; }

        public decimal? InventoryRock { get; set; }

        public decimal? InventoryWholesale { get; set; }

        public bool InventoryPOR { get; set; }

        public bool? InventoryAvailable { get; set; }

        public bool InventoryFTB { get; set; }

        [StringLength(50)]
        public string InventoryStatus { get; set; }

        public DateTime? InventoryStatusDate { get; set; }

        public DateTime? InventoryCertDate { get; set; }

        [StringLength(1)]
        public string InventoryOnWeb { get; set; }

        [StringLength(255)]
        public string InventoryNotes { get; set; }

        [StringLength(50)]
        public string InventoryDescription1 { get; set; }

        [StringLength(50)]
        public string InventoryDescription2 { get; set; }

        public string InventoryWebDescription { get; set; }

        [Column(TypeName = "text")]
        public string InventoryWebDescriptionNew { get; set; }

        public bool InventoryDescriptionUpdated { get; set; }

        public bool InventoryImageFront { get; set; }

        public DateTime? InventoryImageFrontDate { get; set; }

        public bool InventoryImageBack { get; set; }

        public DateTime? InventoryImageBackDate { get; set; }

        public bool InventoryImageFullCase { get; set; }

        public DateTime? InventoryImageFullDate { get; set; }

        public bool InventoryImageFullBackCase { get; set; }

        public DateTime? InventoryImageFullBackDate { get; set; }

        public bool Inventory100Greatest { get; set; }

        [StringLength(15)]
        public string InventoryClass { get; set; }

        [StringLength(15)]
        public string InventoryRawClass { get; set; }

        [StringLength(10)]
        public string InventoryGrade { get; set; }

        [StringLength(10)]
        public string InventoryService { get; set; }

        public DateTime? InventoryLastGradingDate { get; set; }

        [StringLength(50)]
        public string InventoryCertNumber { get; set; }

        public string InventoryGradingBarcode { get; set; }

        [StringLength(15)]
        public string InventoryOrigClass { get; set; }

        [StringLength(15)]
        public string InventoryOrigGrade { get; set; }

        [StringLength(15)]
        public string InventoryOrigGradingService { get; set; }

        [StringLength(10)]
        public string InventoryGradingService { get; set; }

        [StringLength(50)]
        public string InventoryGradingType { get; set; }

        [StringLength(50)]
        public string InventoryGradingOrder { get; set; }

        public DateTime? InventoryGradingDate { get; set; }

        [StringLength(50)]
        public string InventoryOrderNumber { get; set; }

        [StringLength(50)]
        public string InventoryARTerms { get; set; }

        [StringLength(50)]
        public string InventoryCustNumber { get; set; }

        [StringLength(50)]
        public string InventoryInvoice { get; set; }

        public DateTime? InventorySoldDate { get; set; }

        public decimal? InventorySoldPrice { get; set; }

        public decimal? InventorySalesOrderBaseSold { get; set; }

        [StringLength(50)]
        public string InventoryPurchaseOrderNumber { get; set; }

        [StringLength(50)]
        public string InventoryPurchaseOrderVendor { get; set; }

        public DateTime? InventoryPurchaseOrderReceiveDate { get; set; }

        public decimal? InventoryMarketValue { get; set; }

        [StringLength(50)]
        public string InventoryMarketValueSource { get; set; }

        public DateTime? InventoryMarketValueSourceDate { get; set; }

        public bool? InventoryConsignment { get; set; }

        public int? InventoryConsignmentNumber { get; set; }

        [StringLength(50)]
        public string InventoryConsignmentVendor { get; set; }

        public DateTime? InventoryConsignmentDate { get; set; }

        public decimal? InventoryConsignmentBase { get; set; }

        public bool InventoryConsignmentReturned { get; set; }

        public DateTime? InventoryConsignmentReturnedDate { get; set; }

        public bool InventoryConsignmentTABases { get; set; }

        public bool InventoryArchive { get; set; }

        public bool? InventoryArchivedRemove { get; set; }

        public bool InventoryFeatured { get; set; }

        public decimal? WebsiteOldPrice { get; set; }

        [StringLength(6)]
        public string CAC { get; set; }

        [StringLength(50)]
        public string Composition { get; set; }

        [StringLength(4)]
        public string Year { get; set; }

        public string KeyProductFeatures1 { get; set; }

        public string SearchTerms1 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        [StringLength(3)]
        public string CacComputed { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int IsCac { get; set; }
    }
}
