namespace Inheritance_polymorphism_task
{//create class jersey cow which inherits from Cow class
    class JerseyCow : Cow
    {//uses Cow class amount of milk
        public JerseyCow(double amtMilk) : base(amtMilk){ }

        //calculate profit -> amount of milk * price - vaccination based on price and vaccination price set by the user
        override public double getProf()
        {
            double profit = this.amtMilk * Prices.cowMilk - Prices.vacJCow;

            return (profit);
        }
    }
}
