using Mandelbrot.maths;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot.helper
{
    internal class CoordinateSystem
    {
        private ComplexPoint upleft;
        private ComplexPoint downright;
        private double width;
        private double height;

        private double x_span;
        private double y_span;

        public CoordinateSystem(ComplexPoint upLeft, ComplexPoint downRight, int width, int height)
        {
            this.upleft = upLeft;
            this.downright = downRight;
            this.width = width;
            this.height = height;

            x_span = Math.Abs(upleft.r) + Math.Abs(downright.r);
            y_span = Math.Abs(upleft.i) + Math.Abs(downright.i);
        }

        public ComplexPoint PixelToComplex(int x, int y)
        {
            double r = (x / width) * x_span + upleft.r;
            double i = upleft.i - (y / height) * y_span;

            return new ComplexPoint(r, i);
        }

        public void resetSize(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
