using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scenario3_1
{
    class Program
    {

        static void Main(string[] args)
        {
            int[,] ArrayOfNumbers = new int[,]
            {
                { 5, 3, 6, 7, 8 },
                { 3, 6, 7, 8, 9 },
                { 1, 4, 6, 7, 9 },
                { 2, 1, 7, 9, 22 },
            };

            for (int i = 0; i < ArrayOfNumbers.GetLength(0); i++)
            {
                Console.WriteLine("test {0}, {1}", i, FindMax(i, ArrayOfNumbers));
            }

            //Console.WriteLine("hoi");
            Console.Read();
        }

        static int FindMax (int row, int[,] row2)
        {

            return 0;
        }
    }
}
