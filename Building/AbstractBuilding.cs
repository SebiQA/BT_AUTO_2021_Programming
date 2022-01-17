using System;
using System.Collections.Generic;
using System.Text;

namespace Building
{
    class AbstractBuilding : IBuilding
    {

        double IBuilding.ComputingArea()
        {
            throw new NotImplementedException();
        }

        int IBuilding.GetNumberofFloors()
        {
            throw new NotImplementedException();
        }

        int IBuilding.GetTotalNumberofRooms()
        {
            throw new NotImplementedException();
        }

        double IBuilding.TotalCapacity()
        {
            throw new NotImplementedException();
        }
    }
}
