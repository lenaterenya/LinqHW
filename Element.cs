using System;
using System.Collections.Generic;
using System.Text;

namespace LinqHW
{
    public   class Element
    {
        public Point LeftUpperLocation { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }

        public override bool Equals(object? obj)
        {
            return string.Equals(this.GetHashCode(), obj?.GetHashCode());
        }

        public override int GetHashCode()
        {

            var one = Length.GetHashCode();
            var two = Width.GetHashCode();
            var three = GetType().GetHashCode();

            return Length.GetHashCode() + Width.GetHashCode() + LeftUpperLocation.X.GetHashCode() + LeftUpperLocation.Y.GetHashCode()
                   + GetType().GetHashCode();
        }
        public Element(Point location, int width, int length)
        {
            LeftUpperLocation = location;
            Width = width;
            Length = length;
        }


    

    }
}