using _5;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

const string Guide = "1 - вставить сим\t2 - удалить сим\t\t3 - позвонить\n4 - выйти в интернет\t5 - пополнить баланс\t6 - проверить баланс\n0 - Инструкция\tESC - выход\n";

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Работа с дженериками");
Console.ResetColor();

int cursorLeft;
ConsoleKeyInfo key;

Console.Write("Введите модель телефона: ");
MobilePhone<MobileNetwork> phone = new MobilePhone<MobileNetwork>(Console.ReadLine());

PrintGuide();


MobileNetwork Life = new MobileNetwork("Life");
MobileNetwork MTS = new MobileNetwork("MTS");
MobileNetwork A1 = new MobileNetwork("A1");


do
{
    PressKey();
    switch (key.Key)
    {
        case ConsoleKey.D1:
            {
                if (phone.Network1 is null || phone.Network2 is null)
                {
                    Console.WriteLine("Вставить сим: 1 - Life, 2 - A1, 3 - MTS");

                    PressKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.D1:
                            {
                                phone.InsertSim(Life);
                                Console.WriteLine();
                                continue;
                            }

                        case ConsoleKey.D2:
                            {
                                phone.InsertSim(A1);
                                Console.WriteLine();
                                break;
                            }

                        case ConsoleKey.D3:
                            {
                                phone.InsertSim(MTS);
                                Console.WriteLine();
                                break;
                            }

                        default:
                            break;
                    }
                }
                else Console.WriteLine("Обе сим-карты уже вставлены");
                //Console.WriteLine();
                break;
            }
        case ConsoleKey.D2:
            {
                if (phone.Network1 is null && phone.Network2 is null) Console.WriteLine("Обе сим-карты уже извлечены");
                else
                {
                    Console.Write("Извлечь sim: ");
                    if (phone.Network1 is not null)
                        Console.Write($"1 - {phone.Network1.Name} ");
                    if (phone.Network2 is not null)
                        Console.Write($"2 - {phone.Network2.Name}");

                    Console.WriteLine();

                    PressKey();

                    switch (key.Key)
                    {
                        case ConsoleKey.D1:
                            {
                                phone.ExtractSim("1");
                                break;
                            }

                        case ConsoleKey.D2:
                            {
                                phone.ExtractSim("2");
                                break;
                            }

                        default:
                            break;
                    }
                }

                Console.WriteLine();
                break;
            }
        case ConsoleKey.D3:
            {
                if (phone.Network1 is not null || phone.Network2 is not null)
                {
                    Console.Write("Sim для совершения вызова: ");
                    if (phone.Network1 is not null)
                        Console.Write($"1 - {phone.Network1.Name} ");
                    if (phone.Network2 is not null)
                        Console.Write($"2 - {phone.Network2.Name}");
                    Console.WriteLine();
                    PressKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.D1:
                            {
                                if (phone.Network1 is not null)
                                    phone.Network1.Call(5);
                                break;
                            }

                        case ConsoleKey.D2:
                            {
                                if (phone.Network2 is not null)
                                    phone.Network2.Call(6);
                                break;
                            }
                        default:
                            break;
                    }
                }
                else Console.WriteLine("Вызов невозможен. Сим-карты не обнаружены");
                Console.WriteLine();
                break;
            }
        case ConsoleKey.D4:
            {
                if (phone.Network1 is not null || phone.Network2 is not null)
                {
                    Console.WriteLine("Sim для использования интернета: ");
                    if (phone.Network1 is not null)
                        Console.Write($"1 - {phone.Network1.Name} ");
                    if (phone.Network2 is not null)
                        Console.Write($"2 - {phone.Network2.Name}");
                    Console.WriteLine();
                    PressKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.D1:
                            {
                                if (phone.Network1 is not null)
                                    phone.Network1.UseInternet(50);
                                break;
                            }

                        case ConsoleKey.D2:
                            {
                                if (phone.Network2 is not null)
                                    phone.Network2.UseInternet(75);
                                break;
                            }
                        default:
                            break;
                    }
                }
                else Console.WriteLine("Интернет недоступен. Сим-карты не обнаружены");
                Console.WriteLine();
                break;
            }
        case ConsoleKey.D5:
            {
                if (phone.Network1 is not null || phone.Network2 is not null)
                {
                    Console.WriteLine("Sim для пополнения: ");
                    if (phone.Network1 is not null)
                        Console.Write($"1 - {phone.Network1.Name} ");
                    if (phone.Network2 is not null)
                        Console.Write($"2 - {phone.Network2.Name}");
                    Console.WriteLine();
                    PressKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.D1:
                            {
                                if (phone.Network1 is not null)
                                    phone.Network1.SetTarif(200, 50);
                                break;
                            }

                        case ConsoleKey.D2:
                            {
                                if (phone.Network2 is not null)
                                    phone.Network2.SetTarif(250, 40);
                                break;
                            }
                        default:
                            break;
                    }
                }
                else Console.WriteLine("Сим-карты не обнаружены");
                Console.WriteLine();
                break;
            }
        case ConsoleKey.D6:
            {
                phone.CheckPhone();
                Console.WriteLine();
                break;
            }
        case ConsoleKey.D0:
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