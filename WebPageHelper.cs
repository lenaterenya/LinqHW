using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqHW
{
    public class WebPageHelper
    {
        public List<Element> GetUniqueElements(List<WebPage> webPages)
        {
            var elementDictionary = new Dictionary<int, Element>();

            foreach (var element in webPages.SelectMany(webpage => webpage.Elements))
            {
                try
                {
                    elementDictionary.Add(element.GetHashCode(), element);
                }
                catch (Exception e)
                {
                    //Console.WriteLine(element.Length + " " + element.Width + " " + element.GetType() + " " + element.GetHashCode());
                    continue;
                }
            }

            return elementDictionary.Values.ToList();
        }
    }
}

