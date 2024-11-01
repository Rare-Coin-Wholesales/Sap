using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.BusinessPartners;

namespace Sap.Api
{
	public partial class ServiceLayer : SLConnection
	{
		protected async Task<BusinessPartner> CreateAsync(BusinessPartner x)
		{
			var created = await Request("BusinessPartners").PostAsync<BusinessPartner>(x);
			return created;
		}

		public async Task DeleteAsync(BusinessPartner x)
		{
			await Request("BusinessPartners", x.CardCode).DeleteAsync();
		}

		public async Task DeleteBusinessPartnerByIdAsync(object id)
		{
			await Request("BusinessPartners", id).DeleteAsync();
		}

		public async Task<IList<BusinessPartner>> GetAllBusinessPartnersAsync()
		{
			var all = await Request("BusinessPartners").GetAllAsync<BusinessPartner>();
			return all;
		}

		public async Task<BusinessPartner> GetBusinessPartnerAsync(object id)
		{
			var entity = await Request("BusinessPartners", id).GetAsync<BusinessPartner>();
			return entity;
		}

		public void LogToCsv(IList<BusinessPartner> list)
		{
			var log = "CardCode,CardType,CardName\r\n";

			foreach (var v in list)
				log = String.Format($"{log}\"{v.CardCode}\",\"{v.CardType}\",\"{v.CardName}\"{Environment.NewLine}");

			var folder = String.Format("C:/Logs/SAP Automation/{0:yyyy MM}/", DateTime.Now);
			Directory.CreateDirectory(folder);
			File.WriteAllText(String.Format("{0}BusinessPartners {1:dd HHmm ssff}.csv", folder, DateTime.Now), log);
		}

		public async Task PatchAsync(BusinessPartner x)
		{
			x.CreateDate = null;
			x.CreateTime = null;
			x.UpdateDate = null;
			x.UpdateTime = null;
			await Request("BusinessPartners", x.CardCode).PatchAsync(x);
		}

		public async Task<(BusinessPartner, string ErrorMsg)> TryCreateAsync(BusinessPartner x)
		{
			try {
				return (await CreateAsync(x), null);
			}

			catch (Exception ex) {
				return (null, GetErrorMessage(ex));
			}
		}
	}
}