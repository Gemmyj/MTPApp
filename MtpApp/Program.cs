using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using MtpApp.Core;
using MtpApp.Entity;
using MtpApp.DataAccess;
using MtpApp.Core.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MtpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var services = new ServiceCollection();

            services.AddDbContext<MTPDataContext>(opt => opt.UseSqlServer(@"Data Source=27.254.174.191;Initial Catalog=admin_mtp;Persist Security Info=True;User ID=admin_mtp;Password=Sinetong9977"));
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IPrinter, PrinterNameMenu>();



          
            var serviceProvider = services.BuildServiceProvider();

            //var ctx = serviceProvider.GetService<MTPDataContext>();
            //ctx.Database.EnsureCreated();
            var printer = serviceProvider.GetRequiredService<IPrinter>();
            printer.StartUI();
            
           

        }

        public static void PrintfCustomer()
        {
           
            CustomerService customerservice = new CustomerService();

            IEnumerable<Customer> customers1 = customerservice.GetAllCustomers();
            foreach (var item in customers1)
            {
                Console.WriteLine($"ID {item.Id}Name:{item.FirstName} LastName :{item.LastName} Address : {item.Address}");

            }
            Console.ReadLine();
        }

        static string PrintResult(List<int> l)
        {
            string resultmsg = string.Empty;

            foreach (var item in l)
            {
                
            }

            return resultmsg;
        }
    }



}
