using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexDemo
{
    class Complex
    {
        public int Real { get; }
        public int Imaginary { get; }
        public double Argument
        {
            get
            {
                return Math.Atan((double)Real / Imaginary);
            }
        }
        public double Modulus
        {
            get { return Math.Sqrt(Real * Real + Imaginary * Imaginary); }
        }
        public Complex(int real = 0, int imaginary = 0)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public override string ToString()
        {
            return $"<{Real}, {Imaginary}>";
        }
        public static Complex operator +(Complex lhs, Complex rhs)
        {
            return new Complex(lhs.Real + rhs.Real, lhs.Imaginary + rhs.Imaginary);
        }
        public static Complex operator -(Complex lhs, Complex rhs)
        {
            return new Complex(lhs.Real - rhs.Real, lhs.Imaginary - rhs.Imaginary);
        }
        public static bool operator ==(Complex lhs, Complex rhs)
        {
            return lhs.Real == rhs.Real && lhs.Imaginary == rhs.Imaginary;
        }
        public static bool operator !=(Complex lhs, Complex rhs)
        {
            return lhs.Real != rhs.Real || lhs.Imaginary != rhs.Imaginary;
        }
        public static Complex operator -(Complex complex)
        {
            return new Complex(-complex.Real, -complex.Imaginary);
        }
    }
}
