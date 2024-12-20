using System.Collections.Generic;
using Sap.Api.Domain.BusinessPartners;
using Sap.Core;
using Web202209.SAP_RareCoinWholesalers.Services.BusinessPartners;

namespace Rcw.Sap
{
	public partial class BusinessPartnerUtil
	{
		private readonly IContactEmployeeService _contactEmployeeService = new ContactEmployeeService();

		private void InsertContactEmployee(IList<BusinessPartner> list)
		{
			var docLines = new List<ContactEmployee>();

			foreach (var v in list)
				docLines.AddRange(v.ContactEmployees);

			var dt = CommonUtil.ToDataTable(docLines);
			_contactEmployeeService.TruncateTable();

			if (!_contactEmployeeService.TryBulkCopy(dt, out var errorMsg))
				Program.nLog.Error(errorMsg);
		}
	}
}