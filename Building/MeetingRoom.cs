using System;
using System.Collections.Generic;
using System.Text;

namespace Building
{
    public class MeetingRoom : Room
    {
        MeetingRoom()
        {

        }
        public MeetingRoom(double roomArea, string[] accesories, double capacity, int windows, string orientation) : base(roomArea, accesories, capacity, windows, orientation)
        {

        }
    }
}
