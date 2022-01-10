using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class BTException : Exception
    {
        string myCustomMessage;
        public BTException (string message)
        {
            this.myCustomMessage = "BT EXCEPTION " + message;
        }

        public BTException() : base("BT EXCEPTION ")
        {

        }

        public override string ToString()
        {
            return myCustomMessage + base.ToString();
        }
    }
}
