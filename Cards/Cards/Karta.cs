﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
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

        public void Show()
        {
            switch (Suit)
            {
                case 0:
                    Console.WriteLine("Heart");
                    break;
                case 1:
                    Console.WriteLine("Diamond");
                    break;
                case 2:
                    Console.WriteLine("Club");
                    break;
                case 3:
                    Console.WriteLine("Spade");
                    break;
                default:
                    break;
            }
            Console.WriteLine(" - ");
            switch (Type)
            {
                case 6:
                    Console.WriteLine("6");
                    break;
                case 7:
                    Console.WriteLine("7");
                    break;
                case 8:
                    Console.WriteLine("8");
                    break;
                case 9:
                    Console.WriteLine("9");
                    break;
                case 10:
                    Console.WriteLine("10");
                    break;
                case 11:
                    Console.WriteLine("Jack");
                    break;
                case 12:
                    Console.WriteLine("Queen");
                    break;
                case 13:
                    Console.WriteLine("King");
                    break;
                case 14:
                    Console.WriteLine("Ace");
                    break;
                default:
                    break;
            }
        }
    }
}
