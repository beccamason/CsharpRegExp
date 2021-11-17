using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

namespace _2EmailExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\Rebecca.Mason\Documents\Corndel\SupportDocs\sample.txt");
            Regex rg = new Regex(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)\s");
            Dictionary<string, int> domainDictionary = new Dictionary<string, int>();
            foreach (Match match in rg.Matches(text))
            {
                string matchEmail = match.Value.Trim();
                int atLocation = matchEmail.IndexOf("@");
                string domain = matchEmail.Substring(atLocation);
                domainDictionary[domain] = domainDictionary.ContainsKey(domain) ? domainDictionary[domain] + 1 : 1;
            }

            Console.WriteLine(domainDictionary["@softwire.com"]);
        }
    }
}
