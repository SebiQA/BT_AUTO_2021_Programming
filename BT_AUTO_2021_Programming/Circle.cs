﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Circle
    {
        double radius;
        //const double PI = 3.1415;

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            //return Math.PI * radius * radius;
            return Math.PI * Math.Pow(radius, 2);

        }
        public void PrintCircle()
        {
            Console.WriteLine("The circle with radius {0} has the area {1}", radius, GetArea());
        }

    }
}