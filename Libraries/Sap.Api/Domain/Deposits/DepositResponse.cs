using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sap.Api.Domain.Deposits
{
	public partial class DepositResponse : BaseResponse
	{
		[JsonProperty("value")]
		public IList<Deposit> Deposits;

		public DepositResponse()
		{
			Deposits = new List<Deposit>();
		}
	}
}