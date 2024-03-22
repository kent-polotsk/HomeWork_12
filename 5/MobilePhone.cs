using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class MobilePhone<T> where T : MobileNetwork
    {
        public T Network1 { get; set; }
        public T Network2 { get; set; }

        public string Name { get; set; }

        public MobilePhone(string name)
        {
            Name = name;
        }

        public void InsertSim(T sim)
        {
            if (Network1 is null)
            {
                Network1 = sim;
                Console.WriteLine($"Cим-карта {Network1.Name} вставлена");
            }
            else if (Network2 is null)
            {
                Network2 = sim;
                Console.WriteLine($"Cим-карта {Network2.Name} вставлена");
            }
            else Console.WriteLine("Обе сим-карты уже вставлены");
        }

        public void ExtractSim(string s)
        {
            if (s != "1" && s != "2")
                Console.WriteLine("Неверный номер сим-карты");

            else if (s == "1")
            {
                if (Network1 is null) Console.WriteLine("Слот для Sim-1 пуст");
                else
                {
                    if (Network2 is not null)
                        Console.WriteLine($"Сим-карта {Network1.Name} извлечена");
                    else Console.WriteLine($"Сим-карта {Network1.Name} извлечена. Оба слота для Sim пусты");
                    Network1 = null;
                }
            }
            else if (s == "2")
            {
                if (Network2 is null) Console.WriteLine("Слот для Sim-2 пуст");
                else
                {
                    if (Network1 is not null)
                        Console.WriteLine($"Сим-карта {Network2.Name} извлечена");
                    else Console.WriteLine($"Сим-карта {Network2.Name} извлечена. Оба слота для Sim пусты");
                    Network2 = null;
                }
            }
            else Console.WriteLine("Оба слота для Sim пусты");
        }

        public void CheckPhone()
        {
            Console.WriteLine($"Phone: {Name}");
            if (Network1 is not null)
            {
                Console.Write($"sim1: {Network1.Name}. ");
                Network1.CheckTarif();
            }
            if (Network2 is not null)
            {
                Console.Write($"sim2: {Network2.Name}. ");
                Network2.CheckTarif();
            }
            if (Network1 is null && Network2 is null) Console.WriteLine("Сим-карты не обнаружены");
        }
    }
}
