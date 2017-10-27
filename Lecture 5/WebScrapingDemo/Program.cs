using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebScrapingDemo
{
    class Program
    {
        const string UsdTag = "100px;\">USD";

        static string GetContent()
        {
            WebClient client = new WebClient();
            using (var stream = client.OpenRead(@"http://www.mediapool.bg"))
            {
                StreamReader streamReader = new StreamReader(stream);
                return streamReader.ReadToEnd();
            }
        }

        static decimal GetUSDRate(Task<string> prior)
        {
            string content = prior.Result;
            int tagIndex = content.IndexOf(UsdTag);
            int rateStartsAt = tagIndex + UsdTag.Length;
            int rateEndsAt = content.IndexOf("</div>", rateStartsAt);
            string rateString = content.Substring(rateStartsAt, rateEndsAt - rateStartsAt);
            var ic = System.Globalization.CultureInfo.InvariantCulture;
            return decimal.Parse(rateString, ic);
        }

        static void Main(string[] args)
        {
            var t1 = new Task<string>(GetContent);
            var t2 = t1.ContinueWith(GetUSDRate);
            t1.Start();

            Console.WriteLine($"Today, 1 USD is: {t2.Result} BGN.");
            Console.ReadLine();
        }
    }
}
