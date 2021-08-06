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


        

        private double tProf(List<double> list)
        {
            List<double> aList = new List<double>();
            double profit = 0.0;

            for (int i = 0; i < aList.Count; i++)
            {
                profit += aList[i].getProf();
            }

            return profit;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line;
            List<Animal> farm = new List<Animal>();
            StreamReader file = new StreamReader(@"C:\Users\the_1\source\repos\Inheritance-polymorphism-task\task-data.txt");
            while((line = file.ReadLine()) != null)
            {
                string[] animls = line.Split(',');
                int id = int.Parse(animls[0]);
                double p = double.Parse(animls[1]);
                string type = animls[2];
                farm.Add(new Animal(id, p, type));
            }


        }
    }

}


