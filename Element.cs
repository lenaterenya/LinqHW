using System;
using System.Collections.Generic;
using System.Text;

namespace LinqHW
{
       class Element
    {
        public Point LeftUpperLocation { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }

        public override bool Equals(object? obj)
        {
            return string.Equals(this.GetHashCode(), obj?.GetHashCode());
        }

        
        public Element(Point location, int width, int length)
        {
            LeftUpperLocation = location;
            Width = width;
            Length = length;
        }


    

    }
}