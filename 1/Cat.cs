using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1
{
    internal class Cat : Animal, Carnivore
    {
        //public string Name { get; }
        public string? Sound { get; set; }
        public string? Colour { get; set; }

        public string? TypeFoodC { get; set; }
        public string? TypeCarnivore { get; }
        //public int NumOfLegs { get; set; }

        public Cat()
        {
            Name = "Cat";
            TypeFoodC = "Meat";
            TypeCarnivore = "Carnivore";
            Sound = "Meooow";
            Colour = "Black";
            NumOfLegs = 4;
        }

        public Cat(string sound, string colour)
        {
            Name = "Cat";
            TypeFoodC = "Meat";
            TypeCarnivore = "Carnivore";

            if (sound is not null) Sound = sound;
            else Sound = "Meooow";

            if (colour is not null) Colour = colour;
            else Colour = "Black";

            NumOfLegs = 4; 
        }

        public override void DisplayAnimal()
        {
            Console.WriteLine($"Animal: Name: {Name}, Number of Legs: {NumOfLegs}, Sound: {Sound}, Colour: {Colour}");
            DisplayEatC();
        }

        public void DisplayEatC()
        {
            Console.WriteLine($"{Name} is {TypeCarnivore}, eat {TypeFoodC}");
        }
    }
}

