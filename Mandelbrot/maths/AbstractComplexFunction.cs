using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot.maths
{
    internal abstract class AbstractComplexFunction
    {
        protected int max;

        public AbstractComplexFunction(int max)
        {
            this.max = max;
        }

        public abstract int Calculate(ComplexPoint c);
    }
}
