using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovPrinciple
{
    class Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public int getArea() { return Length * Width; }
    }

    class Square : Rectangle
    {
        //Special square things...
    }
}
