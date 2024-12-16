namespace Rcw.Sap
{
	partial class Program
	{
		protected const int MAX_DOCUMENT_ID_LENGTH = 21;

		public static string GetDocumentId(string numAtCard)
		{
			if (string.IsNullOrWhiteSpace(numAtCard))
				return string.Empty;
			if (numAtCard.Length <= MAX_DOCUMENT_ID_LENGTH)
				return numAtCard;

			return numAtCard.Substring(0, MAX_DOCUMENT_ID_LENGTH);
		}
	}
}