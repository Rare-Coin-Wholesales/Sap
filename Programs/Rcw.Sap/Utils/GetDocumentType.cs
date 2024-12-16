using System;

namespace Rcw.Sap
{
	partial class Program
	{
		protected const int INVOICE = 1;
		protected const int CREDIT_MEMO = 5;
		protected const int PAYMENT = 6;

		protected static short? GetApDocumentType(string numAtCard, decimal? docTotal)
		{
			if (numAtCard.StartsWith("M") && !numAtCard.StartsWith("Mar", StringComparison.OrdinalIgnoreCase) &&
											 !numAtCard.StartsWith("May", StringComparison.OrdinalIgnoreCase))
				return null;

			if (decimal.TryParse(numAtCard, out _)) {
				if (docTotal.Value < 0)
					return PAYMENT;
				if (docTotal.Value == 0)
					return null;
				if (docTotal.Value > 0)
					return INVOICE;
			}

			else {
				if (docTotal.Value < 0)
					return null;
				if (docTotal.Value == 0)
					return PAYMENT;
				if (docTotal.Value > 0)
					return INVOICE;
			}

			return null;
		}

		public static short? GetDocumentType(string transactionType, string numAtCard, decimal? docTotal)
		{
			if (docTotal == null || String.IsNullOrWhiteSpace(numAtCard) || String.IsNullOrWhiteSpace(transactionType))
				return null;
			if (transactionType.Equals(AP, StringComparison.OrdinalIgnoreCase))
				return GetApDocumentType(numAtCard, docTotal);
			if (transactionType.Equals(AR, StringComparison.OrdinalIgnoreCase))
				return null;

			return null;
		}
	}
}