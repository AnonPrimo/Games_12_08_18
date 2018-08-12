using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card_console
{
    class Karta
    {
        public int Suit { get; set; }
        public int Type { get; set; }

        public Karta() { }

        public Karta(int s, int t)
        {
            Suit = s;
            Type = t;
        }

        public void Show(int s, int t)
        {
            switch (s)
            {
                case 0:
                    Console.Write("Heart");
                    break;
                case 1:
                    Console.Write("Diamond");
                    break;
                case 2:
                    Console.Write("Club");
                    break;
                case 3:
                    Console.Write("Spade");
                    break;
                default:
                    break;
            }
            Console.Write(" - ");
            switch (t)
            {
                case 6:
                    Console.Write("6");
                    break;
                case 7:
                    Console.Write("7");
                    break;
                case 8:
                    Console.Write("8");
                    break;
                case 9:
                    Console.Write("9");
                    break;
                case 10:
                    Console.Write("10");
                    break;
                case 11:
                    Console.Write("Jack");
                    break;
                case 12:
                    Console.Write("Queen");
                    break;
                case 13:
                    Console.Write("King");
                    break;
                case 14:
                    Console.Write("Ace");
                    break;
                default:
                    break;
            }
        }
    }
}
