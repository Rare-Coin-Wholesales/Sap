using System.Collections.Generic;
using Sap.Core;

namespace Sap.Api.Domain.ChecksforPayments
{
	public partial class ChecksforPayment : BaseEntity
	{
		public IList<ChecksforPaymentLine> ChecksforPaymentLines;
		public int? CheckKey;
		public string AccountNumber;
		public string BankCode;
		public string Branch;
		public string CardOrAccount;
		public string CheckNumber;
		public string CountryCode;
		public string CustomerAccountCode;
		public string Details;
		public string VendorCode;

		public ChecksforPayment()
		{
			ChecksforPaymentLines = new List<ChecksforPaymentLine>();
		}
	}

	public class ChecksforPaymentLine
	{
		public string RowNumber;
		public string RowDetails;
		public string RowTotal;
		public string RowCurrency;
		public string TaxDefinition;
		public string TaxPercent;
		public string CreditedAccount;
		public string LineTotal;
	}
}