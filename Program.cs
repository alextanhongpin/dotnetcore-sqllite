using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using DBService.Models;

namespace DBService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // BuildWebHost(args).Run();

            using (var db = new BloggingContext()) 
            {
                db.Blogs.Add(new Blog { Url = "http://localhost.com" });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to the database.", count);

                foreach (var blogs in db.Blogs) {
                    Console.WriteLine(" - {0}", blogs.Url);
                }
            }
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
