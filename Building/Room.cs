using System;
using System.Collections.Generic;
using System.Text;

 namespace Building
{
    public class Room
    {
        double roomArea;
        string[] accesories;
        double capacity;
        int windows;
        string orientation;

        public double RoomArea { get => roomArea; set => roomArea = value; }

        public string[] Accesories { get => accesories; set => accesories = value; }

        public double Capacity { get => capacity; set => capacity = value; }

        public int Windows { get => windows; set => windows = value; }

        public string Orientation { get => orientation; set => orientation = value; }

        public Room(double roomArea, string[] accesories, double capacity, int windows, string orientation)
        {
            this.roomArea = roomArea;
            this.accesories = accesories;
            this.capacity = capacity;
            this.windows = windows;
            this.orientation = orientation;
        }

        public Room()
        {

        }

    }
}
