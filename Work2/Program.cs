using System;

namespace Work2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BLACKJACK \nЗдравствуйте , введите количество карт :");
            byte amountCards = byte.Parse(Console.ReadLine());
            int sum = 0;
            Console.WriteLine("Карты от 1 до 10 J=10 Q=10 K=10 T=10 ");
            for (int i = 0; i < amountCards; i++)
            {
                Console.WriteLine("Введите номинал карты: ");
                string nominal = (Console.ReadLine());
                switch (nominal)
                {
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        sum = sum + 10;
                        break;
                    case "1":
                        sum = sum + 1;
                        break;
                    case "2":
                        sum = sum + 2;
                        break;
                    case "3":
                        sum = sum + 3;
                        break;
                    case "4":
                        sum = sum + 4;
                        break;
                    case "5":
                        sum = sum + 5;
                        break;
                    case "6":
                        sum = sum + 6;
                        break;
                    case "7":
                        sum = sum + 7;
                        break;
                    case "8":
                        sum = sum + 8;
                        break;
                    case "9":
                        sum = sum + 9;
                        break;
                    case "10":
                        sum = sum + 10;
                        break;
                    default:
                        i--;
                        Console.WriteLine("Номинал карты введен не корректно");
                        break;
                }
            }
            Console.WriteLine($"Колличество карт в Вашей руке: {amountCards} \nНабранное колличество очков: {sum}");
            Console.ReadKey();
        }
    }
}
