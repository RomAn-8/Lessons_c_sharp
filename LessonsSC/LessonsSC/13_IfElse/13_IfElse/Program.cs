using System;
// Конструкция if else

/*
if (утверждение или выражение)
{
   действие 1;
}
else
{
   действие 2;
}
 */
namespace _13_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isInfected = false;
            int a;

            a = int.Parse(Console.ReadLine());

            if (a == 5)
            {
                Console.WriteLine("a равна 5");
            }
            else
            {
                Console.WriteLine("a не равна 5 ");
            }

            if (isInfected)
            {
                Console.WriteLine("Персонаж инфицирован!");
            }
            else
            {
                Console.WriteLine("Персонаж здоров!");
            }

            
        }
    }
}
