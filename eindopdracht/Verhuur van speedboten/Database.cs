//Stefan Meijer
//16-6-2022
//0.1
//Een bedrijf verhuurt speedboten. Voor één bepaalde dag wordt elk van de tien aanwezige speedboten hoogstens 1 keer verhuurd. 
//Rob Loves

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verhuur_van_speedboten
{
    internal class Database
    {
        public static SqlConnection openSqlConn ()
        {
            SqlConnection conn = new SqlConnection (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\stefa\source\repos\eindopdracht\Verhuur van speedboten\bootverhuur.mdf;Integrated Security=True");
            conn.Open ();
            return conn;
        }
    }
}
