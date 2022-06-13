using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csv
{
    internal class Student
    {
        public String nr { get; set; }
        public String name { get; set; }
        public int age { get; set; }
        
        public Student(String nr, String name, int age)
        {
            this.name = name;
            this.nr = nr;
            this.age = age;
        }

        public String getName ()
        {
            return name;
        }

        public String getNr ()
        {
            return nr;
        }

        public int getAge ()
        {
            return age;
        }

        public override string ToString()
        {
            return nr + " " + name + " " + age;
        }
    }
}
