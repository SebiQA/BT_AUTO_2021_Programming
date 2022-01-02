using System;
using System.Collections.Generic;
using System.Text;

namespace Volume
{
    class Cylinder
    {
        public double r;
        public double h;

        public Cylinder(double r, double h)
        {
            this.r = r;
            this.h = h;

        }

        public double GetVolume()
        {
            return (float) Math.PI * Math.Pow(r, 2) * h;
        } 

        public void PrintCylinder()
        {
            Console.WriteLine("The cylinder with r {0}, h {1} has the volume {2}", r, h, GetVolume());
        }
    }
}
