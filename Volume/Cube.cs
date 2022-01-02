using System;
using System.Collections.Generic;
using System.Text;

namespace Volume
{
    class Cube
    {
        public double l;

        public Cube(double l)
        {
            this.l = l;
        }
        public double GetVolume()
        {
            return Math.Pow(l, 3);
        }

        public void PrintCube()
        {
            Console.WriteLine("The cube with l {0} has the volume {1}", l, GetVolume());
        }
    }
}
