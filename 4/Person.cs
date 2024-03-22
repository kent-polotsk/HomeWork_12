using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Person : IComparable<Person>, ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public int CompareTo(Person other)
        {
            if (Gender != other.Gender)
                return other.Gender.CompareTo(Gender);

            else return Age.CompareTo(other.Age);
        }

        public object Clone() => MemberwiseClone();

    }
    
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Gender != y.Gender)
            {
                if (x.Gender == Gender.Female)
                    return -1;
                else return 1;
            }
            else return x.Age.CompareTo(y.Age);
        }
    }
}
