using System;

namespace SharpLab1
{
    class SquareRootResult
    {
        protected int roots = 0;
        protected double x1 = 0;
        protected double x2 = 0;

        public SquareRootResult() { }

        public SquareRootResult(double x)
        {
            this.x1 = this.x2 = x;
            this.roots = 1;
        }

        public SquareRootResult(double x1, double x2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.roots = 2;
        }

        public bool Calculated
        {
            get
            {
                return this.roots > 0;
            }
        }

        public int Roots
        {
            get
            {
                return this.roots;
            }
        }

        public double X1
        {
            get
            {
                if (!Calculated)
                    throw new Exception("Square root is not calculated yet.");
                return this.x1;
            }
        }

        public double X2
        {
            get
            {
                if (!Calculated)
                    throw new Exception("Square root is not calculated yet.");
                return this.x2;
            }
        }
    }
}