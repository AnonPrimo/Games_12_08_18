using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card_console
{
    class Game_ver_2
    {
        Random r = new Random();
        Karta []k = new Karta[36];
        int a, b;
        bool TorF = true;
        Karta[] p1 = new Karta[18];
        Karta[] p2 = new Karta[18];
        Karta tmp = new Karta();


        public Game_ver_2()
        {
            for (int i = 0; i < k.Length; i++)
            {
                k[i] = new Karta();
                TorF = true;
                while (TorF)
                {
                    TorF = false;
                    a = r.Next(0, 4);
                    b = r.Next(6, 15);

                   for(int j = 0; j < i; ++j)
                    {
                        if ((k[j].Suit == a) && (k[j].Type == b))
                            TorF = true;
                    }
                }
                if (i < 18)
                {
                    p1[i] = new Karta();
                   p1[i].Suit = a;
                   p1[i].Type = b;
                }
                else
                {
                    p2[i-18] = new Karta();
                    p2[i-18].Suit = a;
                    p2[i-18].Type = b;
                }

                k[i].Suit = a;
                k[i].Type = b;
            }

        }

            public void show()
        {
            for (int i = 0; i < k.Length; i++)
            {
                k[i].Show(k[i].Suit, k[i].Type);
                Console.WriteLine();
            }
        } 

        public void Start()
        {
            for (int i = 0; (p1.Length > 0) || (p2.Length > 0); i++)
            {
                p1[p1.Length - 1].Show(p1[p1.Length - 1].Suit, p1[p1.Length - 1].Type);
                Console.Write(" vs ");
                p2[p2.Length - 1].Show(p2[p2.Length - 1].Suit, p2[p2.Length - 1].Type);

                if(p2[p2.Length - 1].Type <= p1[p1.Length - 1].Type)
                {
                    Console.WriteLine("\nP1 take cards");
                    Array.Resize(ref(p1), p1.Length + 1);

                    tmp = p1[p1.Length - 2 ];

                    for (int j = p1.Length - 1; j > 1; j--)
                    {
                        p1[j] = p1[j - 2];
                    }
                    p1[1] = tmp;
                    p1[0] = p2[p2.Length - 1];

                    Array.Resize(ref (p2), p2.Length - 1);
                    if (p2.Length == 0)
                        break;
                    tmp = p2[p2.Length - 1];

                    for (int j = p2.Length - 1; j > 0; j--)
                    {
                        p2[j] = p2[j - 1];
                    }

                    p2[0] = tmp;
                }
                else
                if (p2[p2.Length - 1].Type > p1[p1.Length - 1].Type)
                {
                    Console.WriteLine("\nP2 take cards");

                    Array.Resize(ref (p2), p2.Length + 1);

                    tmp = p2[p2.Length - 2];

                    for (int j = p2.Length - 1; j > 1; j--)
                    {
                        p2[j] = p2[j - 2];
                    }
                    p2[1] = tmp;
                    p2[0] = p1[p1.Length - 1];

                    Array.Resize(ref (p1), p1.Length - 1);
                    if (p1.Length == 0)
                        break;
                    tmp = p1[p1.Length - 1];

                    for (int j = p1.Length - 1; j > 0; j--)
                    {
                        p1[j] = p1[j - 1];
                    }

                    p1[0] = tmp;
                }
            }

            if(p1.Length == 0)
                Console.WriteLine("\nP2 win!");
            else
                if(p2.Length == 0)
                Console.WriteLine("\nP1 win!");
        }
       
    }
}
