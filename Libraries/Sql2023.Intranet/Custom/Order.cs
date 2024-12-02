namespace Sql2023.Intranet.Domain
{
	public partial class Order
	{
		public string VendorId
		{
			get {
				return $"V{Cust_}";
			}
		}
	}
}