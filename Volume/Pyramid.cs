using System;
using System.Collections.Generic;
using System.Text;

namespace Volume
{
    class Pyramid
    {
        public double l;
        public double h;

        public Pyramid(double l, double h)
        {
            this.l = l;
            this.h = h;

        }

        public double GetVolume()
        {
            return (float)(1.0/3) * Math.Pow(l, 2) * h;
        }

        public void PrintPyramid()
        {
            Console.WriteLine("The pyramid with l {0}, h {1} has the volume {2}", l, h, GetVolume());
        }
    }
}
