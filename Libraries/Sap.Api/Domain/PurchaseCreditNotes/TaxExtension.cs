using Newtonsoft.Json;
using Sap.Core;

namespace Sap.Api.Domain.PurchaseCreditNotes
{
	public partial class TaxExtension : BaseEntity
	{
		#region Fields
		[JsonProperty("TaxId0")]
		public string TaxId0;

		[JsonProperty("TaxId1")]
		public string TaxId1;

		[JsonProperty("TaxId2")]
		public string TaxId2;

		[JsonProperty("TaxId3")]
		public string TaxId3;

		[JsonProperty("TaxId4")]
		public string TaxId4;

		[JsonProperty("TaxId5")]
		public string TaxId5;

		[JsonProperty("TaxId6")]
		public string TaxId6;

		[JsonProperty("TaxId7")]
		public string TaxId7;

		[JsonProperty("TaxId8")]
		public string TaxId8;

		[JsonProperty("TaxId9")]
		public string TaxId9;

		[JsonProperty("State")]
		public string State;

		[JsonProperty("County")]
		public string County;

		[JsonProperty("Incoterms")]
		public string Incoterms;

		[JsonProperty("Vehicle")]
		public string Vehicle;

		[JsonProperty("VehicleState")]
		public string VehicleState;

		[JsonProperty("NFRef")]
		public string NFRef;

		[JsonProperty("Carrier")]
		public string Carrier;

		[JsonProperty("PackQuantity")]
		public string PackQuantity;

		[JsonProperty("PackDescription")]
		public string PackDescription;

		[JsonProperty("Brand")]
		public string Brand;

		[JsonProperty("ShipUnitNo")]
		public string ShipUnitNo;

		[JsonProperty("NetWeight")]
		public decimal? NetWeight;

		[JsonProperty("GrossWeight")]
		public decimal? GrossWeight;

		[JsonProperty("StreetS")]
		public string StreetS;

		[JsonProperty("BlockS")]
		public string BlockS;

		[JsonProperty("BuildingS")]
		public string BuildingS;

		[JsonProperty("CityS")]
		public string CityS;

		[JsonProperty("ZipCodeS")]
		public string ZipCodeS;

		[JsonProperty("CountyS")]
		public string CountyS;

		[JsonProperty("StateS")]
		public string StateS;

		[JsonProperty("CountryS")]
		public string CountryS;

		[JsonProperty("StreetB")]
		public string StreetB;

		[JsonProperty("BlockB")]
		public string BlockB;

		[JsonProperty("BuildingB")]
		public string BuildingB;

		[JsonProperty("CityB")]
		public string CityB;

		[JsonProperty("ZipCodeB")]
		public string ZipCodeB;

		[JsonProperty("CountyB")]
		public string CountyB;

		[JsonProperty("StateB")]
		public string StateB;

		[JsonProperty("CountryB")]
		public string CountryB;

		[JsonProperty("ImportOrExport")]
		public string ImportOrExport;

		[JsonProperty("MainUsage")]
		public string MainUsage;

		[JsonProperty("GlobalLocationNumberS")]
		public string GlobalLocationNumberS;

		[JsonProperty("GlobalLocationNumberB")]
		public string GlobalLocationNumberB;

		[JsonProperty("TaxId12")]
		public string TaxId12;

		[JsonProperty("TaxId13")]
		public string TaxId13;

		[JsonProperty("BillOfEntryNo")]
		public string BillOfEntryNo;

		[JsonProperty("BillOfEntryDate")]
		public string BillOfEntryDate;

		[JsonProperty("OriginalBillOfEntryNo")]
		public string OriginalBillOfEntryNo;

		[JsonProperty("OriginalBillOfEntryDate")]
		public string OriginalBillOfEntryDate;

		[JsonProperty("ImportOrExportType")]
		public string ImportOrExportType;

		[JsonProperty("PortCode")]
		public string PortCode;

		[JsonProperty("DocEntry")]
		public int? DocEntry;

		[JsonProperty("BoEValue")]
		public decimal? BoEValue;

		[JsonProperty("ClaimRefund")]
		public string ClaimRefund;

		[JsonProperty("DifferentialOfTaxRate")]
		public string DifferentialOfTaxRate;

		[JsonProperty("IsIGSTAccount")]
		public string IsIGSTAccount;

		[JsonProperty("TaxId14")]
		public string TaxId14;
		#endregion
	}
}