using System;

namespace Volume
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube c1 = new Cube(3);
            c1.PrintCube();

            Sphere s1 = new Sphere(5);
            s1.PrintSphere();

            Pyramid p1 = new Pyramid(2, 3);
            p1.PrintPyramid();

            Cylinder cy1 = new Cylinder (4, 5);
            cy1.PrintCylinder();

            Torus t1 = new Torus(4, 5);
            t1.PrintTorus();
        }
    }
}
