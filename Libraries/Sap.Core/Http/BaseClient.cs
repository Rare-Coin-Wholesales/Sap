using System;
using System.Net;
using System.Net.Http;

namespace Sap.Core.Http
{
	/// <summary>
	/// Container for thread-safe, singleton <see cref="HttpClient"/>.
	/// </summary>
	/// <reference>https://www.red-gate.com/simple-talk/development/dotnet-development/working-with-the-httpclient-class/</reference>
	public abstract class BaseClient : IDisposable
	{
		private static object _locker = new object();
		private static volatile HttpClient _client;

		protected static HttpClient Client
		{
			get {
				if (_client == null) {
					lock (_locker) {
						if (_client == null) {
							try {
								ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls13 | SecurityProtocolType.Tls12;
								ServicePointManager.SecurityProtocol &= ~SecurityProtocolType.Tls11;
							}

							catch (NotSupportedException) {
								ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11;
							}

							ServicePointManager.SecurityProtocol &= ~SecurityProtocolType.Tls;
							_client = new HttpClient();
						}
					}
				}

				return _client;
			}
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		public virtual void Dispose(bool disposing)
		{
			if (disposing) {
				if (_client != null)
					_client.Dispose();

				_client = null;
			}
		}
	}
}