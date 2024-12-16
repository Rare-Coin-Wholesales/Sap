namespace Sql2023.WwwSPs.Domain
{
	public partial class TradingAccount
	{
		public string VendorId
		{
			get {
				return $"V{InsightCustomerId}";
			}
		}
	}
}