using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot.maths
{
    internal class ComplexCircle : AbstractComplexFunction
    {
        private double _radius;
        public ComplexCircle(int max, double radius) : base(max)
        {
            _radius = radius;
        }

        public override int Calculate(ComplexPoint c)
        {
            return c.Abs() < _radius ? this.max : 0;
        }
    }
}
