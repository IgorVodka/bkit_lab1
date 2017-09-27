using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLab1
{
    class SquareRootFinder
    {
        public static SquareRootResult Calculate(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;

            if (D == 0)
            {
                return new SquareRootResult(
                    (-b) / 2 * a
                );
            }
            else if (D > 0)
            {
                return new SquareRootResult(
                    (-b - Math.Sqrt(D)) / 2 * a,
                    (-b + Math.Sqrt(D)) / 2 * a
                );
            }
            else
                return new ComplexSquareRootResult();
        }
    }
}
