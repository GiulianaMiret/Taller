using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 1/1;
            num = Math.Atan(num);
            //num *= 180 / Math.PI;
            //num *= Math.PI / 180;
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
