using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.BusinessPartners;

namespace Sap.Api.Services
{
	public partial class BusinessPartnerService : BaseService
	{
		public const string ACTION = "BusinessPartners";

		public BusinessPartnerService(SLConnection ServiceLayer) : base(ServiceLayer) { }

		/// <summary>
		/// Creates a <see cref="BusinessPartner"/>.
		/// </summary>
		/// <param name="x">The <see cref="BusinessPartner"/> to create.</param>
		/// <returns>The created <see cref="BusinessPartner"/>.</returns>
		public async Task<BusinessPartner> CreateAsync(BusinessPartner x)
		{
			var created = await ServiceLayer.Request(ACTION).PostAsync<BusinessPartner>(x);
			return created;
		}

		public async Task<IList<BusinessPartner>> GetAll()
		{
			try {
				var list = await ServiceLayer.Request(ACTION).GetAllAsync<BusinessPartner>();
				return list;
			}

			catch (Exception ex) {
				#region Handle exception
				var msg = GetFullErrorText(ex, "BusinessPartnerService.GetAll()");

				if (String.IsNullOrWhiteSpace(msg))
					throw;
				else
					throw new Exception(msg);
				#endregion
			}
		}

		public async Task<BusinessPartner> GetByCardCode(string cardCode)
		{
			try {
				var x = await ServiceLayer.Request(ACTION, cardCode).GetAsync<BusinessPartner>();
				return x;
			}

			catch (Exception ex) {
				#region Handle exception
				var msg = GetFullErrorText(ex, "BusinessPartnerService.GetByCardCode(string cardCode)");

				if (String.IsNullOrWhiteSpace(msg))
					throw;
				else
					throw new Exception(msg);
				#endregion
			}
		}

		/// <summary>
		/// Tries to create a <see cref="BusinessPartner"/>. On error, any messages will be held in errorMsg.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public async Task<(BusinessPartner, string errorMsg)> TryCreate(BusinessPartner x)
		{
			var errorMsg = string.Empty;

			try {
				return (await CreateAsync(x), errorMsg);
			}

			catch (Exception ex) {
				errorMsg = $"{errorMsg}{ex.Message}{Environment.NewLine}";
				errorMsg = $"{errorMsg}Exception thrown in BusinessPartnerService.TryCreate(BusinessPartner x).{Environment.NewLine}";
				errorMsg = $"{errorMsg}{ex}{Environment.NewLine}";
				return (null, errorMsg);
			}
		}

		public async void UpdateAsync(BusinessPartner x)
		{
			try {
				await ServiceLayer.Request(ACTION, x.CardCode).PatchAsync(x);
			}

			catch (Exception ex) {
				#region Handle exception
				var msg = GetFullErrorText(ex, "BusinessPartnerService.UpdateAsync(BusinessPartner x)");

				if (String.IsNullOrWhiteSpace(msg))
					throw;
				else
					throw new Exception(msg);
				#endregion
			}
		}
	}
}