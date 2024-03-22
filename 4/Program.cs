using System.Collections.Generic;
using System.Text;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            const string Guide = "1 - показать исходный List<>\n2 - listOfPerson.Sort() Icomparable\n3 - listOfPerson.Sort(new PersonComparer())\n4 - Инструкция\tESC - выход\n";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Реализация интерфейсов IComparable<Person> и IComparer<Person?>");

            int cursorLeft;
            ConsoleKeyInfo key;
            
            PrintGuide();


            List<Person> listOfPerson = new List<Person>
                {
                new Person { Name = "Ольга", Age = 5, Gender = Gender.Female },
                new Person { Name = "Олег", Age = 50, Gender = Gender.Male },
                new Person { Name = "Анна", Age = 60, Gender = Gender.Female },
                new Person { Name = "Игорь", Age = 35, Gender = Gender.Male },
                new Person { Name = "Мария", Age = 22, Gender = Gender.Female },
                new Person { Name = "Сергей", Age = 58, Gender = Gender.Male },
                new Person { Name = "Настя", Age = 24, Gender = Gender.Female },
                new Person { Name = "Иван", Age = 32, Gender = Gender.Male },
                new Person { Name = "Света", Age = 27, Gender = Gender.Female },
                new Person { Name = "Василий", Age = 19, Gender = Gender.Male }
                };

            var startList = new List<Person> (listOfPerson);

            do {
                PressKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        {
                            listOfPerson = startList.ToList();
                            foreach (Person p in listOfPerson) Console.WriteLine(p.Gender + " " + p.Name + " " + p.Age);
                            Console.WriteLine();
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            listOfPerson.Sort();
                            foreach (Person p in listOfPerson) Console.WriteLine(p.Gender + " " + p.Name + " " + p.Age);
                            Console.WriteLine();
                            listOfPerson = startList.ToList();
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            listOfPerson.Sort(new PersonComparer());
                            foreach (Person p in listOfPerson) Console.WriteLine(p.Gender + " " + p.Name + " " + p.Age);
                            Console.WriteLine();
                            listOfPerson = startList.ToList();
                            break;
                        }
                    case ConsoleKey.D4:
                        {
                            PrintGuide();
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        break;
                }
            }while (true);  


            void PrintGuide()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Guide);
                Console.ResetColor();
            }

            void PressKey()
            {
                cursorLeft = Console.CursorLeft;
                key = Console.ReadKey();
                Console.SetCursorPosition(cursorLeft, Console.CursorTop);
                Console.Write(" ");
                Console.SetCursorPosition(cursorLeft, Console.CursorTop);
            }
        }

    }
}
