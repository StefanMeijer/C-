using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calcDiscount(101);
        }

        public static void calcDiscount(int quantity)
        {
            int discout = 0;

            if (quantity < 10)
            {
                discout = 5;
                
            }
            else if (quantity < 50)
            {
                discout = 10;
            }
            else if (quantity < 100)
            {
                discout = 15;
            }
            else
            {
                discout = 15;
            }
            Console.WriteLine(discout);
            Console.Read();
        }
    }
}
