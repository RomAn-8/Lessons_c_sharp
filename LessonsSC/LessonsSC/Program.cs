using System;

namespace LessonsSC
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int a, b;
            Console.WriteLine("Введите число");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);
            Console.WriteLine("Введите число 2");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);
            int result = a + b;
            Console.WriteLine("Сумма чисел = " + result);
        }
    }
}
