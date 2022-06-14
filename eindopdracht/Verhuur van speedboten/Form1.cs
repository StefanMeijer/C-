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
            

        }

        private void bedrijfBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bedrijfBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!bedrijfsnaamTextBox.Text.Equals(String.Empty))
            {
                string query = @"INSERT INTO bedrijf (bedrijfsnaam) VALUES (@NAME)";

                SqlCommand cm = new SqlCommand(query, Database.openSqlConn());

                cm.Parameters.AddWithValue("@NAME", bedrijfsnaamTextBox.Text);

                cm.ExecuteNonQuery();

                MessageBox.Show("gelukt!");
            } else
            {
                MessageBox.Show("Vul het veld in!");
            }
        }
    }
}
