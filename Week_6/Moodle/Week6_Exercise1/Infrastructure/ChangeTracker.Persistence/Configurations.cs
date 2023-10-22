using Microsoft.Extensions.Configuration;

namespace ChangeTracker.Persistance
{
    public static class Configurations
    {
        public static string GetString(string key)
        {
            ConfigurationManager configurationManager = new();

            string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName}\\Infrastructure\\ChangeTracker.Persistence";

            configurationManager.SetBasePath(path);

            configurationManager.AddJsonFile("private.json");

            return configurationManager.GetSection(key).Value;


        }

    }
}