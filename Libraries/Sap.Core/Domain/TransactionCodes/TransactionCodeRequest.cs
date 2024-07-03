namespace Sap.Core.Domain.TransactionCodes
{
	public partial class TransactionCodeRequest : BaseRequest
	{
		public const string ACTION = "TransactionCodes";
		public string? Code;
		public string? Description;

		public TransactionCodeRequest() { }

		public TransactionCodeRequest(string code)
		{
			Code = code;
		}

		public TransactionCodeRequest(TransactionCode x)
		{
			Code = x.Code;
			Description = x.Description;
		}
	}
}