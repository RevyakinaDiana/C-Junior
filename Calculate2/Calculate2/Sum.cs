using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate2
{
    class Metods
    {
        public static void summa(int a, int b)
        {
            Console.WriteLine("Введите 2 числа");
            a = Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("Сумма: " + c);
            Console.ReadKey();
        }
        public static void min(int a, int b)
        {
            Console.WriteLine("Введите 2 числа");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int c = a - b;
            Console.WriteLine("Разность: " + c);
            Console.ReadKey();
        }
        public static void mult(int a, int b)
        {
            Console.WriteLine("Введите 2 числа");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int c = a * b;
            Console.WriteLine("Произведение: " + c);
            Console.ReadKey();
        }
        public static void pow(int a, int b)
        {
            Console.WriteLine("Введите 2 числа");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Math.Pow(a, b));
            Console.WriteLine("А в степени В: " + c);
            Console.ReadKey();
        }
        public static void div(int a,int b)
        {
            Console.WriteLine("Введите 2 числа");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            double c = a / b;
                Console.WriteLine("Частное: " + c);
            Console.ReadKey();
        }
    }
}
