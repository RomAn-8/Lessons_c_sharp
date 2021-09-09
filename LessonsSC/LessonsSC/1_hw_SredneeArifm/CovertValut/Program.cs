using System;

namespace CovertValut
{
    class Program
    {
       // 3. Напишите просто конвертер валют
       //(без возможности динамического выбора валюты пользователем).
       // Валюты заданы хардкором и не изменяются. Тип валют на выбор программиста.
       
        static void Main(string[] args)
        {
            double UsdToRub = 73.44;

            double UsdToUah = 26.75;

            double USD;

            Console.WriteLine("Введите сумму в USD");

            USD = double.Parse(Console.ReadLine());

            Console.WriteLine(USD + " в RUB = " + USD * UsdToRub);

            Console.WriteLine(USD + " в UAH = " + USD * UsdToUah);
        }
    }
}
