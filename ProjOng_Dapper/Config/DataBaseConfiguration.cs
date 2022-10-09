﻿using Microsoft.Extensions.Configuration;
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
        public static string Get()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional:true, reloadOnChange:true);

            Configuration = builder.Build();
            return Configuration["ConnectionStrings:DefaultConnection"];
        }
    }
}
