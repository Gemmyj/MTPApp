using System;
using System.Collections.Generic;
using System.Text;

namespace MtpApp.Core
{
    public static class GemService
    {
        public static string NameService { get; set; }
        public static double PI { get { return 3.14; } }
        public static string GetServiceName()
        {
            return "I'm Gem";
        }

        public static void SetServiceName(string name)
        {
            
        }
    }
}
