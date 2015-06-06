using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcCatalog
{
    class Test
    {
        static void Main(string[] args)
        {

            List<Computer> computers = new List<Computer>();
            computers.Add(new Computer("Razer"));
            computers.Add(new Computer("Dell"));
            computers.Add(new Computer("TEST"));
            computers.Sort((x, y) => x.Price.CompareTo(y.Price));

            foreach (var item in computers)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

        }
    }
}
