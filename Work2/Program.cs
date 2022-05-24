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
                    default:
                        int num = 0;
                        bool parseOK = int.TryParse(nominal, out num);
                        if (parseOK)
                            sum += num;
                        else
                        {
                            i--;
                            Console.WriteLine("Номинал карты введен не корректно");
                        }
                        break;
                }
            }
            Console.WriteLine($"Колличество карт в Вашей руке: {amountCards} \nНабранное колличество очков: {sum}");
            Console.ReadKey();
        }
    }
}
