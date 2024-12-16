using System;
using System.Threading.Tasks;
using Sap.Api.Domain.Quotations;
using ScarletWitch.Sap_RareCoinWholesalers.Services.Quotations;

namespace Rcw.Sap
{
	public partial class QuotationUtil
	{
		private readonly QuotationService _quotationService = new QuotationService();

		public async Task GetAllQuotations()
		{
			Program.nLog.Trace("Begin method GetAllQuotations().");
			var list = await Program._serviceLayer.Request(QuotationRequest.ACTION).GetAllAsync<Quotation>();

			if (list == null || list.Count == 0) {
				Program.nLog.Warn("List is empty.");
				return;
			}
			else {
				_quotationService.TruncateTable();

				foreach (var v in list) {
					try {
						_quotationService.Insert(Program._mapper.ToSql(v));
					}

					catch (Exception ex) {
						#region Log
						if (ex.InnerException == null)
							Program.nLog.Warn("{0}{2}Exception thrown running _service.Insert(Program._mapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
						else
							throw;
						#endregion
					}
				}
			}
		}
	}
}
