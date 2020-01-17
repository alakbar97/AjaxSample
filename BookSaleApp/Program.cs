using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookSaleApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BookSaleApp
{
    public class Program
    {

        
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            //using(var scope = host.Services.CreateScope())
            //{
            //   var context= scope.ServiceProvider.GetRequiredService<BookDbContext>();

            //    if (!context.Books.Any())
            //    {
            //        context.Books.AddRange(new Book
            //        {
            //            Name = "Java",
            //            PageCount=300

            //        },
            //        new Book
            //        {
            //            Name="Python",
            //            PageCount=200
            //        });
            //    }
            //}
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
