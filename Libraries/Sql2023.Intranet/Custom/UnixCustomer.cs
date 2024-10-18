namespace Sql2023.Intranet.Domain
{
using System;
using Sap.Core;

	public partial class UnixCustomer
	{
		public string VendorId {
			get { return $"V{CustID}"; }
		}

		/// <summary>
		/// Builds Notes based on CustTerms, CustTaxCode, and CustContact.
		/// </summary>
		/// <returns>The notes.</returns>
		public string BuildNotes()
		{
			if (String.IsNullOrWhiteSpace(CustID))
				return string.Empty;

			var temp = "";

			if (!String.IsNullOrWhiteSpace(CustTerms))
				temp = $"{temp}Terms: {CustTerms}. ";
			if (!String.IsNullOrWhiteSpace(CustTaxCode))
				temp = $"{temp}TaxCode: {CustTaxCode}. ";
			if (!String.IsNullOrWhiteSpace(CustContact) && !CommonUtil.IsValidEmail(CustContact))
				temp = $"{temp}Contact: {CommonUtil.ToTitleCase(CustContact)}";

			return temp.Trim();
		}
	}
}