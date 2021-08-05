using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        public class Animal
        {
            public string Type { get; set; }
            public int Id { get; set; }
            public double Price { get; set; }

            public Animal(string type, int id, double price)
            {
                Type = type;
                Id = id;
                Price = price;
            }
        }

        public class Cow : Animal
        {
            public Cow(Animal animal, string cow) : base(animal.Type, animal.Id, animal.Price)

            {
                this.cow = cow;
            }

            public string cow { get; set; }
            //public string jCow { get; set; }

        }

        public class Goat : Animal
        {
            public Goat(Animal animal, string goat) : base(animal.Type, animal.Id, animal.Price)
            {
                this.goat = goat;
            }
            public string goat { get; set; }
        }

        static class Stats
        {
            static void Main(String[] args)
            {
                string[] data = System.IO.File.ReadAllLines(@"C:\Users\the_1\source\repos\Inheritance-polymorphism-task\task-data.txt");

                try
                {
                    Animal animal = new Animal(data);
                }

                foreach (string line in data)
                {
                    string result = "\t" + line;                   
                }

            }

        }

    }                  
}

