using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verhuur_van_speedboten
{
    public class Dagverhuur
    {
        public DateTime datum { get; set; }
        public Verhuur[] verhuurdeBoten { get; set; }

        public Dagverhuur ()
        {
            this.verhuurdeBoten = new Verhuur[9];
        }
    }
}
