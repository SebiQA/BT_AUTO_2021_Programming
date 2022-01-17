using System;
using System.Collections.Generic;
using System.Text;

namespace Building
{
    public class WorkingSpace : Room
    {
        public WorkingSpace()
        {
        }
        public WorkingSpace(double roomArea, string[] accesories, double capacity, int windows, string orientation) : base(roomArea, accesories, capacity, windows, orientation)
        {

        }
    }
}
