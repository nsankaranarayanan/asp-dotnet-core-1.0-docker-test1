﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
 
namespace ASPDotNet5.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                //.UseUrls(Environment.GetEnvironmentVariable("ASPNETCORE_SERVER.URLS") ?? String.Empty)
                .UseUrls("http://0.0.0.0:5001", "http://0.0.0.0:5002")
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
