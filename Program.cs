using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Crews.Controllers;

namespace Crews
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserController userController = new UserController();

            CreateHostBuilder(args).Build().Run();

            Console.WriteLine("testing");

            switch (args[0])
            {
                case "adduser":
                    userController.addUser(args[1]);
                    break;

                case "listusers":
                    Console.WriteLine(userController.listUsers());
                    break;
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
