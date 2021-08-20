namespace Inheritance_polymorphism_task
{//create the class cow which inherits from the Animal class
    class Cow : Animal
    {//sets the amount of milk based on the text file
        public double amtMilk;

        public Cow(double amtMilk)
        {
            this.amtMilk = amtMilk;
        }

        //calculate profit -> amount of milk * price - vaccination based on price and vaccination price set by the user
        override public double getProf()
        {
            double profit = this.amtMilk * Prices.cowMilk - Prices.vacCow;

            return (profit);
        }

    }
}
