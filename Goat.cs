using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_polymorphism_task
{
    class Goat : Animal
    {
        public double milkAmt;

        public Goat(int id, double milkAmt): base(id)
        {
            this.milkAmt = milkAmt;
        }

        override public double getProf()
        {
            return (20.0);
        }
    }
}
