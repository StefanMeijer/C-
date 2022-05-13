using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10.0, 20.0);
            rect.Length = 10.0;
            rect.Width = 20.0;
            double area = rect.GetArea();
            Console.WriteLine("Area of Rectangle: {0}", area);
            Console.Read();
        }
    }
}
