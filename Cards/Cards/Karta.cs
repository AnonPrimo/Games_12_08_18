using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Karta
    {
        public int Suit { get; set; }
        public string Type { get; set; }

        public Karta(int s, string t)
        {
            Suit = s;
            Type = t;
        }
    }
}
