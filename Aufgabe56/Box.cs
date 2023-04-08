using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe56
{
    internal class Box
    {
        int height;
        int length;

        public int FrontSurface
        { 
            get 
            {
                return length*height;
            }
        }

        public Box(int length, int height) 
        {
            this.length = length;
            this.height = height;
        }
    }
}
