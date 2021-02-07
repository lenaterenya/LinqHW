using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LinqHW
{
    public class Program
    {
        static void Main(string[] args)

        {
            var webpages = new List<WebPage>

            {
                new WebPage(new List<Element>
                {
                    new Button(new Point(3, 12), 5, 7, "yes"),
                    new Window(new Point(6, 14), 25, 40, "Home"),
                    new Menu(new Point(-5, 14), 23, 19),
                    new Image(new Point(11, 23), 10, 2, ".jpeg"),
                    new Image(new Point(16, 13), 45, 45, ".png"),
                    new Button(new Point(41, 54), 8, 14, "yes")
                }),
                new WebPage(new List<Element>
                {
                    new Window(new Point(3, 12), 11, 20, "Contacts"),
                    new Menu(new Point(-33, 14), 16, 12),
                    new Image(new Point(53, 77), 36, 40, ".jpeg")
                }),
                new WebPage(new List<Element>
                {
                    new Menu(new Point(13, 24), 23, 38),
                    new Window(new Point(23, 52), 19, 20, "About_Us"),
                    new Image(new Point(44, 37), 41, 40, ".jpeg")
                })
            };
            var website = new List<WebSite>
            {
                new WebSite(new List<WebPage>
                {
                    webpages[0],
                    webpages[1],
                    webpages[2]

                })
            };

            var points = webpages.Select(x => x.Elements.Select(x => (x.LeftUpperLocation, x.Width, x.Length)).OrderByDescending(x => x.LeftUpperLocation)).ToList();

            var points2 = webpages.Select(x => x.Elements
                    .Where(x => (x is Window)))
                    .Select(x => (x as Window))
                    .Where(x => (x.Length < 8 && x.Width > 14))
                    .Select(x => x.WindowName);

            WebPageHelper helper = new WebPageHelper();

            var x = helper.GetUniqueElements(webpages);
        }
    }
}
