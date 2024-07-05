namespace Sap.Core.Domain.AccountSegmentations
{
	public partial class AccountSegmentationRequest : BaseRequest
	{
		public const string ACTION = "AccountSegmentations";
		public int? Numerator;
		public string? Name;
		public int? Size;
		public string? Type;

		public AccountSegmentationRequest() { }

		public AccountSegmentationRequest(int numerator)
		{
			Numerator = numerator;
		}

		public AccountSegmentationRequest(AccountSegmentation x)
		{
			Numerator = x.Numerator;
			Name = x.Name;
			Size = x.Size;
			Type = x.Type;
		}
	}
}