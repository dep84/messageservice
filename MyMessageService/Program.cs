using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MyMessageService.Repository;
using MyMessageService.Model;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace MyMessageService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TableStorageSettings tableStorageSettings = new TableStorageSettings();
            MessageServiceRepository repository = new MessageServiceRepository(tableStorageSettings);
            
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
