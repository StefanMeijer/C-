using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verhuur_van_speedboten
{
    public class Bedrijf
    {
        String naam { get; set; }
        List<Verhuur> verhuurden { get; set; }

        public Bedrijf ()
        {
            this.naam = "database naam";
        }

        public double totaleOmzet ()
        {
            return 0.0;
        }

        public DateTime totaleVerhuurtijd ()
        {
            DateTime now = DateTime.Now;
            return now;
        }

        public int hoogsteBrandstofVerbruik ()
        {
            return 0;
        }

        public double percentageSchadeBoten () {
            return 0.0;
        }

        public Speedboot korsteVerhuurd ()
        {
            return null;
        }
    }
}
