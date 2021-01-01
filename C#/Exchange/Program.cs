using System;
using System.Xml;
using System.Text;
using System.Xml.Linq;


namespace Exchange
{
    class Program
    {
        static string exchangeRate(string from, string to)
        {
            from = from.ToUpper();
            to = to.ToUpper();
            XmlDocument RssDocument = new XmlDocument();
            RssDocument.Load("http://www.nbg.ge/rss.php");

            StringBuilder Content = new StringBuilder();
            var what = RssDocument.SelectSingleNode("rss/channel/item/description");

            // descriptionshi xml nodebze wvdoma ar maqvs, CDATA-shi aqvt chasmuli description-i
            // gamosavali HTML Tree-d gadaqceva iqneboda CDATA-s informaciis, magram HTML-shic shecdomaa sadgac
            Content.Append(XElement.Parse(what.InnerText));
            return Content.ToString();


        }
        static void Main(string[] args)
        {
            Console.WriteLine(exchangeRate("eur", "usd"));
        }
    }
}
