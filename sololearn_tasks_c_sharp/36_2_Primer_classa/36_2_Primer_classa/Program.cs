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
            //создайте объект Welcome с таким же именем
            Welcome welcome = new Welcome();

            welcome.WelcomeMessage();
        }
    }

    class Welcome
    {
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to OOP");//завершите класс и добавьте функцию WelcomeMessage()
        }
    }
}