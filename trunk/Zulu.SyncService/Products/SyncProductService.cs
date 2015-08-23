using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.SyncModel.Products;
using MonoCross.Utilities.Serialization;
using System.Configuration;

namespace Zulu.SyncService.Products
{
	public partial class SyncProductService
	{

		public static void GetSyncProductFromFile(string fileLocation)
		{
			string key = SyncKey;
			byte[] salt = Convert.FromBase64String(SyncSalt);
			ISerializer<ZuluSyncContext> serializer = SerializerFactory.Create<ZuluSyncContext>();

			var prod1 = serializer.DeserializeObjectFromFile(fileLocation, key, salt);
		}

		#region Properties
		/// <summary>
		/// Get the Sync Salt from the configuration file
		/// </summary>
		protected static string SyncSalt
		{
			get
			{
				return ConfigurationManager.AppSettings["SyncSalt"];
			}
		}

		/// <summary>
		/// Get the Sync key from the configuration file
		/// </summary>
		protected static string SyncKey
		{
			get
			{
				return ConfigurationManager.AppSettings["SyncKey"];
			}
		}

		#endregion
	}
}
