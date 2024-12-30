namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactEmployee")]
    public partial class ContactEmployee
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(400)]
        public string CardCode { get; set; }

        [StringLength(400)]
        public string Name { get; set; }

        [StringLength(400)]
        public string Position { get; set; }

        [StringLength(400)]
        public string Address { get; set; }

        [StringLength(400)]
        public string Phone1 { get; set; }

        [StringLength(400)]
        public string Phone2 { get; set; }

        [StringLength(400)]
        public string MobilePhone { get; set; }

        [StringLength(400)]
        public string Fax { get; set; }

        [StringLength(400)]
        public string EMail { get; set; }

        [StringLength(400)]
        public string Pager { get; set; }

        [StringLength(400)]
        public string Remarks1 { get; set; }

        [StringLength(400)]
        public string Remarks2 { get; set; }

        [StringLength(400)]
        public string Password { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InternalCode { get; set; }

        [StringLength(400)]
        public string PlaceOfBirth { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [StringLength(400)]
        public string Gender { get; set; }

        [StringLength(400)]
        public string Profession { get; set; }

        [StringLength(400)]
        public string Title { get; set; }

        [StringLength(400)]
        public string CityOfBirth { get; set; }

        [StringLength(400)]
        public string Active { get; set; }

        [StringLength(400)]
        public string FirstName { get; set; }

        [StringLength(400)]
        public string MiddleName { get; set; }

        [StringLength(400)]
        public string LastName { get; set; }

        [StringLength(400)]
        public string EmailGroupCode { get; set; }

        [StringLength(400)]
        public string BlockSendingMarketingContent { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(400)]
        public string CreateTime { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(400)]
        public string UpdateTime { get; set; }

        [StringLength(400)]
        public string ConnectedAddressName { get; set; }

        [StringLength(400)]
        public string ConnectedAddressType { get; set; }

        [StringLength(400)]
        public string ForeignCountry { get; set; }
    }
}
