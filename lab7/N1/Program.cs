using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    delegate int Operation(int x, int y);
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Додавання: 7 + 15");
            Operation add = (int x, int y) => x + y;
            int sum = add(7, 15);
            Console.WriteLine(sum);
            Console.WriteLine("Віднімання: 51 - 2");
            Operation sub = (int x, int y) => x - y;
            int diff = sub(51, 2);
            Console.WriteLine(diff);
            Console.WriteLine("Множення: 5 * 11");
            Operation mul = (x, y) => x * y;
            int prod = mul(5, 11);
            Console.WriteLine(prod);
            Console.WriteLine("Ділення: 1 / 0");
            Operation div = (x, y) =>
            {
                if (y == 0)
                    throw new DivideByZeroException("На нуль ділити не можна!");
                else return x / y;

            };
            int frac = div(1, 0);
            Console.WriteLine(frac);
        }
    }
}
