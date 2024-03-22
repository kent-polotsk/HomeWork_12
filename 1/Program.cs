using _1;
using System.Reflection.Emit;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

const string Guide = "1 - Добавить кота\t2 - Добавить медведя\t\t3 - Добавить слона\n4 - Сравнить слонов\t5 - Сравнить слонов (Sort)\t6 - Освободить вольеры\n7 - Просмотр вольеров\t8 - Инструкция\t\t\tESC - выход";

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Работа зоопарка");

int cursorLeft; 
Zoo zoo = new Zoo();
ConsoleKeyInfo key;
PrintGuide();


do
{
    PressKey();
    switch (key.Key)
    {
        case ConsoleKey.D1:
            {
                zoo.Add(new Cat());
                break;
            }
        case ConsoleKey.D2:
            {
                zoo.Add(new Bear());
                break;
            }
        case ConsoleKey.D3:
            {
                Console.Write("Введите массу слона в килограмах (100-7000): ");
                string input;

                do 
                {
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int result) && (result >= 100 && result <= 7000)) 
                    {
                        zoo.Add(new Elephant(result));
                        break;
                    }
                    else Console.Write("Некоректный ввод массы, повторите: ");
                } while (true);

                break;
            }
        case ConsoleKey.D4:
            {
                zoo.ElephantCompare();
                break;
            }
        case ConsoleKey.D5:
            {
                zoo.ElephantSort();
                break;
            }
        case ConsoleKey.D6:
            {
                zoo.Clear();
                break;
            }
        case ConsoleKey.D7:
            {
                zoo.Print();
                break;
            }
        case ConsoleKey.D8:
            {
                PrintGuide();
                break;
            }
        case ConsoleKey.Escape:
            {
                Environment.Exit(0);
                break;
            }
        default: break;

    }
} while (true);



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



