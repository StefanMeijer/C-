using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            //Get all data from boot with bootnummer = bootnummer
            double omzet = 0.0;

            string query = @"SELECT * FROM Speedboot";

            SqlDataReader dr = new SqlCommand(query, Database.openSqlConn()).ExecuteReader();

            while (dr.Read())
            {
                //Check if bootnummer from db is the same as this bootnummer
                if (int.Parse(dr.GetValue(0).ToString()) == this.bootnummer)
                {
                    double huurprijs = double.Parse(dr.GetValue(4).ToString());

                    omzet = huurprijs + (this.verbruikteLiters * 5);
                    break;
                }
            }
            
            return omzet;
        }

        public double berekenBrandstofverbruik ()
        {
            //Brandstof verbruik = liters delen door totaal aantal minuten
            return this.verbruikteLiters / this.berekenVerhuurtijd();
        }

        public double berekenVerhuurtijd ()
        {
            //Totale verhuurtijd = tijdspanne tussen begin en eindtijd
            TimeSpan tijdspan = this.eindtijd.Subtract(this.aanvangstijd);

            //Geef tijdspanne terug in aantal minuten
            return tijdspan.TotalMinutes;
        }
    }
}
