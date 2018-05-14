using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate2
{
    class Program
    {
        static int a; static int b;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Выберите операцию - Sum, Min, Pow, Mult, Div");
          string result= Console.ReadLine();
            if(result =="Sum")
                {
                Metods.summa(a, b);            
                 }
          
            if(result=="Min")
            {
                Metods.min(a, b);
            }
            if(result=="Mult")
            {
                Metods.mult(a, b);
            }
            if(result=="Pow")
            {
                Metods.pow(a, b);
            }
            if(result=="Div")

            {
                Metods.div(a, b);
            }
        }
    }
}
