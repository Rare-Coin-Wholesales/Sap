using System;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.Common
{
	public partial class DocumentInstallment
	{
		public DateTime? DueDate;
		public decimal? Percentage;
		public decimal? Total;
		public int? DunningLevel;
		public int? InstallmentId;
		public string LastDunningDate;
		public string PaymentOrdered;
		public string TotalFC;
	}
}