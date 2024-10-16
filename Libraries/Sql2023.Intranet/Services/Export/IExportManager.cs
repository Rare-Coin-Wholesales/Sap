using System.Collections.Generic;
using Sql2023.Intranet.Domain;

namespace Sql2023.Intranet.Services.Export
{
	/// <summary>
	/// Export manager interface
	/// </summary>
	public partial interface IExportManager
	{
		/// <summary>
		/// Exports Coin IDs to CSV.
		/// </summary>
		/// <param name="list">The list of Coin IDs.</param>
		/// <returns>Result in CSV (string) format</returns>
		void ExportCoinIdsToCsv(IList<int> list);
		/// <summary>
		/// Exports <see cref="Inventory"/> to CSV.
		/// </summary>
		/// <param name="list">The list of <see cref="Inventory"/>.</param>
		/// <returns>Result in CSV (string) format</returns>
		void ExportToCsv(IList<Inventory> list);
		/// <summary>
		/// Exports <see cref="Invoice"/>s to CSV.
		/// </summary>
		/// <param name="list">The list of <see cref="Invoice"/>s.</param>
		/// <returns>Result in CSV (string) format</returns>
		void ExportToCsv(IList<Invoice> list);
		/// <summary>
		/// Exports <see cref="Order"/>s to CSV.
		/// </summary>
		/// <param name="list">The list of <see cref="Order"/>s.</param>
		/// <returns>Result in CSV (string) format</returns>
		void ExportToCsv(IList<Order> list);
		/// <summary>
		/// Exports <see cref="UnixCustomer"/>s to CSV.
		/// </summary>
		/// <param name="list">The list of <see cref="UnixCustomer"/>s.</param>
		/// <returns>Result in CSV (string) format</returns>
		void ExportToCsv(IList<UnixCustomer> list);
		/// <summary>
		/// Writes data to a CSV file.
		/// </summary>
		/// <param name="data">The data to write.</param>
		/// <param name="entityName">The entity name that's used for the filename.</param>
		void WriteToCsvFile(string data, string entityName);
		/// <summary>
		/// Writes data to a LOG file.
		/// </summary>
		/// <param name="data">The data to write.</param>
		/// <param name="entityName">The entity name that's used for the filename.</param>
		void WriteToFile(string data, string entityName);
	}
}