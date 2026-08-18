using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using B1SLayer;

namespace Rcw.Sap
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

			var msg = $"{additionalLine}Exception type: {ex.GetType().FullName}{Environment.NewLine}";
			msg = $"{msg}Message: {ex.Message}{Environment.NewLine}";
			msg = $"{msg}Source: {ex.Source}{Environment.NewLine}";
			msg = $"{msg}HResult: {ex.HResult}{Environment.NewLine}";
			msg = $"{msg}TargetSite: {ex.TargetSite}{Environment.NewLine}";
			msg = $"{msg}StackTrace:{Environment.NewLine}{ex.StackTrace}{Environment.NewLine}{Environment.NewLine}";
			if (ex.InnerException == null)
				return msg;

			return $"{msg}Inner Exception:{Environment.NewLine}{GetFullErrorText(ex.InnerException, null)}";
		}
	}
}