using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot.maths
{
    internal class MandelBrot : AbstractComplexFunction
    {
        private double _radius;
        public MandelBrot(int max) : base(max)
        {
        }

        public override int Calculate(ComplexPoint c)
        {
            int ctr = 0;

            while (ctr < max)
            {
                if (c.Abs() >= 2) break;

                c.SquarePlusC();
                ctr++;
            }

            return ctr;

        }
    }
}