using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Building
{
    public class Floor
    {
        List<Room> rooms = new List<Room>();

        public Floor(List<Room> rooms)
        {
            this.rooms = rooms;
        }

        public Floor()
        {

        }

    internal List<Room> Rooms { get => rooms; set => rooms = value; }

    }
}
