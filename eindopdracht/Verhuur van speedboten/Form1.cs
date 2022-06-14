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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadComboBox(); //Function hieronder

            Bedrijf bedrijf = new Bedrijf(); //Maak een bedrijf aan

            //label3.Text = bedrijf.naam; // Zet naam van het bedrijf in label

            label3.Text = bedrijf.speedboten.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void loadComboBox()
        {
            string query = @"SELECT * FROM speedboot";

            SqlDataReader dr = new SqlCommand(query, Database.openSqlConn()).ExecuteReader();
            speedbotenlabel.Text = "";
            while (dr.Read())
            {
                botenLijst.Items.Add(dr.GetValue(0).ToString());
            }

            dr.Close();
        }
    }
}
