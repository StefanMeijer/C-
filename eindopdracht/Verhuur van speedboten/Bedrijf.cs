//Stefan Meijer
//16-6-2022
//0.1
//Een bedrijf verhuurt speedboten. Voor één bepaalde dag wordt elk van de tien aanwezige speedboten hoogstens 1 keer verhuurd. 
//Rob Loves

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verhuur_van_speedboten
{
    public class Bedrijf
    {
        public String naam { get; set; }
        public List<Speedboot> speedboten { get; set; }
        public List<Verhuur> verhuurden { get; set; }

        public Bedrijf ()
        {
            this.speedboten = new List<Speedboot>();
            this.verhuurden = new List<Verhuur>();

            this.naam = getCompanyName();

            loadSpeedboten();
            loadVerhuurden();
        }

        public double totaleOmzet ()
        {
            //Loop over alle, tel alle omzet op in één variabele en laat die zien
            double total = 0.0;

            foreach (Verhuur verhuurden in this.verhuurden)
            {
                double omzet = total + verhuurden.berekenOmzet();
                total = omzet;
            }

            return total;
        }

        public TimeSpan totaleVerhuurtijd ()
        {
            //Loop over alle, tel alle verhuurtijd op in één variabele en laat die zien
            double totaleVerhuurtijd = 0.0;

            foreach (Verhuur verhuurden in this.verhuurden)
            {
                double verhuurtijd = totaleVerhuurtijd + verhuurden.berekenVerhuurtijd();
                totaleVerhuurtijd = verhuurtijd;
            }

            TimeSpan ts = TimeSpan.FromMinutes(totaleVerhuurtijd);

            return ts;
        }

        public int hoogsteBrandstofVerbruik ()
        {
            //Loop over alle, zet de gene met hoogste double in een variabele, zet die boot nummer in een variabele
            int bootnummer = 0;
            double oldBrandstofverbruik = 0.0;

            foreach (Verhuur verhuurden in this.verhuurden)
            {
                double brandstofverbruik = verhuurden.berekenBrandstofverbruik();
                if (brandstofverbruik > oldBrandstofverbruik)
                {
                    oldBrandstofverbruik = brandstofverbruik;
                    bootnummer = verhuurden.bootnummer;
                }
            }
            return bootnummer;
        }

        public double percentageSchadeBoten () {
            //Loop over alle, gebruikt .count functie op de list & zet alle boten die schade hebben ook in een int
            //Vervolgens kun je percentage berekenen 100 : Het aantal boten x de boten met scahde
            int totaleSpeedboten = this.speedboten.Count();
            int totaleSchadeBoten = 0;

            foreach (Speedboot speedboten in this.speedboten)
            {
                if (speedboten.schade == true)
                {
                    totaleSchadeBoten++;
                }
            }

            double berekening = 100 / totaleSpeedboten * totaleSchadeBoten;
            return berekening;
        }

        public Speedboot korsteVerhuurd ()
        {
            //Loop over alle, zet de gene met laagste double in een variabele, zet die boot nummer in een variabele
            //Loop over alle speedboten, return de speedboot met hetzelfde nummer die opgeslagen staat
            Speedboot korsteVerhuurd = null;
            double verhuurtijd = 0.0;

            foreach (Verhuur verhuurden in this.verhuurden)
            {
                if (verhuurtijd == 0.0)
                {
                    verhuurtijd = verhuurden.berekenVerhuurtijd();
                    int speedbootnummmer = verhuurden.bootnummer;

                    foreach (Speedboot speedboten in this.speedboten)
                    {
                        if (speedboten.nummer == speedbootnummmer)
                        {
                            korsteVerhuurd = speedboten;
                        }
                    }

                } else
                {
                    if (verhuurden.berekenVerhuurtijd() < verhuurtijd)
                    {
                        verhuurtijd = verhuurden.berekenVerhuurtijd();
                        int speedbootnummmer = verhuurden.bootnummer;

                        foreach (Speedboot speedboten in this.speedboten)
                        {
                            if (speedboten.nummer == speedbootnummmer)
                            {
                                korsteVerhuurd = speedboten;
                            }
                        }
                    }
                }
                
            }

            return korsteVerhuurd;
        }

        private void loadSpeedboten()
        {
            string query = @"SELECT nummer, gewicht, pks, lengte, huurprijs, schade FROM speedboot";

            SqlDataReader dr = new SqlCommand(query, Database.openSqlConn()).ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    //Get boolean value from databsae
                    Boolean schade = false;
                    if (dr.GetValue(5).ToString() == "1")
                    {
                        schade = true;
                    }
                    
                    //Making speedboot object
                    Speedboot speedboot = new Speedboot(
                        int.Parse(dr.GetValue(0).ToString()),
                        double.Parse(dr.GetValue(1).ToString()),
                        int.Parse(dr.GetValue(2).ToString()),
                        double.Parse(dr.GetValue(3).ToString()),
                        double.Parse(dr.GetValue(4).ToString()),
                        schade
                    );

                    //Adding speedboten to list of speedboten
                    this.speedboten.Add(speedboot);
                }
            }
            else
            {
                MessageBox.Show("Geen speedboten gevonden!");
            }

            dr.Close();
        }

        private void loadVerhuurden()
        {
            string query = @"SELECT id, boot, aanvangstijd, eindtijd, verbruikteliters, verhuurdatum FROM verhuur";
            
            SqlDataReader dr = new SqlCommand(query, Database.openSqlConn()).ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    
                    //Making verhuur object
                    Verhuur verhuur = new Verhuur(
                        int.Parse(dr.GetValue(0).ToString()),
                        int.Parse(dr.GetValue(1).ToString()),
                        DateTime.Parse(dr.GetValue(2).ToString()),
                        DateTime.Parse(dr.GetValue(3).ToString()),
                        int.Parse(dr.GetValue(4).ToString()),
                        DateTime.Parse(dr.GetValue(5).ToString())
                    );

                    //Adding verhuurden to list of verhuurden
                    this.verhuurden.Add(verhuur);
                }
            }
            else
            {
                MessageBox.Show("Geen verhuurders gevonden!");
            }

            dr.Close();
        }

        private string getCompanyName ()
        {
            string query = @"SELECT bedrijfsnaam FROM bedrijf";

            SqlDataReader dr = new SqlCommand(query, Database.openSqlConn()).ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    return dr.GetValue(0).ToString();
                }
            }
            else
            {
                MessageBox.Show("Geen bedrijf gevonden");
            }

            return "";
        }
    }
}
