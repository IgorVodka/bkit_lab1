using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLab1
{
    class Program
    {
        static bool TryInputVariable(string name, out double result)
        {
            Console.WriteLine("Введите {0}:", name);
            return double.TryParse(Console.ReadLine(), out result);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                double a = 0;
                double b = 0;
                double c = 0;

                bool parsingResult = false;

                while (parsingResult = !TryInputVariable("a", out a)) ;
                while (parsingResult = !TryInputVariable("b", out b)) ;
                while (parsingResult = !TryInputVariable("c", out c)) ;

                var result = SquareRootFinder.Calculate(a, b, c);

                if (result.Roots == 1)
                {
                    Console.WriteLine("X is {0}", result.X1);
                }
                else if(result.Roots == 2)
                {
                    Console.WriteLine("X1 is {0}", result.X1);
                    Console.WriteLine("X2 is {0}", result.X2);
                }
                else if(result is ComplexSquareRootResult)
                {
                    Console.WriteLine("No real roots found.");
                }

                Console.ReadKey(true);
            }
        }
    }
}
