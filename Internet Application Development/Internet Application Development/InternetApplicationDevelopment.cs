using System;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace InternetApplicationDevelopment
{
    public class Crawler
    {
        private static string url;
        public static string[] CrawlToGetHyperlinks(string url)
        {
            Crawler.url = url;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string html = reader.ReadToEnd();
            string[] links = Crawler.Extract("(href=\")[^\"]*(\")", html);
            return links;
        }

        private static string[] Extract(string pattern, string html)
        {
            Regex regex = new Regex(pattern);
            Match match = regex.Match(html);
            if (!match.Success) return new string[] {};
            List<string> links = new List<string>();
            do
            {
                string link = Crawler.Extract(match.Value.ToString());
                switch (HyperLink.CategorizeLink(link))
                {
                    case HyperLink.Category.NEW:
                        break;
                    case HyperLink.Category.CONCATENATABLE:
                        link = Crawler.url + "/" + link;
                        break;
                }

                if (!links.Contains(link)) links.Add(link);
                match = match.NextMatch();
            } while (match.Success);

            return links.ToArray();
        }

        private static string Extract(string link)
        {
            return link.Substring(6, (link.Length - 6 - 1));
        }
    }

    public static class HyperLink
    {
        internal enum Category { CONCATENATABLE, NEW }
        internal static Category CategorizeLink(string link)
        {
            Regex regex = new Regex("(http(s?)://)[^\"]*");
            Match match = regex.Match(link);
            if (match.Success) return Category.NEW;
            else return Category.CONCATENATABLE;
        }

        public static bool VerifyHyperlink(string link)
        {
            Regex regex = new Regex("(http://)[^\"]*");
            Match match = regex.Match(link);
            return match.Success;
        }

    }

    class Program
    {
        static void Main()
        {
            foreach (string link in Crawler.CrawlToGetHyperlinks("http://www.gsmarena.com"))
                Console.WriteLine(link);
        }
    }
}
