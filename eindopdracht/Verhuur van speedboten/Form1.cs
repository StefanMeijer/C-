//Stefan Meijer
//16-6-2022
//0.1
//Een bedrijf verhuurt speedboten. Voor één bepaalde dag wordt elk van de tien aanwezige speedboten hoogstens 1 keer verhuurd. 
//Rob Loves

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
using System.Threading;

namespace Verhuur_van_speedboten
{
    public partial class Form1 : Form
    {
        Bedrijf bedrijf = new Bedrijf(); //Maak een bedrijf aan
        AboutBox1 a = new AboutBox1(); //Maak aboutbox aan

        public Form1()
        {
            //Splashscreen
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();

            loadSpeedbotenLabel();
            loadComboBox();

            bedrijfLabel.Text = bedrijf.naam; // Zet naam van het bedrijf in label

            beschikbareBoten.Text += bedrijf.speedboten.Count.ToString(); //Om te kijken hoeveel boten er in de list zitten
            verhuurd.Text += bedrijf.verhuurden.Count.ToString(); //Om te kijken hoeveel verhuurden er zijn

            
        }
        public void StartForm()
        {
            Application.Run(new Splashscreen());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void loadComboBox()
        {
            foreach (Speedboot speedboot in bedrijf.speedboten)
            {
                botenComboLijst.Items.Add(speedboot.nummer);
            }
        }

        private void loadSpeedbotenLabel()
        {
            speedbotenlabel.Text = "";

            foreach (Speedboot speedboot in bedrijf.speedboten)
            {
                speedbotenlabel.Text
                += "Nummer: " + speedboot.nummer
                + "   Gewicht: " + speedboot.gewicht
                + "   Pk's: " + speedboot.pks
                + "   Lengte: " + speedboot.lengte
                + "   Huurprijs: " + speedboot.huurprijs
                + "   Schade: " + speedboot.schade
                + "\n";
            }
        }

        private void verhuurBootButton_Click(object sender, EventArgs e)
        {
            //Check if comboboxes have been filled in
            if (schadeComboBox.SelectedIndex == -1 || botenComboLijst.SelectedIndex == -1)
            {
                MessageBox.Show("Vul alle velden in!");
            }
            else
            {
                //Get all data
                string selectedBoot = botenComboLijst.SelectedItem.ToString();
                string startTime = aanvangstijd.Text.ToString();
                string endTime = eindtijd.Text.ToString();
                string usedLiters = verbruikteliters.Text.ToString();
                string schade = schadeComboBox.SelectedItem.ToString();
                DateTime rentDate = DateTime.Now;

                //Check data
                if (
                    !String.IsNullOrEmpty(selectedBoot) &&
                    !String.IsNullOrEmpty(startTime) &&
                    !String.IsNullOrEmpty(endTime) &&
                    !String.IsNullOrEmpty(usedLiters) &&
                    !String.IsNullOrEmpty(schade)
                    )
                {
                    if (bedrijf.verhuurden.Count > 0)
                    {
                        foreach (Verhuur verhuurden in bedrijf.verhuurden)
                        {
                            //Check if bootnummer is equal to selected bootnummer
                            if (verhuurden.bootnummer.ToString() == selectedBoot)
                            {
                                DateTime Today = rentDate.Date; //Date only, without time!

                                //Check if rented boat is already rented today
                                if (verhuurden.verhuurDatum.Date == Today)
                                {
                                    MessageBox.Show("Deze boot is vandaag al verhuurd!");
                                    break;
                                }
                                else
                                {
                                    if (schade == "true")
                                    {
                                        setDamage(selectedBoot);
                                    }

                                    addRental(selectedBoot, startTime, endTime, usedLiters, rentDate);
                                    break;
                                }
                            }
                            else
                            {
                                if (schade == "true")
                                {
                                    setDamage(selectedBoot);
                                }
                                addRental(selectedBoot, startTime, endTime, usedLiters, rentDate);
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (schade == "true")
                        {
                            setDamage(selectedBoot);
                        }
                        addRental(selectedBoot, startTime, endTime, usedLiters, rentDate);
                    }
                }
                else
                {
                    MessageBox.Show("Vul alle velden in!");
                }
            }
        }

        private void setDamage(string selectedBoot)
        {
            foreach (Speedboot speedboot in bedrijf.speedboten)
            {
                if (speedboot.nummer == int.Parse(selectedBoot))
                {
                    speedboot.schade = true;

                    string query = @"UPDATE Speedboot SET schade = @Schade WHERE nummer = @Bootnummer";

                    SqlCommand command = new SqlCommand(query, Database.openSqlConn());
                    command.Parameters.AddWithValue("@Schade", 1); //1 = true
                    command.Parameters.AddWithValue("@Bootnummer", int.Parse(selectedBoot));

                    command.ExecuteNonQuery();

                    MessageBox.Show("Schade is toegevoegd aan de boot!");
                }
            }
        }

        private void addRental (string selectedBoot, string startTime, string endTime, string usedLiters, DateTime rentDate)
        {
            int nummer = 0;

            //Get latest id from db
            string query = @"SELECT MAX(id) FROM verhuur";

            SqlDataReader dr = new SqlCommand(query, Database.openSqlConn()).ExecuteReader();

            while (dr.Read())
            {
                if (dr.GetValue(0).ToString() != "")
                {
                    nummer += int.Parse(dr.GetValue(0).ToString());
                }
            }

            //Create new object verhuur
            Verhuur verhuur = new Verhuur(
                nummer++,
                int.Parse(selectedBoot),
                DateTime.ParseExact(startTime, "HH:mm", null),
                DateTime.ParseExact(endTime, "HH:mm", null),
                int.Parse(usedLiters),
                rentDate
            );

            //Adding rental to list of rentals
            bedrijf.verhuurden.Add(verhuur);

            //Adding rental to DB
            string insertQuery = @"INSERT INTO verhuur (boot, aanvangstijd, eindtijd, verbruikteliters, verhuurdatum)
                                   VALUES (@boot, @aanvangstijd, @eindtijd, @verbruikteliters, @verhuurdatum)";

            SqlCommand commando = new SqlCommand(insertQuery, Database.openSqlConn());

            commando.Parameters.AddWithValue("@boot", int.Parse(selectedBoot));
            commando.Parameters.AddWithValue("@aanvangstijd", DateTime.ParseExact(startTime, "HH:mm", null));
            commando.Parameters.AddWithValue("@eindtijd", DateTime.ParseExact(endTime, "HH:mm", null));
            commando.Parameters.AddWithValue("@verbruikteliters", int.Parse(usedLiters));
            commando.Parameters.AddWithValue("@verhuurdatum", DateTime.Now);

            commando.ExecuteNonQuery();

            verhuurd.Text = "Totaal verhuurd: ";
            verhuurd.Text += bedrijf.verhuurden.Count.ToString(); //Om te kijken hoeveel verhuurden er zijn

            MessageBox.Show("Boot verhuurd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = bedrijf.totaleOmzet();
            omzetLabel.Text = "€ " + total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimeSpan ts = bedrijf.totaleVerhuurtijd();
            verhuurtijdLabel.Text = ts.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bootnummer = bedrijf.hoogsteBrandstofVerbruik();
            hoogstebrandstofLabel.Text = "Bootnummer: " + bootnummer;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double percentage = bedrijf.percentageSchadeBoten();
            percentageSchadeLabel.Text = percentage.ToString() + "%";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Speedboot korsteVerhuurd = bedrijf.korsteVerhuurd();
            korstVerhuurdeLabel.Text = "Bootnummer: " + korsteVerhuurd.nummer.ToString();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.a.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bedrijfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void verhuurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void speedbotenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage3);
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }
    }
}
