using System;
using System.Collections.Generic;
using System.Text;

namespace LinqHW
{
    class Window : Element
    {
        public string WindowName { get; set; }

        public Window(Point location, int width, int length, string windowName) : base(location, width, length)
        {
            WindowName = windowName;
        }
    }
}
