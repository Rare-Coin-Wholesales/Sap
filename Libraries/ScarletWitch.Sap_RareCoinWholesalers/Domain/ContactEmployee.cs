namespace ScarletWitch.Sap_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactEmployee")]
    public partial class ContactEmployee
    {
        public int Id { get; set; }

        [StringLength(4000)]
        public string CardCode { get; set; }

        [StringLength(4000)]
        public string Name { get; set; }

        [StringLength(4000)]
        public string Position { get; set; }

        [StringLength(4000)]
        public string Address { get; set; }

        [StringLength(4000)]
        public string Phone1 { get; set; }

        [StringLength(4000)]
        public string Phone2 { get; set; }

        [StringLength(4000)]
        public string MobilePhone { get; set; }

        [StringLength(4000)]
        public string Fax { get; set; }

        [StringLength(4000)]
        public string EMail { get; set; }

        [StringLength(4000)]
        public string Pager { get; set; }

        [StringLength(4000)]
        public string Remarks1 { get; set; }

        [StringLength(4000)]
        public string Remarks2 { get; set; }

        [StringLength(4000)]
        public string Password { get; set; }

        [StringLength(4000)]
        public string InternalCode { get; set; }

        [StringLength(4000)]
        public string PlaceOfBirth { get; set; }

        [StringLength(4000)]
        public string DateOfBirth { get; set; }

        [StringLength(4000)]
        public string Gender { get; set; }

        [StringLength(4000)]
        public string Profession { get; set; }

        [StringLength(4000)]
        public string Title { get; set; }

        [StringLength(4000)]
        public string CityOfBirth { get; set; }

        [StringLength(4000)]
        public string Active { get; set; }

        [StringLength(4000)]
        public string FirstName { get; set; }

        [StringLength(4000)]
        public string MiddleName { get; set; }

        [StringLength(4000)]
        public string LastName { get; set; }

        [StringLength(4000)]
        public string EmailGroupCode { get; set; }

        [StringLength(4000)]
        public string BlockSendingMarketingContent { get; set; }

        [StringLength(4000)]
        public string CreateDate { get; set; }

        [StringLength(4000)]
        public string CreateTime { get; set; }

        [StringLength(4000)]
        public string UpdateDate { get; set; }

        [StringLength(4000)]
        public string UpdateTime { get; set; }

        [StringLength(4000)]
        public string ConnectedAddressName { get; set; }

        [StringLength(4000)]
        public string ConnectedAddressType { get; set; }

        [StringLength(4000)]
        public string ForeignCountry { get; set; }
    }
}
