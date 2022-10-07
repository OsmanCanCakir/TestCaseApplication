using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases.Persistence
{
    static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                
                configurationManager.SetBasePath(Path.Combine(@"C:\Users\Osman Can\source\repos\TestCases\TestCases.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("Postgres");
            }
        }
    }
}