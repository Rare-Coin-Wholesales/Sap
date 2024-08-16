using System.Collections.Generic;
using Newtonsoft.Json;
using Sap.Core;

namespace Sap.Api.Domain.BusinessPartners
{
	public partial class ContactEmployee : BaseEntity
	{
		#region Fields
		[JsonProperty("CardCode")]
		public string CardCode;

		[JsonProperty("Name")]
		public string Name;

		[JsonProperty("Position")]
		public string Position;

		[JsonProperty("Address")]
		public string Address;

		[JsonProperty("Phone1")]
		public string Phone1;

		[JsonProperty("Phone2")]
		public string Phone2;

		[JsonProperty("MobilePhone")]
		public string MobilePhone;

		[JsonProperty("Fax")]
		public string Fax;

		[JsonProperty("E_Mail")]
		public string EMail;

		[JsonProperty("Pager")]
		public string Pager;

		[JsonProperty("Remarks1")]
		public string Remarks1;

		[JsonProperty("Remarks2")]
		public string Remarks2;

		[JsonProperty("Password")]
		public string Password;

		[JsonProperty("InternalCode")]
		public string InternalCode;

		[JsonProperty("PlaceOfBirth")]
		public string PlaceOfBirth;

		[JsonProperty("DateOfBirth")]
		public string DateOfBirth;

		[JsonProperty("Gender")]
		public string Gender;

		[JsonProperty("Profession")]
		public string Profession;

		[JsonProperty("Title")]
		public string Title;

		[JsonProperty("CityOfBirth")]
		public string CityOfBirth;

		[JsonProperty("Active")]
		public string Active;

		[JsonProperty("FirstName")]
		public string FirstName;

		[JsonProperty("MiddleName")]
		public string MiddleName;

		[JsonProperty("LastName")]
		public string LastName;

		[JsonProperty("EmailGroupCode")]
		public string EmailGroupCode;

		[JsonProperty("BlockSendingMarketingContent")]
		public string BlockSendingMarketingContent;

		[JsonProperty("CreateDate")]
		public string CreateDate;

		[JsonProperty("CreateTime")]
		public string CreateTime;

		[JsonProperty("UpdateDate")]
		public string UpdateDate;

		[JsonProperty("UpdateTime")]
		public string UpdateTime;

		[JsonProperty("ConnectedAddressName")]
		public string ConnectedAddressName;

		[JsonProperty("ConnectedAddressType")]
		public string ConnectedAddressType;

		[JsonProperty("ForeignCountry")]
		public string ForeignCountry;

		[JsonProperty("ContactEmployeeBlockSendingMarketingContents")]
		public IList<object> ContactEmployeeBlockSendingMarketingContents;
		#endregion

		public ContactEmployee()
		{
			ContactEmployeeBlockSendingMarketingContents = new List<object>();
		}
	}
}