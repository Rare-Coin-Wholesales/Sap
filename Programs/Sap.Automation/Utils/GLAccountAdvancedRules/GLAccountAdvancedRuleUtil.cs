using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.GLAccountAdvancedRules;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.GLAccountAdvancedRules;

namespace Sap.Automation
{
	public partial class GLAccountAdvancedRuleUtil
	{
		private readonly GLAccountAdvancedRuleService _gLAccountAdvancedRuleService = new GLAccountAdvancedRuleService();

		public async Task GetAllGLAccountAdvancedRules(SLConnection serviceLayer)
		{
			Common.logger.Trace("Begin method GetAllGLAccountAdvancedRules().");
			var list = await serviceLayer.Request(GLAccountAdvancedRuleRequest.ACTION).GetAllAsync<GLAccountAdvancedRule>();

			if (list == null || list.Count == 0) {
				Common.logger.Warn("List is empty.");
				return;
			}
			else {
				_gLAccountAdvancedRuleService.TruncateTable();

				foreach (var v in list) {
					try {
						_gLAccountAdvancedRuleService.Insert(Common._mapper.ToSql(v));
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
