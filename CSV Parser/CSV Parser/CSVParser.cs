using System;
using System.Text;

namespace CSV_Parser
{
    public static class CSVParser
    {
        public static void Parser(string line)
        {
            int counter = 0;
            while (counter < line.Length)
            {
                switch (line[counter])
                {
                    case ',':
                        break;

                    case '"':
                        StringBuilder quotedToken = new StringBuilder();
                        quotedToken.Append(line[counter]);
                        counter++;
                        
                        while (line[counter] != '"')
                        {
                            quotedToken.Append(line[counter]);
                            counter++;
                        }
                        quotedToken.Append(line[counter]);
                        Console.WriteLine(quotedToken);
                        break;
                        
                    default:
                        StringBuilder token = new StringBuilder();
                        while (line[counter] != ',')
                        {
                            token.Append(line[counter]);
                            counter++;

                            if (counter >= line.Length)
                                break;
                        }
                        Console.WriteLine(token);
                        break;
                }
                counter++;
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
