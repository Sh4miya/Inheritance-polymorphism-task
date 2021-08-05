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
    }

    class Animal
    {
        public string type { get; set; }
        public int ID { get; set; }
        public double price { get; set; }
    }

    class Cow : Animal

    {
        public string cow;
        public string jerseyCow;

    }

    class Goat : Animal
    {
        public string goat;
    }

                        
}

