using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Bear : Animal, Carnivore, Herbivore
    {
        //new public string Name { get; }
        public string? Sound { get; set; }
        public string? Colour { get; set; }

        public string? TypeFoodC { get; set; }
        public string? TypeFoodH { get; set; }

        public string? TypeCarnivore { get; }
        public string? TypeHerbivore { get; }

        public int NumOfLegs { get; set; }

        public Bear()
        {
            Name = "Bear";
            TypeFoodC = "Meat";
            TypeCarnivore = "Carnivore";
            TypeFoodH = "Berries";
            TypeHerbivore = "Herbivore";
            Sound = "Grrrr";
            Colour = "Brown";
            NumOfLegs = 4;
        }

        public Bear(string sound, string colour)
        {
            Name = "Bear";
            TypeFoodC = "Meat";
            TypeCarnivore = "Carnivore";
            TypeFoodH = "Berries";
            TypeHerbivore = "Herbivore";

            if (sound is not null) Sound = sound;
            else Sound = "Grrrr";

            if (colour is not null) Colour = colour;
            else Colour = "Brown";

            NumOfLegs = 4;
        }

        public override void DisplayAnimal()
        {
            Console.WriteLine($"Animal: Name: {Name}, Number of Legs: {NumOfLegs}, Sound: {Sound}, Colour: {Colour}");
            DisplayEatC();
            DisplayEatH();
        }

        public void DisplayEatC()
        {
            Console.WriteLine($"{Name} is {TypeCarnivore}, eat {TypeFoodC}");
        }

        public void DisplayEatH()
        {
            Console.WriteLine($"{Name} is {TypeHerbivore}, eat {TypeFoodH}");
        }
    }
}
