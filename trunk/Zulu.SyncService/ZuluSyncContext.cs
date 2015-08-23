using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.SyncModel.Products;

namespace Zulu.SyncService
{
	public class ZuluSyncContext
	{
		#region Ctor
		/// <summary>
		/// Creates a new instance of the ZuluContext class
		/// </summary>
		public ZuluSyncContext()
		{
		}
		#endregion

		#region Properties

		/// <summary>
		/// Get and set the properties of Sync Product
		/// </summary>
		public List<SyncProduct> SyncProducts { get; set; }
		#endregion
	}
}
