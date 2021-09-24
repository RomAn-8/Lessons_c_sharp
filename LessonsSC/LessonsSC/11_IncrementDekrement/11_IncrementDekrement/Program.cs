using System;

namespace _11_IncrementDekrement
{//Инкремент и декремент
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int i = 0;
            int f = 1;
            a++;
            b--;
            ++c;
            f = ++f * f;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d++);
            Console.WriteLine(++i);
            Console.WriteLine(f);
        }
    }
}
