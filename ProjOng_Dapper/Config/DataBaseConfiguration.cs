using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjOng_Dapper.Config
{
    public class DataBaseConfiguration
    {
        public static IConfigurationRoot Configuration { get; set; }
        //responsável por captar a string de conexão
        public static string Get()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();
            string _conn = Configuration["ConnectionStrings:DefaultConnection"];
            return _conn; //retornando a string de conexão do appsettings.json

        }
    }
}
