using System;
using System.Collections.Generic;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            DefineBuilding();
        }

        public static void DefineBuilding()
        {
            string[] dsa = { "chairs", "boxes", "cleaningSupplies" };
            string[] ka = { "chairs", "tables", "sink", "fridge", "oven", "trashCan" };
            string[] mra = { "chairs", "tables", "whiteBoard", "computer", "videoRecorder", "trashCan" };
            string[] wsa1 = { "chairs", "tables", "whiteBoard", "computer", "trashCan" };
            string[] wsa2 = { "chairs", "tables", "whiteBoard", "computer", "trashCan" };

            List<Room> rooms = new List<Room>();

            rooms.AddRange(new List<Room>
            {
                new DepositSpace (5, dsa, 10, 0, "north"),
                new Kitchen(10, ka, 30, 2, "south"),
                new MeetingRoom(50, mra, 100, 4, "east"),
                new WorkingSpace(100, wsa1, 500, 10, "west"),
                new WorkingSpace(100, wsa2, 500, 10, "west")
            });

            List<Floor> floors = new List<Floor>();
            floors.AddRange(new List<Floor>
            {
                new Floor (rooms),
                new Floor (rooms),
                new Floor (rooms),
                new Floor (rooms),
                new Floor (rooms)
            });

            Building building = new Building(floors);
            try
            {
                Building.PrintBuilding(building);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception, the capacity is over maximum capacity");
            }
        }

    }
}
