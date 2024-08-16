using Newtonsoft.Json;
using Sap.Core;

namespace Sap.Api.Domain.BusinessPartners
{
	public partial class BPAddress : BaseEntity
	{
		#region Fields
		[JsonProperty("AddressName")]
		public string AddressName;

		[JsonProperty("Street")]
		public string Street;

		[JsonProperty("Block")]
		public string Block;

		[JsonProperty("ZipCode")]
		public string ZipCode;

		[JsonProperty("City")]
		public string City;

		[JsonProperty("County")]
		public string County;

		[JsonProperty("Country")]
		public string Country;

		[JsonProperty("State")]
		public string State;

		[JsonProperty("FederalTaxID")]
		public string FederalTaxID;

		[JsonProperty("TaxCode")]
		public string TaxCode;

		[JsonProperty("BuildingFloorRoom")]
		public string BuildingFloorRoom;

		[JsonProperty("AddressType")]
		public string AddressType;

		[JsonProperty("AddressName2")]
		public string AddressName2;

		[JsonProperty("AddressName3")]
		public string AddressName3;

		[JsonProperty("TypeOfAddress")]
		public string TypeOfAddress;

		[JsonProperty("StreetNo")]
		public string StreetNo;

		[JsonProperty("BPCode")]
		public string BPCode;

		[JsonProperty("RowNum")]
		public string RowNum;

		[JsonProperty("GlobalLocationNumber")]
		public string GlobalLocationNumber;

		[JsonProperty("Nationality")]
		public string Nationality;

		[JsonProperty("TaxOffice")]
		public string TaxOffice;

		[JsonProperty("GSTIN")]
		public string GSTIN;

		[JsonProperty("GstType")]
		public string GstType;

		[JsonProperty("CreateDate")]
		public string CreateDate;

		[JsonProperty("CreateTime")]
		public string CreateTime;

		[JsonProperty("MYFType")]
		public string MYFType;

		[JsonProperty("TaasEnabled")]
		public string TaasEnabled;
		#endregion
	}
}