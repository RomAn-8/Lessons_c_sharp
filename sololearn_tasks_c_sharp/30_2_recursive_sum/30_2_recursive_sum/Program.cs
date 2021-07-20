/*Напишите программу, которая возьмет N чисел в качестве вводных данных и рекурсивно вычислит сумму всех чисел от 1 до N.

Пример вводных данных
5

Пример результата
15

Пояснение
5+4+3+2+1 = 15.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Sum(number));
        }
        
        static int Sum(int num)
        {
           if (num == 1) {
              return 1;
           }//завершите рекурсивный метод
           return num + Sum(num - 1);   
        } 
       
    }
}