using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
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
                    User newUser = new User(){Name = args[1]};
                    userController.addUser(newUser);
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
