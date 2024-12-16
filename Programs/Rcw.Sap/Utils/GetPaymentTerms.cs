using Sap.Core;
using System;

namespace Rcw.Sap
{
	partial class Program
	{
		public static string GetPaymentTerms(string transactionType, string numAtCard)
		{
			if (String.IsNullOrWhiteSpace(numAtCard) || String.IsNullOrWhiteSpace(transactionType))
				return string.Empty;
			if (transactionType.Equals(AP, StringComparison.OrdinalIgnoreCase))
				return string.Empty;

			if (transactionType.Equals(AR, StringComparison.OrdinalIgnoreCase)) {
				if (int.TryParse(numAtCard, out var id))
					return CommonUtil.ToTitleCase(_intranetInvoiceService.GetTerms(id));
			}

			return string.Empty;
		}
	}
}