﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Example.Persistence
{
    public static class Configurations
    {
        public static string GetString(string key)
        {
            ConfigurationManager configurationManager = new();

            string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName}\\Infrastructure\\API_Example.Persistence";

            configurationManager.SetBasePath(path);

            configurationManager.AddJsonFile("PrivateInformations.json");

            return configurationManager.GetSection(key).Value;
        }
    }
}
