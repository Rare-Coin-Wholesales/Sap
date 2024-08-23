using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.Quotations;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.Quotations;

namespace Sap.Automation
{
	public partial class QuotationUtil
	{
		private readonly QuotationService _quotationService = new QuotationService();

		public async Task GetAllQuotations(SLConnection serviceLayer)
		{
			Common.logger.Trace("Begin method GetAllQuotations().");
			var list = await serviceLayer.Request(QuotationRequest.ACTION).GetAllAsync<Quotation>();

			if (list == null || list.Count == 0) {
				Common.logger.Warn("List is empty.");
				return;
			}
			else {
				_quotationService.TruncateTable();

				foreach (var v in list) {
					try {
						_quotationService.Insert(Common._mapper.ToSql(v));
					}

					catch (Exception ex) {
						#region Log
						if (ex.InnerException == null)
							Common.logger.Warn("{0}{2}Exception thrown running _service.Insert(Common._mapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
						else
							throw;
						#endregion
					}
				}
			}
		}
	}
}
