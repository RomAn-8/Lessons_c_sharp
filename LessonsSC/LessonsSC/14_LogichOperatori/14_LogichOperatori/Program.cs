using System;
// Логические операторы
//&& сокр. и, || сокр. или, & и, | или, ! не


namespace _14_LogichOperatori
{
    class Program
    {
        public static bool GetTemperature()
        {
            return true;
        }

        public static bool GetCoolingStatus()
        {
            return true;
        }
        static void Main(string[] args)
        {
            if (GetTemperature() | GetCoolingStatus())
            {
                Console.WriteLine("Угроза повреждения процессора!!!");
            }










            /*  int fanspeed = 0;

              bool isHighTemperature = true;

              bool hasNoCooling = fanspeed <=0;

              if (isHighTemperature || hasNoCooling)
              {
                  Console.WriteLine("Угроза повреждения процессора!!!");
              }
            */




            /*
             bool isInfected = false;

            if (!isInfected)
            {
                Console.WriteLine("Персонаж здоров!");
            }
            else
            {
                Console.WriteLine("Персонаж инфицирован!");
            }
            */
        }
    }
}
