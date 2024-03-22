using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Zoo
    {
        public List<Animal> herbivores;
        public List<Animal> carnivores;
        public List<Animal> bears;

        public Zoo()
        {
            herbivores = new List<Animal>();
            carnivores = new List<Animal>();
            bears = new List<Animal>();
        }

        public void Add(Animal a)
        {
            if (a is not null)
            {
                if (a is Carnivore)
                {
                    if (a is Bear)
                    {
                        Console.Write("Поместить медведя в вольер хищников (1) или в отдельный вольер (2)? Сделайте выбор:");
                        ConsoleKeyInfo key;
                        do
                        {
                            int cursorL = Console.CursorLeft;
                            key = Console.ReadKey();

                            switch (key.Key)
                            {
                                case ConsoleKey.D1:
                                    {
                                        Console.WriteLine();
                                        carnivores.Add(a);
                                        Console.WriteLine($"{a.Name} помещен в вольер к хищникам");
                                        break;
                                    }
                                case ConsoleKey.D2:
                                    {
                                        Console.WriteLine();
                                        bears.Add(a);
                                        Console.WriteLine($"{a.Name} помещен в отдельный вольер с медведями");
                                        break;
                                    }
                                default:
                                    {
                                        Console.SetCursorPosition(cursorL, Console.CursorTop);
                                        Console.Write(" ");
                                        Console.SetCursorPosition(cursorL, Console.CursorTop);
                                        break;
                                    }
                            }
                        } while (key.Key != ConsoleKey.D1 && key.Key != ConsoleKey.D2);
                    }
                    else
                    {
                        carnivores.Add(a);
                        Console.WriteLine($"{a.Name} помещен в вольер к хищникам");
                    }
                }
                else if (a is Herbivore)
                {
                    herbivores.Add(a);
                    Console.WriteLine($"{a.Name} помещен в вольер к травоядным");
                }
                else Console.WriteLine($"Неизвестный тип животного ");
            }
            else Console.WriteLine("NULL");
        }

        public void Print()
        {
            if (carnivores.Count != 0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("В вольере хищников находятся:");
                Console.ResetColor();
                foreach (var a in carnivores) a.DisplayAnimal();

                //Console.Write(string.Join(", ", carnivores.Select(x => x.Name)));
                //Console.WriteLine();
            }
            else 
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вольер хищников пуст");
                Console.ResetColor();
            }
            if (herbivores.Count != 0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("В вольере травоядных находятся:");
                Console.ResetColor();

                foreach (var a in herbivores) a.DisplayAnimal();
                //Console.Write(string.Join(", ", herbivores.Select(x => x.Name)));
                //Console.WriteLine();
            }
            else 
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Вольер травоядных пуст");
                Console.ResetColor();
            }
            if (bears is not null && bears.Count != 0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("В вольере медведей находятся:");
                Console.ResetColor();

                foreach (var a in bears) a.DisplayAnimal();
                //Console.Write(string.Join(", ", bears.Select(x => x.Name)));
                
            }
            Console.WriteLine();
        }


        public void ElephantCompare()
        {
            List<Elephant> el = new List<Elephant>();
            Console.WriteLine();
            for (int i = 0; i < herbivores.Count; i++)
            {
                if (herbivores[i].GetType() == typeof(Elephant))
                {
                    el.Add((Elephant)herbivores[i]);
                }
            }
            if (el.Count == 0) Console.WriteLine("Слонов нет");
            else if (el.Count == 1) Console.WriteLine($"Слон один, весит {el[0].SizeKG}кг, не с кем сравнивать");
            else
            {
                for (int i = 0; i < el.Count - 1; i++)
                {
                    if (el[i].Equals(el[i + 1])) Console.WriteLine($"{i + 1} и {i + 2} слоны одинаковые.");
                    else if (el[i].CompareTo(el[i + 1]) > 0) Console.WriteLine($"{i + 1} слон больше чем  {i + 2}.");
                    else Console.WriteLine($"{i + 1} слон меньше чем  {i + 2}.");
                }
                Console.WriteLine($"Самый большой слон весит {el.OrderByDescending(x => x.SizeKG).FirstOrDefault().SizeKG}кг");
            }
        }

        public void ElephantSort() 
        {
            List<Elephant> el = new List<Elephant>();
            Console.WriteLine();
            for (int i = 0; i < herbivores.Count; i++)
            {
                if (herbivores[i].GetType() == typeof(Elephant))
                {
                    el.Add((Elephant)herbivores[i]);
                }
            }
            if (el.Count == 0) Console.WriteLine("Слонов нет");
            else if (el.Count == 1) Console.WriteLine($"Слон один, весит {el[0].SizeKG}кг, не с кем сравнивать");
            else
            {
                el.Sort();
                foreach (var item in el) 
                    Console.Write(string.Join("", item.Name , " ", item.SizeKG, "кг\n"));
 
                Console.WriteLine($"Самый большой слон весит {el.OrderBy(x => x.SizeKG).Last().SizeKG}кг");
            }
        }

        internal void Clear()
        {
            herbivores.Clear();
            carnivores.Clear();
            bears.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Все вольеры пусты");
            Console.ResetColor();
        }
    }
}
