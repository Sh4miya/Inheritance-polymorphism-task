using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_polymorphism_task
{
    class JerseyCow : Cow
    {
        public JerseyCow(int id, double milkAmt) : base(id, milkAmt)
        {

        }
        override public double getProf()
        {
            return (0);
        }
    }
}
