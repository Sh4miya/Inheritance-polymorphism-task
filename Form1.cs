using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Inheritance_polymorphism_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //calculate the total profits from the dictionary of animals
        static double totalProf(Dictionary <int, Animal> farmAnimals)
        {
            double profit = 0.0;
            
            //iterate through the hashtables starting with the first entry and stopping at the last
            for(int i =  farmAnimals.Keys.First(); i <= farmAnimals.Keys.Last(); i++)
            {
                Animal myAnimal = farmAnimals[i];
                profit += myAnimal.getProf();
            }
            return profit;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {//opens the file directory to locate the type of file you will be reading
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    InitialDirectory = @"C:\",
                    //limits the choice between all files and text file
                    Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*", 
                    FilterIndex = 2,
                    RestoreDirectory = true
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {//displays the file location in the fLoc box
                    fLoc.Text = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            { //get the five values for milk and vaccination prices
                Prices.cowMilk = double.Parse(cowMilk.Text);
                Prices.goatMilk = double.Parse(goatMilk.Text);
                Prices.vacCow = double.Parse(cowVac.Text);
                Prices.vacJCow = double.Parse(jCowVac.Text);
                Prices.vacGoat = double.Parse(goatVac.Text);
                readData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void readData()
        {
            double price = 0.0;

            try
            {   // create the hashtable (dictionary) of animals
                Dictionary<int, Animal> farmAnimals = new Dictionary<int, Animal>();

                //Animal[] fAnimals = new Animal[10]; array version

                int id;
                double amtMilk;
                string type;

                //read the text file from the chosen file location based on the fLoc box
                using (StreamReader reader = new StreamReader(fLoc.Text))
                {
                    string line;
                    //check if the line is not null and read each line
                    while ((line = reader.ReadLine()) != null)
                    { //splits the line to get each type of data
                        string[] temp = line.Split(',');                        

                        id = int.Parse(temp[0]);
                        amtMilk = double.Parse(temp[1]);
                        type = temp[2];

                        //checks the data for the animal type and creates the animal class based on type
                        if (type == "Cow")
                        {
                            farmAnimals.Add(id, new Cow(amtMilk));
                        }
                        else if (type == "Jersey_Cow")
                        {
                            farmAnimals.Add(id, new JerseyCow(amtMilk));
                        }
                        else if (type == "Goat")
                        {
                            farmAnimals.Add(id, new Goat(amtMilk));
                        }                      
                    }
                    reader.Close();

                    price += totalProf(farmAnimals);

                    //return the price rounded to 2dp
                    Profit.Text = "$" + Math.Round(price, 2);
                }
            }
            catch
            {
                MessageBox.Show("File Error!");
            }
        }
    }

}


