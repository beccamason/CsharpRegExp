using System;
using System.Text.RegularExpressions;
using System.IO;

namespace _2EmailExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string emails = "";
            string text = File.ReadAllText(@"C:\Users\Rebecca.Mason\Documents\Corndel\SupportDocs\sample.txt");
            Regex rg = new Regex(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)");
            MatchCollection match = rg.Matches(text);
            
            for (int count = 0; count < match.Count; count++)
            {
                emails = emails + ", " + match[count].Value;
            }
            Console.WriteLine(emails);
        }

    }

}
