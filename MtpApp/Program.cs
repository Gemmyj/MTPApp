using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using MtpApp.Core;
namespace MtpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input 1 :");
            //string s1 = Console.ReadLine();
            //Console.WriteLine("Input 2 :");
            //string s2 = Console.ReadLine();

            //int a = Convert.ToInt32(s1);
            //int b = Convert.ToInt32(s2);

            //Calculator calculator = new Calculator();
            //int c = calculator.Add(a,b);

            //string msg = $"Your Ans : {a} + {b} = {c}";
            //Console.WriteLine(msg);
            //Console.ReadLine();
            //int i = 0;
            //Calculator calculator1 = new Calculator(true);

            //Calculator calculator2 = new Calculator();
            //calculator2.SetAbs(true);
            //while (true)
            //{

            //    string s1 = Console.ReadLine();

            //    if(int.TryParse(s1,out int a))
            //    {
            //        if (i%2 == 0)
            //        {

            //            calculator1.Input(a);
            //        }
            //        else
            //        {
            //            calculator2.Input(a);
            //        }

            //    }
            //    else
            //    {
            //        break;
            //    }
            //    i++;
            //}

            //int c = calculator1.GetResult();
            //int d = calculator2.GetResult();

            //string input1 = String.Join(",",calculator1.GetHistory());
            //string input2 = String.Join(",", calculator2.GetHistory());
            //string msg = $"Your Ans Set 1: {c} , Your Ans Set 2: {d}";
            //Console.WriteLine(input1);
            //Console.WriteLine(input2);
            //Console.WriteLine(msg);
            //Console.ReadLine();

            //User user = new User("name","lastname");
            //user.FirstName = "Gem";
            //user.LastName = "Naja";
            //Console.WriteLine(user.FirstName);
            //Console.WriteLine(user.LastName);
            //Console.WriteLine(user.FullName);
            ////Console.ReadLine();
            //double pi = GemService.PI;
            //Console.WriteLine(pi);

            //CustomerService customerservice = new CustomerService();

            //IEnumerable<Customer> customers = customerservice.GetAllCustomers();

            //foreach (var item in customers)
            //{
            //    Console.WriteLine($"Name:{item.FirstName} LastName :{item.LastName}");

            //}

            //Customer customer = new Customer();
            //customer.FirstName = "Gem";
            //customer.LastName = "Na";
            //customer.Address = "TH";
            //customer.Id = 0;
            //customerservice.CreateCustomer(customer);

            //PrintfCustomer();
            //Customer customer2 = new Customer() { FirstName = "Aun", LastName = "Ja", Id = 0,Address = "TH" };
            //customerservice.CreateCustomer(customer2);
            //PrintfCustomer();

            //Customer customer4 = new Customer() { FirstName = "Aunnz", LastName = "Jaa", Id = 3, Address = "TH3" };
            //customerservice.UpdateCustomer(customer4);
            //PrintfCustomer();
            //customerservice.DeleteCustomer(4);
            //PrintfCustomer();
            //Customer customer3 = customerservice.FindCustomerById(0);




            //if (customer3 == null)
            //{
            //    Console.WriteLine("No User");
            //}
            //else
            //{
            //    Console.WriteLine($"Name : {customer3.FirstName} LastName:{customer3.LastName} ID {customer3.Id}");
            //}

            ////string msg = GemService.GetServiceName();

            //Console.ReadLine();

            //MtpUser mtpuser = new MtpUser();
            ////Customer customer = (Customer)mtpuser;
            //mtpuser.Print();
            //CustomerService customerService = new CustomerService();
            //customerService.CreateCustomer(mtpuser);
            CustomerService customerService = new CustomerService();
            IPrinter printer = new PrinterNameMenu(customerService);
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
