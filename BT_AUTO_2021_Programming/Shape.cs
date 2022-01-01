﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Shape
    {
        ConsoleColor color;

        protected void Test()
        {

        }
        public virtual void Draw()
        {
            Console.WriteLine("We are drawing a shape");
        }

        public virtual void Erase()
        {
            Console.WriteLine("We are erasing a shape");
        }

        public ConsoleColor GetColor()
        {
            return color;
            
        }

        public void SetColor(ConsoleColor color)
        {
            this.color = color;
        }

        public override string ToString()
        {
            return "This is a generic shape";
        }

    }
}
