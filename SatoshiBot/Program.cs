using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace SatoshiBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Satoshi s = new Satoshi("a91335f18f9ffbddc5b98834040c715ff35cb83f");
            double lost = 0;
            double won = 0;
            Random r = new Random();
            while(true)
            {
                s.NewGame(5, 0);
                if (s.Data == null || s.Data.status != "success")
                {
                    Console.WriteLine("Failed.");
                    Console.ReadLine();
                    return;
                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Game started. Game type: {0} | Bombs: {1}", s.Data.gametype, s.Data.num_mines);
                Console.ForegroundColor = ConsoleColor.Blue;
                bool cashout = false;
                while (!cashout)
                {
                    int sq = r.Next(1, 24);
                    Console.WriteLine("betting square {0}", sq);
                    
                    BetData b = s.Bet(sq);
                    Console.WriteLine("Outome: {0}", b.outcome);
                    if (b.outcome == "bomb")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Lost {0}", b.stake);
                        lost ++;
                        break;
                    }
                    else
                    {
                        cashout = r.Next(0, 2) == 1;
                        if (cashout)
                        {
                            won++;
                            CashOutData co = s.CashOut();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(co.message);
                        }
                    }
                }
                if(won != 0 || lost != 0)
                    Console.WriteLine("Win percent: {0}% || Wins: {1} | Losses: {2}", (won / (won + lost)) * 100, won, lost);
                Console.WriteLine();
            }
        }
    }

    
}
