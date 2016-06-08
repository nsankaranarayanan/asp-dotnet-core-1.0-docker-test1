using System;
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
                .UseUrls("http://0.0.0.0:81", "http://0.0.0.0:82", "http://0.0.0.0:83", "http://0.0.0.0:84", "http://0.0.0.0:85", "http://0.0.0.0:5001", "http://0.0.0.0:5002", "http://0.0.0.0:5003", "http://0.0.0.0:5004", "http://0.0.0.0:5005")
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
