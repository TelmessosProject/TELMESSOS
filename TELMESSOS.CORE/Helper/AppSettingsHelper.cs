using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TELMESSOS.CORE.Helper
{
	public static class AppSettingsHelper
	{
		public static string GetValue(string key)
		{
			var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
			   .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

			var Configuration = builder.Build();

			
			var connStr = Configuration[key];

			return connStr;
		}
		public static bool EncryptConnectionString()
		{
			try
			{
				var connectionString = ConnectionHelper.GetConnectionString("TelmessosConnection");
				var is_encrypt = GetValue("IsEncrypted");

				if (!Convert.ToBoolean(is_encrypt))
				{
					CryptoHelper.Encrypt(connectionString, CryptoHelper.Message);

				}
				return true;
			}
			catch (Exception e)
			{

				return false;
			}
			

		}
		public static bool DencryptConnectionString() { 
		}
	}
}
