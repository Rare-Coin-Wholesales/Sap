using Newtonsoft.Json;
using Sap.Core;

namespace Sap.Api.Domain.PurchaseCreditNotes
{
	public partial class AddressExtension : BaseEntity
	{
		#region Fields
		[JsonProperty("ShipToStreet")]
		public string ShipToStreet;

		[JsonProperty("ShipToStreetNo")]
		public string ShipToStreetNo;

		[JsonProperty("ShipToBlock")]
		public string ShipToBlock;

		[JsonProperty("ShipToBuilding")]
		public string ShipToBuilding;

		[JsonProperty("ShipToCity")]
		public string ShipToCity;

		[JsonProperty("ShipToZipCode")]
		public string ShipToZipCode;

		[JsonProperty("ShipToCounty")]
		public string ShipToCounty;

		[JsonProperty("ShipToState")]
		public string ShipToState;

		[JsonProperty("ShipToCountry")]
		public string ShipToCountry;

		[JsonProperty("ShipToAddressType")]
		public string ShipToAddressType;

		[JsonProperty("BillToStreet")]
		public string BillToStreet;

		[JsonProperty("BillToStreetNo")]
		public string BillToStreetNo;

		[JsonProperty("BillToBlock")]
		public string BillToBlock;

		[JsonProperty("BillToBuilding")]
		public string BillToBuilding;

		[JsonProperty("BillToCity")]
		public string BillToCity;

		[JsonProperty("BillToZipCode")]
		public string BillToZipCode;

		[JsonProperty("BillToCounty")]
		public string BillToCounty;

		[JsonProperty("BillToState")]
		public string BillToState;

		[JsonProperty("BillToCountry")]
		public string BillToCountry;

		[JsonProperty("BillToAddressType")]
		public string BillToAddressType;

		[JsonProperty("ShipToGlobalLocationNumber")]
		public string ShipToGlobalLocationNumber;

		[JsonProperty("BillToGlobalLocationNumber")]
		public string BillToGlobalLocationNumber;

		[JsonProperty("ShipToAddress2")]
		public string ShipToAddress2;

		[JsonProperty("ShipToAddress3")]
		public string ShipToAddress3;

		[JsonProperty("BillToAddress2")]
		public string BillToAddress2;

		[JsonProperty("BillToAddress3")]
		public string BillToAddress3;

		[JsonProperty("PlaceOfSupply")]
		public string PlaceOfSupply;

		[JsonProperty("PurchasePlaceOfSupply")]
		public string PurchasePlaceOfSupply;

		[JsonProperty("DocEntry")]
		public int? DocEntry;

		[JsonProperty("GoodsIssuePlaceBP")]
		public string GoodsIssuePlaceBP;

		[JsonProperty("GoodsIssuePlaceCNPJ")]
		public string GoodsIssuePlaceCNPJ;

		[JsonProperty("GoodsIssuePlaceCPF")]
		public string GoodsIssuePlaceCPF;

		[JsonProperty("GoodsIssuePlaceStreet")]
		public string GoodsIssuePlaceStreet;

		[JsonProperty("GoodsIssuePlaceStreetNo")]
		public string GoodsIssuePlaceStreetNo;

		[JsonProperty("GoodsIssuePlaceBuilding")]
		public string GoodsIssuePlaceBuilding;

		[JsonProperty("GoodsIssuePlaceZip")]
		public string GoodsIssuePlaceZip;

		[JsonProperty("GoodsIssuePlaceBlock")]
		public string GoodsIssuePlaceBlock;

		[JsonProperty("GoodsIssuePlaceCity")]
		public string GoodsIssuePlaceCity;

		[JsonProperty("GoodsIssuePlaceCounty")]
		public string GoodsIssuePlaceCounty;

		[JsonProperty("GoodsIssuePlaceState")]
		public string GoodsIssuePlaceState;

		[JsonProperty("GoodsIssuePlaceCountry")]
		public string GoodsIssuePlaceCountry;

		[JsonProperty("GoodsIssuePlacePhone")]
		public string GoodsIssuePlacePhone;

		[JsonProperty("GoodsIssuePlaceEMail")]
		public string GoodsIssuePlaceEMail;

		[JsonProperty("GoodsIssuePlaceDepartureDate")]
		public string GoodsIssuePlaceDepartureDate;

		[JsonProperty("DeliveryPlaceBP")]
		public string DeliveryPlaceBP;

		[JsonProperty("DeliveryPlaceCNPJ")]
		public string DeliveryPlaceCNPJ;

		[JsonProperty("DeliveryPlaceCPF")]
		public string DeliveryPlaceCPF;

		[JsonProperty("DeliveryPlaceStreet")]
		public string DeliveryPlaceStreet;

		[JsonProperty("DeliveryPlaceStreetNo")]
		public string DeliveryPlaceStreetNo;

		[JsonProperty("DeliveryPlaceBuilding")]
		public string DeliveryPlaceBuilding;

		[JsonProperty("DeliveryPlaceZip")]
		public string DeliveryPlaceZip;

		[JsonProperty("DeliveryPlaceBlock")]
		public string DeliveryPlaceBlock;

		[JsonProperty("DeliveryPlaceCity")]
		public string DeliveryPlaceCity;

		[JsonProperty("DeliveryPlaceCounty")]
		public string DeliveryPlaceCounty;

		[JsonProperty("DeliveryPlaceState")]
		public string DeliveryPlaceState;

		[JsonProperty("DeliveryPlaceCountry")]
		public string DeliveryPlaceCountry;

		[JsonProperty("DeliveryPlacePhone")]
		public string DeliveryPlacePhone;

		[JsonProperty("DeliveryPlaceEMail")]
		public string DeliveryPlaceEMail;

		[JsonProperty("DeliveryPlaceDepartureDate")]
		public string DeliveryPlaceDepartureDate;
		#endregion
	}
}