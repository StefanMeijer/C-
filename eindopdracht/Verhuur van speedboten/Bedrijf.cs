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
            this.naam = "database naam";

            loadSpeedboten();
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
    }
}
