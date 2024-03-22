using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class MobileNetwork
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int TarifMB {  get; set; }
        public int TarifMin {  get; set; }

        public MobileNetwork(string name) 
        {
            Name = name;
            Country = "Belarus";
            TarifMB = 0;
            TarifMin = 0;
        }

        public void Call(int Min)
        {
            if ( TarifMin > 0 )
            {
                if (TarifMin >= Min)
                {
                    TarifMin -= Min;
                    Console.WriteLine($"Вызов совершен. Осталось {TarifMin} минут");
                }
                else
                {
                    TarifMin -= Min;
                    Console.WriteLine($"Вы израсходовали пакет минут. Пополните баланс");
                }
            }
            else Console.WriteLine($"Недостаточно минут");
        }

        public void UseInternet(int MB)
        {
            if (TarifMB > 0)
            {
                if (TarifMB > MB)
                {
                    TarifMB -= MB;
                    Console.WriteLine($"Интернет трафик предоставлен. Осталось {TarifMB} мегабайт");
                }
                else
                {  
                    Console.WriteLine($"Использовано {TarifMB} мегабайт. Интернет трафик израсходован, пополните баланс");
                    TarifMB = 0;
                }
            }
            else Console.WriteLine($"Интернет трафик израсходован. Пополните баланс");
        }


        public void SetTarif(int MB, int Min) 
        {
            TarifMB += MB;
            TarifMin += Min;
            Console.WriteLine($"Тариф продлен. Всего {TarifMin} минут и {TarifMB} МБ");
        }

        public void CheckTarif()
        {
            Console.WriteLine($"У вас осталось {TarifMin} минут и {TarifMB} МБ");
        }
    }
}
