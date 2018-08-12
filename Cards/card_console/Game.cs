﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card_console
{
    class Game
    {
        Random r = new Random();
        Dictionary<int, List<Karta>> one;
        List<Karta> Karts;
        List<Karta> k1;
        List<Karta> k2;
        Karta[] k3;
        //Player p1;
        //Player p2;
        Karta k;


        public Game()
        {
            one = new Dictionary<int, List<Karta>>();
            k1 = new List<Karta>();
            k2 = new List<Karta>();
            //p1 = new Player();
            //p2 = new Player();
            Karts = new List<Karta>();
            k = new Karta();
            k3 = new Karta[36];
            CreateKarts();
            F1();
            F2();
            Sorting();
            one.Add(1, k1);
            one.Add(2, k2);

        }



        void CreateKarts()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 6; j < 15; j++)
                {
                    Karts.Add(new Karta(i, j));
                }
            }
        }

        void F1()
        {
            for (int i = 0; i < 18; i++)
            {
                k1.Add(Karts[i]);
            }
        }

        void F2()
        {
            for (int i = 0; i < 18; i++)
            {
                k2.Add(Karts[35 - i]);
            }
        }

        void Sorting()
        {
            for (int i = 0; i < 36; i++)
            {
                while (true)
                {
                    k.Suit = r.Next(0, 4);
                    k.Type = r.Next(6, 14);

                    for (int j = 0; j < i; ++j)
                        if (k3[j] != k)
                            continue;

                    k3[i] = k;
                    break;
                }
                Karts.Remove(k);
                Karts.Add(k);
            }
        }

        public void Comp()
        {
            Sorting();
            F1();
            F2();

            for (int i = 0; k1.Count > 0 && k2.Count > 0; i++)
            {
                k1[k1.Count - 1].Show(k1[k1.Count - 1].Suit, k1[k1.Count - 1].Type);
                    Console.Write(" vs ");
                    k2[k2.Count - 1].Show(k2[k2.Count - 1].Suit, k2[k2.Count - 1].Type);

                if(k1[k1.Count - 1].Type > k2[k2.Count - 1].Type || k1[k1.Count - 1].Type == k2[k2.Count - 1].Type)
                {
                    Console.WriteLine("\nP1 take cards");
                    k1.Insert(0, k2[k2.Count - 1]);
                    k1.Insert(1, k1[k1.Count - 1]);
                    k2.Remove(k2[k2.Count - 1]);
                }
                else
                {
                    Console.WriteLine("\nP2 take cards");
                    k2.Insert(0, k1[k1.Count - 1]);
                    k2.Insert(1, k2[k2.Count - 1]);
                    k1.Remove(k1[k1.Count - 1]);
                }
                Console.WriteLine();
            }
            if(k1.Count == 0)
                Console.WriteLine("\nP2 win!");
            else
                Console.WriteLine("\nP1 win!");
        }
        

        /*
        public List<int> Players { get; set; }
        public List<Karta> Karts { get; set; }
        public Dictionary<int, Karta> Cards { get; set; }
        Karta k;
        Karta[] k1;

        public Game(int n)
        {
            List<int> Players = new List<int>();
            List<Karta> Karts = new List<Karta>();
            Dictionary<int, Karta> Cards = new Dictionary<int, Karta>();
            k = new Karta();
            k1 = new Karta[36];
            for (int i = 0; i < n; i++)
            {
                Players.Add(i);
            }

            CreateKarts();
        }

       

        

        void GiveOutCards()
        {
            for (int i = 0; i < 36 - Players.Count; i += Players.Count)
            {
                for (int j = 0; j < Players.Count; j++)
                {
                    Cards.Add(Players[j], Karts[i + j]);
                }
            }
        }

        void ComparisonCards()
        {
            if (Cards[Players[0]].Type < Cards[Players[1]].Type)
            {

            }
        }
        */
    }
}
