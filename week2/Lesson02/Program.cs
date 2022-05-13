using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Rectangle
    {
        private double length;
        private double width;

        static void Main(string[] args)
        {
        }

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public double GetArea()
        {
            return length * width;
        }

        public void InitFields(double l, double w)
        {
            length = l;
            width = w;
        }
    }
}
