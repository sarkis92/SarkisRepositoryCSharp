using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisNotebook
{
    class Player
    {
        public Player()
        {
            this.Opponents = new List<string>();
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public List<string> Opponents { get; set; }

        public int WinCount { get; set; }

        public int LossCount { get; set; }
    }
}
