using System;
using System.Collections.Generic;
using System.Text;

namespace Building
{
    class Building : AbstractBuilding
    {
        List<Floor> floors = new List<Floor>();
        const int max_cap = 300;

        public Building(List<Floor> floors )
        {
            this.floors = floors;
        }

        public Building()
        {

        }

        public double ComputingArea()
        {
            double area = 0;
            foreach (Floor f in floors)
            {
                foreach (Room r in f.Rooms)
                {
                    area = area + r.RoomArea;
                }
            }
            return area;
        }

        public int GetNumberofFloors()
        {
            return floors.Count; 
        }

        public int GetTotalNumberofRooms()
        {
            int totalRooms = 0;
            foreach(Floor f in floors)
            {
                totalRooms = totalRooms + f.Rooms.Count;
            }
            return totalRooms;
        }

        public double TotalCapacity()
        {
            double capacity = 0;
            foreach (Floor f in floors)
            {
                foreach (Room r in f.Rooms)
                {
                    capacity = capacity + r.Capacity;
                }
            }
            if (capacity > max_cap)
            {
                throw new Exception("The capacity is over maximum capacity");
            }
            return capacity;
        }

        public static void PrintBuilding(Building building)
        {
            Console.WriteLine("Number of rooms is {0}; The total built area is {1}; The total building capacity is {2}; The building number of floors is {3}", building.GetTotalNumberofRooms(), building.ComputingArea(), building.TotalCapacity(), building.GetNumberofFloors());
        }




    }
}
