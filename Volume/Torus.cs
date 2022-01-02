using System;
using System.Collections.Generic;
using System.Text;

namespace Volume
{
    class Torus
    {
        public double r;
        public double R;

        public Torus(double r, double R)
        {
            this.r = r;
            this.R = R;

        }

        public double GetVolume()
        {
            return (float) 2 * Math.Pow(Math.PI, 2) * R * Math.Pow(r, 2);
        }

        public void PrintTorus()
        {
            if (R > r)
            {
                Console.WriteLine("The torus with r {0}, R {1} has the volume {2}", r, R, GetVolume());
            }
            else
            {
                Console.WriteLine("R cannot be shorter than r");
            }
        }
    }
}
