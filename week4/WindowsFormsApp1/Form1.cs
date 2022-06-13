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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = NorthWind; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            string query = @"SELECT * FROM Employees ORDER BY LastName; ";

            DataSet result = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);

            adapter.Fill(result);

            foreach(DataRow row in result.Tables[0].Rows)
            {
                label1.Text = String.Format("{0} {1}", row["FirstName"], row["LastName"]);
            }
        }
    }
}
