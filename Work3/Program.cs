using System;

namespace Work3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int numb = int.Parse(Console.ReadLine());
            bool n = true;
            int i = 2;
            while (i <= Math.Sqrt(numb))
            { 
                if (numb % i == 0)
                {
                    n = false;
                    break;
                }
                else
                {
                    i++;
                }
            }
            if (n == true)
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число составное");
            }
            Console.ReadKey();
        }
    }
}
