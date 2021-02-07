using System;
using System.Collections.Generic;
using System.Text;

namespace LinqHW
{
  class Image : Element
    {
        public string ImageType { get; set; }

        public Image(Point location, int width, int length, string imageType) : base(location, width, length)
        {
            ImageType = imageType;
        }
        public override int GetHashCode()
        {

            return ImageType.GetHashCode();

        }
    }
}
