using System;
using Newtonsoft.Json;
using Sap.Core;

namespace Sap.Api.Domain.Invoices
{
	public partial class DocumentInstallment : BaseEntity
	{
		#region Fields
		[JsonProperty("DocEntry")]
		public int? DocEntry;

		[JsonProperty("DueDate")]
		public DateTime? DueDate;

		[JsonProperty("Percentage")]
		public decimal? Percentage;

		[JsonProperty("Total")]
		public decimal? Total;

		[JsonProperty("LastDunningDate")]
		public DateTime? LastDunningDate;

		[JsonProperty("DunningLevel")]
		public int? DunningLevel;

		[JsonProperty("TotalFC")]
		public string TotalFC;

		[JsonProperty("InstallmentId")]
		public int? InstallmentId;

		[JsonProperty("PaymentOrdered")]
		public string PaymentOrdered;
		#endregion
	}
}