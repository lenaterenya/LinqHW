using System.Collections.Generic;

namespace LinqHW
{
    public class WebPage 
     {
        public List<Element> Elements { get; set; }

        public WebPage(List<Element> elements)
        {
            Elements = elements;
        }

      }
    }


        