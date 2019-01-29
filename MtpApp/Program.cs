using System;
using MtpApp.Core;
namespace MtpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 1 :");
            string s1 = Console.ReadLine();
            Console.WriteLine("Input 2 :");
            string s2 = Console.ReadLine();

            int a = Convert.ToInt32(s1);
            int b = Convert.ToInt32(s2);

            Calculator calculator = new Calculator();
            int c = calculator.Add(a,b);

            string msg = $"Your Ans : {a} + {b} = {c}";
            Console.WriteLine(msg);
            Console.ReadLine();
        }
    }


}
