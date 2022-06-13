using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace csv
{
    public partial class Form1 : Form
    {
        List<Student> studentList = new List<Student>();

        public Form1()
        {
            InitializeComponent();

            StreamReader dataImport = new StreamReader(@"C:\Users\stefa\OneDrive\Bureaublad\studenten.csv");
            

            while (!dataImport.EndOfStream)
            {
                string temp = dataImport.ReadLine();
                String[] tempArr = temp.Split(';');

                studentList.Add(new Student(tempArr[0], tempArr[1], int.Parse(tempArr[2])));
            }
        }

        private void nameSort_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < studentList.Count -1; x++)
            {
                for (int i = 0; i < studentList.Count - 1; i++)
                {
                    Student student1 = studentList[i];
                    Student student2 = studentList[i+1];

                    String s1 = studentList[i].name.ToLower();
                    String s2 = studentList[i+1].name.ToLower();

                    if (s1[0] > s2[0])
                    {
                        studentList[i] = student2;
                        studentList[i+1] = student1;
                    }
                }
            }

            label1.Text = String.Empty;
            foreach(Student student in studentList)
            {
                label1.Text += student.ToString();
                label1.Text += "\n";
            }
        }

        private void nrSort_Click(object sender, EventArgs e)
        {

        }

        private void ageSort_Click(object sender, EventArgs e)
        {

        }


        //Csv inlezen - stap 1


        //Knoppen toevoegen - stap 2

        //Sorteer algoritme - stap 3

    }
}
