using System.Collections.Generic;
using Sql2023.Intranet.Domain;

namespace Sql2023.Intranet.Services.CompanyNamePartials
{
	/// <summary>
	/// CompanyNamePartial service interface
	/// </summary>
	public partial interface ICompanyNamePartialService
	{
		/// <summary>
		/// Determines whether the name contains a <see cref="CompanyNamePartial"/> or not.
		/// </summary>
		/// <param name="name">The name.</param>
		/// <returns>True if it does. False otherwise.</returns>
		bool ContainsPartial(string name);
		/// <summary>
		/// Gets all <see cref="CompanyNamePartial"/>s.
		/// </summary>
		/// <returns>An <see cref="IList{T}"/> of <see cref="CompanyNamePartial"/>s.</returns>
		IList<string> GetAll();
	}
}