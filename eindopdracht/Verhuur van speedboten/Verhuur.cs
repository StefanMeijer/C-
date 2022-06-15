using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verhuur_van_speedboten
{
    public class Verhuur
    {
        public Speedboot boot { get; set; }
        public DateTime aanvangstijd { get; set; }
        public DateTime eindtijd { get; set; }
        public int verbruikteLiters { get; set; }
        public DateTime verhuurDatum { get; set; }

        public Verhuur (Speedboot boot, DateTime aanvangstijd, DateTime eindtijd, int verbruikteLiters, DateTime verhuurDatum)
        {
            this.boot = boot;   
            this.aanvangstijd = aanvangstijd;
            this.eindtijd = eindtijd;   
            this.verbruikteLiters = verbruikteLiters;
            this.verhuurDatum = verhuurDatum;
        }

        public double berekenOmzet ()
        {
            return 0.0;
        }

        public double berekenBrandstofverbruik ()
        {
            return 0.0;
        }

        public DateTime berekenVerhuurtijd ()
        {
            return DateTime.Now;
        }
    }
}
