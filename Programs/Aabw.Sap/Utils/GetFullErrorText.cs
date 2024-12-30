using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using B1SLayer;

namespace Aabw.Sap
{
	partial class Program
	{
		/// <summary>
		/// Gets all validation errors from SQL.
		/// </summary>
		/// <param name="ex">The DbEntityValidationException.</param>
		static string GetFullErrorText(DbEntityValidationException ex)
		{
			var msg = string.Empty;
			var list = new List<DbValidationError>();

			foreach (var er in ex.EntityValidationErrors)
				list.AddRange(er.ValidationErrors);

			var temp = list.Select(x => new { x.PropertyName, x.ErrorMessage }).Distinct().ToList();

			foreach (var er in temp)
				msg = $"{msg}Property: {er.PropertyName} Error: {er.ErrorMessage}{Environment.NewLine}";

			return $"{msg}{Environment.NewLine}";
		}

		/// <summary>
		/// Gets a standardized error message for an Exception.
		/// </summary>
		/// <param name="ex">The Exception.</param>
		/// <param name="additionalInfo">Any additional info you want to inject into the returned message.</param>
		static string GetFullErrorText(Exception ex, string additionalInfo)
		{
			var additionalLine = String.IsNullOrWhiteSpace(additionalInfo) ? string.Empty
																		   : $"{additionalInfo}{Environment.NewLine}{Environment.NewLine}";
			if (ex is SLException)
				return $"{additionalLine}{ex.Message}";
			if (ex is DbEntityValidationException dbEx)
				return $"{GetFullErrorText(dbEx)}{additionalLine}";

			if (ex.InnerException == null) {
				var temp = ex.ToString().Length > 1000 ? ex.ToString().Substring(0, 1000)
													   : ex.ToString();

				var msg = $"{ex.Message}{Environment.NewLine}{Environment.NewLine}";
					msg = $"{msg}{additionalLine}";
				return $"{msg}{temp}{Environment.NewLine}{Environment.NewLine}";
			}

			return GetFullErrorText(ex.InnerException, additionalInfo);
		}
	}
}