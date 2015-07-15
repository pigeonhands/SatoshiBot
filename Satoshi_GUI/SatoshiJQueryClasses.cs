using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satoshi_GUI
{
    public class GameData
    {
        public string status { get; set; }
        public int id { get; set; }
        public string game_hash { get; set; }
        public string secret { get; set; }
        public int bet { get; set; }
        public int stake { get; set; }
        public int next { get; set; }
        public string betNumber { get; set; }
        public string gametype { get; set; }
        public int num_mines { get; set; }
        public string message { get; set; }
    }
    public class GameData2
    {
        public string status { get; set; }
        public int id { get; set; }
        public string game_hash { get; set; }
        public string secret { get; set; }
        public double bet { get; set; }
        public double stake { get; set; }
        public double next { get; set; }
        public string betNumber { get; set; }
        public string gametype { get; set; }
        public int num_mines { get; set; }
    }

    public class BetData2
    {
        public string status { get; set; }
        public int guess { get; set; }
        public string outcome { get; set; }
        public int stake { get; set; }
        public int next { get; set; }
        public string message { get; set; }
        public int change { get; set; }
        public string random_string { get; set; }
        public string game_id { get; set; }
    }
    public class BetData
    {
        public string status { get; set; }
        public int guess { get; set; }
        public string outcome { get; set; }
        public double stake { get; set; }
        public double next { get; set; }
        public string message { get; set; }
        public double change { get; set; }
    }
    public class CashOutData2
    {
        public string status { get; set; }
        public int win { get; set; }
        public string mines { get; set; }
        public string message { get; set; }
        public string random_string { get; set; }
        public string game_id { get; set; }
    }

    public class CashOutData
    {
        public string status { get; set; }
        public double win { get; set; }
        public string mines { get; set; }
        public string message { get; set; }
        public string random_string { get; set; }
        public string game_id { get; set; }
    }
}
