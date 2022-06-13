using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verhuur_van_speedboten
{
    public class Speedboot
    {
        public int nummer { get; set; }
        public double gewicht { get; set; }
        public int pks { get; set; }
        public double lengte { get; set; }
        public double huurprijs { get; set; }
        public Boolean schade { get; set; }

        public Speedboot(int nummer, double gewicht, int pks, double lengte, double huurprijs, Boolean schade)
        {
            this.nummer = nummer;
            this.gewicht = gewicht;
            this.pks = pks;
            this.lengte = lengte;
            this.huurprijs = huurprijs;
            this.schade = schade;
        }
    }
}
