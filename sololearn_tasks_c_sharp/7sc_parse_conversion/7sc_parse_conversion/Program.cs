
using System.Globalization;
 using System;

namespace _7sc_parse_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1484";
            int a;
            bool result = int.TryParse(str, out a);
            if (result)
            {
                Console.WriteLine("Операция успешна, значение = "+ a);
            }
            else
            {
                Console.WriteLine("Не удалось конверитровать ");
               // Console.ReadLine();
            }

           // try
         //   {
          //      int a = Convert.ToInt32(str);
         //       Console.WriteLine("Успешная конвертация");
         //   }
            //catch (Exception)
           // {
           //     Console.WriteLine("Ошибка при конвертации");
           // }

           // double a = double.Parse(str);


            // NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            // {
            //     NumberDecimalSeparator = ".",
            //  };
        }
    }
}
