using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.GLAccountAdvancedRules;
using Sap.Automation;
using ScarletWitch.Sap_RareCoinWholesalers.Services.GLAccountAdvancedRules;

namespace Sap.Rcw.Automation
{
	public partial class GLAccountAdvancedRuleUtil
	{
		private readonly GLAccountAdvancedRuleService _gLAccountAdvancedRuleService = new GLAccountAdvancedRuleService();

		public async Task GetAllGLAccountAdvancedRules(SLConnection serviceLayer)
		{
			Common.nLog.Trace("Begin method GetAllGLAccountAdvancedRules().");
			var list = await serviceLayer.Request(GLAccountAdvancedRuleRequest.ACTION).GetAllAsync<GLAccountAdvancedRule>();

			if (list == null || list.Count == 0) {
				Common.nLog.Warn("List is empty.");
				return;
			}
			else {
				_gLAccountAdvancedRuleService.TruncateTable();

				foreach (var v in list) {
					try {
						_gLAccountAdvancedRuleService.Insert(Common._rcwMapper.ToSql(v));
					}

					catch (Exception ex) {
						#region Log
						if (ex.InnerException == null)
							Common.nLog.Warn("{0}{2}Exception thrown running _service.Insert(Common._rcwMapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
						else
							throw;
						#endregion
					}
				}
			}
		}
	}
}
