using System.Collections.Generic;
using System.Linq;
using Sql2023.WwwSPs.Domain;

namespace Sql2023.WwwSPs.Services.TradingAccounts
{
	/// <summary>
	/// TradingAccount service
	/// </summary>
	public partial class TradingAccountService : BaseService, ITradingAccountService
	{
		/// <inheritdoc/>
		public virtual IList<TradingAccount> GetAll()
		{
			return (from x in _dbContext.TradingAccounts
					select x).ToList();
		}
	}
}