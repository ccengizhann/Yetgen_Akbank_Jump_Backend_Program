using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPal.Persistence
{
	public class Configurations
	{
		public static string GetString(string key)
		{
			ConfigurationManager configurationManager = new();

			string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName}\\Infrastructure\\PathPal.Persistence";
			


			configurationManager.SetBasePath(path);

			configurationManager.AddJsonFile("PrivateInformations.json");

			return configurationManager.GetSection(key).Value;

		}
	}
}
