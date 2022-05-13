using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario2_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Name = "";
            Console.WriteLine(product.Name);
            Console.Read();
        }
    }
    public class Product
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(Name);
                }
                else
                {
                    name = value;
                }
            }
        }
    }
}
