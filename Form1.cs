using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Inheritance_polymorphism_task
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }


        private double tProf(Animal [] a)
        {
            double profit = 0.0;

            for (int i = 0; i < 10; i++)
            {
                a[i] = new Cow(i + 100, i * 23.5);
            }

            for (int i = 0; i < 10; i++)
            {
                profit += myFarm[i].getProf();
            }

            return profit;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Animal> farm = new List<Animal>();
            string line;
            StreamReader file = new StreamReader(@"C:\Users\the_1\source\repos\Inheritance-polymorphism-task\task-data.txt");
            while((line = file.ReadLine()) != null)
            {
                var extract = line.Split(',');
                farm.Add(new Animal()
                {
                    Id = extract[0],
                    Price = extract[1],
                    Type = extract[2]
                });
            }
            file.Close();

            var farmArray = farm.ToArray();

        }
    }

}


