using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Game
    {
        Random r = new Random();

        public List<int> Players { get; set; }
        public List<Karta> Karts { get; set; }
        public Dictionary<int, Karta> Cards { get; set; }

        public Game(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Players.Add(i);
            }
            CreateKarts();
        }

        void CreateKarts()
        {
            Karts.Add(new Karta(1, "6")); 
            Karts.Add(new Karta(1, "7"));
            Karts.Add(new Karta(1, "8"));
            Karts.Add(new Karta(1, "9"));
            Karts.Add(new Karta(1, "10"));
            Karts.Add(new Karta(1, "Valet"));
            Karts.Add(new Karta(1, "Queen"));
            Karts.Add(new Karta(1, "King"));
            Karts.Add(new Karta(1, "Ace"));
            Karts.Add(new Karta(2, "6"));
            Karts.Add(new Karta(2, "7"));
            Karts.Add(new Karta(2, "8"));
            Karts.Add(new Karta(2, "9"));
            Karts.Add(new Karta(2, "10"));
            Karts.Add(new Karta(2, "Valet"));
            Karts.Add(new Karta(2, "Queen"));
            Karts.Add(new Karta(2, "King"));
            Karts.Add(new Karta(2, "Ace"));
            Karts.Add(new Karta(3, "6"));
            Karts.Add(new Karta(3, "7"));
            Karts.Add(new Karta(3, "8"));
            Karts.Add(new Karta(3, "9"));
            Karts.Add(new Karta(3, "10"));
            Karts.Add(new Karta(3, "Valet"));
            Karts.Add(new Karta(3, "Queen"));
            Karts.Add(new Karta(3, "King"));
            Karts.Add(new Karta(3, "Ace"));
            Karts.Add(new Karta(4, "6"));
            Karts.Add(new Karta(4, "7"));
            Karts.Add(new Karta(4, "8"));
            Karts.Add(new Karta(4, "9"));
            Karts.Add(new Karta(4, "10"));
            Karts.Add(new Karta(4, "Valet"));
            Karts.Add(new Karta(4, "Queen"));
            Karts.Add(new Karta(4, "King"));
            Karts.Add(new Karta(4, "Ace"));

            for (int i = 0; i < 36; i++)
            {
                Cards.Add(i, Karts[i]);
            }
        }

        void Sorting()
        {
            for (int i = 0; i < 36; i++)
            {
                int a = r.Next(0, 35);
                

            }
        }

    }
}
