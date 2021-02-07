using System;
using System.Collections.Generic;
using System.Text;

namespace LinqHW
{
    class Button : Element
    {
        public string ButtonActivity { get; set; }

        public Button(Point location, int width, int length, string buttonActivity) : base(location, width, length)
        {
            ButtonActivity = buttonActivity;
        }

        public void ClickElement(string element)
        {

            Console.WriteLine(element);
        }
    }
}
