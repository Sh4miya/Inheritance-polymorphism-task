using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_polymorphism_task
{
    abstract class Animal
    {
        public int id;

        public Animal(int id)
        {
            this.id = id;
        }

        public abstract double getProf();

    }

}
