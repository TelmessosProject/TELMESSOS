using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TELMESSOS.CORE.Helper
{
	public static class ConnectionHelper
	{
		public static string GetConnectionString(string connectionName)
		{
			var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
			   .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

			var Configuration = builder.Build();

			var connStr = Configuration.GetConnectionString(connectionName);
			//var connStr = Configuration["IsEncrypted"];

			return connStr;
		}
		//public static string SetConnectionString(string connectionString, string connectionValue)
		//{
		//	var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
		//	   .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

		//	var Configuration = builder.Build();

		//	Configuration.

		//	return connStr;
		//}
		//TODO im here!
	}
}
