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
        Bedrijf bedrijf = new Bedrijf(); //Maak een bedrijf aan

        public Form1()
        {
            InitializeComponent();

            loadSpeedbotenLabel();
            loadComboBox();

            //label3.Text = bedrijf.naam; // Zet naam van het bedrijf in label
            beschikbareBoten.Text += bedrijf.speedboten.Count.ToString(); //Om te kijken hoeveel boten er in de list zitten
            verhuurd.Text += bedrijf.verhuurden.Count.ToString();
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
            if (schadeComboBox.SelectedIndex == -1 && botenComboLijst.SelectedIndex == -1)
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
                            //Check if 
                            if (verhuurden.bootnummer.ToString() == selectedBoot)
                            {
                                //Check if rented boat is already rented today
                                if (verhuurden.verhuurDatum == rentDate)
                                {
                                    MessageBox.Show("Deze boot is vandaag al verhuurd!");
                                }
                                else
                                {
                                    //Add damage to speedboat
                                    if (schade == "true")
                                    {
                                        //Set damage to speedboot
                                        setDamage(selectedBoot);
                                    }

                                    addRental(selectedBoot, startTime, endTime, usedLiters, rentDate);
                                }
                            }
                            else
                            {
                                if (schade == "true")
                                {
                                    //Set damage to speedboot
                                    setDamage(selectedBoot);
                                }
                                addRental(selectedBoot, startTime, endTime, usedLiters, rentDate);
                            }
                        }
                    }
                    else
                    {
                        //Add damage to speedboat
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
            //Could be put in a seperate function
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
            //selectedboot = put to int
            //starttime = keep string
            //endTime = keep string
            //usedLiters = put to datetime
            //rentDate = keep datetime

            int nummer = 0;

            //Get latest id from db and then lastId++
            string query = @"SELECT MAX(id) FROM verhuur";

            SqlDataReader dr = new SqlCommand(query, Database.openSqlConn()).ExecuteReader();
            while (dr.Read())
            {
                if (dr.GetValue(0).ToString() != "")
                {
                    nummer += int.Parse(dr.GetValue(0).ToString());
                }
                MessageBox.Show(dr.GetValue(0).ToString());
            }

            MessageBox.Show(nummer.ToString());
            //Add to list - 1
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

            MessageBox.Show("Boot verhuurd");
        }
    }
}
