using System.IO;

namespace CSV_Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("test.txt");

            string line = sr.ReadLine();
            while (line != null)
            {
                CSVParser.Parser(line);
                line = sr.ReadLine();
            }
        }
    }
}
