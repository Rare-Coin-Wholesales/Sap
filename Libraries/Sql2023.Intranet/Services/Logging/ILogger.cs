using Sql2023.Intranet.Domain.Logging;

namespace Sql2023.Intranet.Services.Logging
{
	/// <summary>
	/// Logger interface
	/// </summary>
	public partial interface ILogger
	{
		/// <summary>
		/// Checks to see if a <see cref="Log"/> exists or not. Returns true if so, otherwise false.
		/// </summary>
		/// <param name="log">The <see cref="Log"/> to check.</param>
		bool Exists(Log log);

		/// <summary>
		/// Gets the count of how many of the same <see cref="Log"/>s exist in the table already.
		/// </summary>
		/// <param name="log">The <see cref="Log"/> to check for.</param>
		int GetCount(Log log);

		/// <summary>
		/// Inserts a log item
		/// </summary>
		/// <param name="logLevel">Log level</param>
		/// <param name="shortMessage">The short message</param>
		/// <param name="fullMessage">The full message</param>
		/// <param name="customer">The customer to associate log record with</param>
		/// <returns>A log item</returns>
		Log Insert(Log log);

		/// <summary>
		/// Inserts a log item
		/// </summary>
		/// <param name="logLevel">Log level</param>
		/// <param name="shortMessage">The short message</param>
		/// <param name="fullMessage">The full message</param>
		/// <param name="customer">The customer to associate log record with</param>
		/// <returns>A log item</returns>
		Log Insert(LogLevel logLevel, string shortMessage, string fullMessage = "", int? customerId = null);

		/// <summary>
		/// Tries to validate a <see cref="Log"/>. If valid, returns true. Else return false with all error messages contained in 'errorMsg'.
		/// Note that this method applies default values as well as formatting.
		/// </summary>
		/// <param name="log">The <see cref="Log"/> to validate.</param>
		/// <param name="errorMsg">Any error messages, else string.empty.</param>
		bool TryValidate(Log log, out string errorMsg);
	}
}