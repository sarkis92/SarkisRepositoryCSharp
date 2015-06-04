using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractHyperLinks
{
    class ExtractHyperLinks
    {
        static void Main(string[] args)
        {



            string pattern = @"(?:<a)(?:[\s\n_0-9a-zA-Z=""()]*?.*?)(?:href([\s\n]*)?=(?:['""\s\n]*)?)([a-zA-Z:#\/._\-0-9!?=^+]*(\([""'a-zA-Z\s.()0-9]*\))?)(?:[\s\na-zA-Z=""()0-9]*.*?)?(?:\>)";

            StringBuilder text = new StringBuilder();
            while (true)
            {
                String input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                text.Append(input);
                text.Append("\n");
            }
            
            Regex reg = new Regex(pattern);

           
            Match match = reg.Match(text.ToString());
            List<string> links = new List<string>();

            while (match.Success)
            {
                // .....fake....lo6o
                if (!(match.Groups[2].Value == "fake"))
                {
                    links.Add(match.Groups[2].Value);
                }
                match = match.NextMatch();
            }


            foreach (var item in links)
            {
                Console.WriteLine(item);
            }
        }
    }
}
