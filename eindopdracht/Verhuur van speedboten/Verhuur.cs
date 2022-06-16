using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verhuur_van_speedboten
{
    public class Verhuur
    {
        public int id { get; set; }
        public int bootnummer { get; set; }
        public DateTime aanvangstijd { get; set; }
        public DateTime eindtijd { get; set; }
        public int verbruikteLiters { get; set; }
        public DateTime verhuurDatum { get; set; }

        public Verhuur (int id, int bootnummer, DateTime aanvangstijd, DateTime eindtijd, int verbruikteLiters, DateTime verhuurDatum)
        {
            this.id = id;
            this.bootnummer = bootnummer;   
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
