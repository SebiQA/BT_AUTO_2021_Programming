using System;
using System.Collections.Generic;
using System.Text;

namespace Building
{
    public class Kitchen : Room
    {
        public Kitchen()
        {

        }
        public Kitchen(double roomArea, string[] accesories, double capacity, int windows, string orientation) : base(roomArea, accesories, capacity, windows, orientation)
        {

        }
    }
}
