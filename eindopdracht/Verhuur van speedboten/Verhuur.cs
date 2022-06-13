using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verhuur_van_speedboten
{
    public class Verhuur
    {
        Speedboot boot { get; set; }
        DateTime aanvangstijd { get; set; } 
        DateTime eindtijd { get; set; } 
        int verbruikteLiters { get; set; }

        public Verhuur (Speedboot boot, DateTime aanvangstijd, DateTime eindtijd, int verbruikteLiters)
        {
            this.boot = boot;   
            this.aanvangstijd = aanvangstijd;
            this.eindtijd = eindtijd;   
            this.verbruikteLiters = verbruikteLiters;
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
