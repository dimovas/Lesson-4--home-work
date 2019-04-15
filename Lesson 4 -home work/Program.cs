using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4__home_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }

        private static void Task1()
        {
            Console.WriteLine("Input a");
            int a = Convert.ToInt32(Console.ReadLine()), n = 0;
            int t = a;
            while(t > 0)
            {
                Console.WriteLine($"t%10 = {t%10}");
                t /= 10; 
                n++;               
            }
            Console.WriteLine($"Количество разрядов n = {n}");
            Console.WriteLine($"a = {a}, t = {t}");
        }
    }
}
