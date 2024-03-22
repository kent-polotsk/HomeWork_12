using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{

    interface Herbivore
    {
        string TypeFoodH { get; set; }
        string TypeHerbivore { get; }
        //string Name { get; }

        void DisplayEatH();
    }

    interface Carnivore
    {
        string TypeFoodC { get; set; }
        string TypeCarnivore { get;}
        //string Name { get; }

        void DisplayEatC();
    }

    abstract class Animal
    {
        public string Name { get; set; }
        public int NumOfLegs { get; set; }

        public abstract void DisplayAnimal();
    }
}
