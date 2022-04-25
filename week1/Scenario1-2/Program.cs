using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario1_2
{
    internal class Program
    {
        private static int fact = 1;

        static void Main(string[] args)
        {
            Console.WriteLine(libary(4));
            Console.Read();
        }

       public static int libary(int n)
       {
            if (n > 1)
            {
                fact = fact * n;
                return n = libary(n - 1);
            } 
            else
            {
                return fact;
            }
       }
    }
}
