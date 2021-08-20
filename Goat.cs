namespace Inheritance_polymorphism_task
{//create the Goat class which inherits from Animal
    class Goat : Animal
    {
        public double amtMilk;
        //sets amount of milk based on the text file
        public Goat( double amtMilk)
        {
            this.amtMilk = amtMilk;
        }

        //calculate profit -> amount of milk * price - vaccination based on the price set by the user
        override public double getProf()
        {
            double profit = this.amtMilk * Prices.goatMilk - Prices.vacGoat;

            return (profit);
        }
    }
}
