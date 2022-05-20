using System;

namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");

            string numb = Console.ReadLine();
            int value = int.Parse(numb);
            if (value % 2 == 0)
            {
                Console.Write("Число чётное");
            }
            else
            {
                Console.Write("Число НЕ чётное");
            }
            Console.ReadKey();
        }
    }
}
