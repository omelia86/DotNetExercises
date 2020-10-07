using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator.Add(2, 3);
            Console.ReadKey();
        }
    }
    class Calculator
    {
        public static void Add(int x, int y)
        {
            int z = x + y;
            Console.WriteLine($"Сумма {x} и {y} равна {z}");

        }
    }
}
