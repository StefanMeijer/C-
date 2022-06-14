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

        public static DataSet selectDataFromDb (string query)
        {
            DataSet ds = new DataSet ();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, openSqlConn());

            sqlDataAdapter.Fill (ds);
            return ds;
        }
    }
}
