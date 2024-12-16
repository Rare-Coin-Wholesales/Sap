namespace Sql2023.WwwSPs.Domain
{
	public partial class TradingAccountTransaction
	{
		public string VendorId
		{
			get {
				return $"V{InsightCustomerId}";
			}
		}
	}
}