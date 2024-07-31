using System;
using System.Collections.Generic;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.Common
{
	public partial class DownPaymentsToDraw
	{
		public DateTime? DueDate;
		public DateTime? PostingDate;
		public decimal? AmountToDraw;
		public decimal? AmountToDrawSC;
		public decimal? GrossAmountToDraw;
		public decimal? GrossAmountToDrawFC;
		public decimal? GrossAmountToDrawSC;
		public decimal? Tax;
		public decimal? TaxFC;
		public decimal? TaxSC;
		public IList<DownPaymentsToDrawDetail> DownPaymentsToDrawDetails;
		public int? DocEntry;
		public int? DocInternalID;
		public int? DocNumber;
		public int? RowNum;
		public string AmountToDrawFC;
		public string Details;
		public string DownPaymentType;
		public string IsGrossLine;
		public string Name;

		public DownPaymentsToDraw()
		{
			DownPaymentsToDrawDetails = new List<DownPaymentsToDrawDetail>();
		}
	}
}
