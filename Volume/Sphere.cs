using System;
using System.Collections.Generic;
using System.Text;

namespace Volume
{
    class Sphere
    {
        public double r;

        public Sphere(double r)
        {
            this.r = r;
        }

        public double GetVolume()
        {
            return (float)(4.0 / 3) * Math.PI * Math.Pow(r, 3);
        }

        public void PrintSphere()
        {
            Console.WriteLine("The sphere with radius {0} has the volume {1}", r, GetVolume());
        }
    }
}
