using System;

namespace _2_ProverkaChetnosti
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());
           
            if (a % 2 == 0)
            {
                Console.WriteLine("a чётное число");
            }
            else
            {
                Console.WriteLine("a нечётное число");
            }
        }
    }
}
