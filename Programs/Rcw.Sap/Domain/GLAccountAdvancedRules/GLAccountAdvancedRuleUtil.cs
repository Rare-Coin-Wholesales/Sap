using System;
using System.Threading.Tasks;
using Sap.Api.Domain.GLAccountAdvancedRules;
using ScarletWitch.Sap_RareCoinWholesalers.Services.GLAccountAdvancedRules;

namespace Rcw.Sap
{
	public partial class GLAccountAdvancedRuleUtil
	{
		private readonly GLAccountAdvancedRuleService _gLAccountAdvancedRuleService = new GLAccountAdvancedRuleService();

		public async Task GetAllGLAccountAdvancedRules()
		{
			Program.nLog.Trace("Begin method GetAllGLAccountAdvancedRules().");
			var list = await Program._serviceLayer.Request(GLAccountAdvancedRuleRequest.ACTION).GetAllAsync<GLAccountAdvancedRule>();

			if (list == null || list.Count == 0) {
				Program.nLog.Warn("List is empty.");
				return;
			}
			else {
				_gLAccountAdvancedRuleService.TruncateTable();

				foreach (var v in list) {
					try {
						_gLAccountAdvancedRuleService.Insert(Program._mapper.ToSql(v));
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
