using System;
using System.Collections.Generic;
using System.Text;

namespace Building
{
    interface IBuilding
    {
        public double ComputingArea();


        public int GetNumberofFloors();


        public int GetTotalNumberofRooms();


        public double TotalCapacity();

    }
}
