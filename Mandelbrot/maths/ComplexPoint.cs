using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot.maths
{
    internal class ComplexPoint
    {
        public double r;
        public double i;

        private double o_r;
        private double o_i;

        public ComplexPoint(double real, double imaginary)
        {
            this.r = real;
            this.i = imaginary;

            this.o_r = real;
            this.o_i = imaginary;
        }

        public double Abs()
        {
            return Math.Sqrt(this.r * this.r + this.i * this.i);
        }

        public void Square()
        {
            double _r = r * r - i * i;
            double _i = 2 * r * i;

            this.r = _r;
            this.i = _i;
        }

        public void SquarePlusC()
        {
            double _r = r * r - i * i;
            double _i = 2 * r * i;

            this.r = _r + o_r;
            this.i = _i + o_i;
        }

        public override String ToString()
        {
            return r.ToString() + " + " + i.ToString() + "i";
        }
    }
}
