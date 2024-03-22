using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Elephant : Animal, Herbivore, IEquatable<Elephant>, IComparable<Elephant>
    {
        //public string Name { get; }
        public string? Sound { get; set; }
        public string? Colour { get; set; }

        public string? TypeFoodH { get; set; }
        public string? TypeHerbivore { get; }
        public int NumOfLegs { get; set; }

        public int SizeKG { get; set; }

        public Elephant()
        {
            Name = "Elephant";
            TypeFoodH = "Grass";
            TypeHerbivore = "Herbivore";
            Sound = "Wwooooo";
            Colour = "Gray";
            NumOfLegs = 4;
            SizeKG = 1000;
        }

        public Elephant(int size)
        {
            Name = "Elephant";
            TypeFoodH = "Grass";
            TypeHerbivore = "Herbivore";
            Sound = "Wwooooo";
            Colour = "Gray";
            NumOfLegs = 4;
            SizeKG = size;
        }

        public Elephant(string sound, string colour)
        {
            Name = "Elephant";
            TypeFoodH = "Grass";
            TypeHerbivore = "Herbivore";

            if (sound is not null) Sound = sound;
            else Sound = "Wwooooo";

            if (colour is not null) Colour = colour;
            else Colour = "Gray";

            NumOfLegs = 4;
            SizeKG = 1000;
        }

        public Elephant(string sound, string colour, int size)
        {
            Name = "Elephant";
            TypeFoodH = "Grass";
            TypeHerbivore = "Herbivore";

            if (sound is not null) Sound = sound;
            else Sound = "Wwooooo";

            if (colour is not null) Colour = colour;
            else Colour = "Gray";

            NumOfLegs = 4;
            SizeKG = size;
        }

        public override void DisplayAnimal()
        {
            Console.WriteLine($"Animal: Name: {Name}, Number of Legs: {NumOfLegs}, Sound: {Sound}, Colour: {Colour}");
            DisplayEatH();
        }

        public void DisplayEatH()
        {
            Console.WriteLine($"{Name} is {TypeHerbivore}, eat {TypeFoodH}");
        }

        public bool Equals(Elephant? other)
        {
            if (other is not null)
                return SizeKG == other.SizeKG;
                
            else return false;
        }

        public int CompareTo(Elephant? other)
        {
            if (other is not null)
            return SizeKG.CompareTo(other.SizeKG);
            else return 0;
        }
    }
}
