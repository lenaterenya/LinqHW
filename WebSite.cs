using System;
using System.Collections.Generic;
using System.Text;

namespace LinqHW
{
   class WebSite
    {
        public List<WebPage> WebPages { get; set; }

        public WebSite(List<WebPage> webpages)
        {
            WebPages = webpages;
        }

    }
}

