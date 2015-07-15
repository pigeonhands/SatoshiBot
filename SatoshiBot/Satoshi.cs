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
    /// <summary>
    /// SatoshiMines API By BahNahNah
    /// uid=2388291
    /// </summary>
    class Satoshi
    {
        private HttpWebRequest _httpRequests;

        public GameData Data { get; private set; }
        public string PlayerHash { get; private set; }
        private DepositData _lastDepositData = null;

        public Satoshi(string hash)
        {
            PlayerHash = hash;
        }

        public void NewGame(int mines, decimal betSatoshi)
        {
            try
            {
                PrepRequest("https://satoshimines.com/action/newgame.php");
                byte[] newGameresponce =
                    Encoding.UTF8.GetBytes(
                        string.Format("player_hash={0}&bet={1}&num_mines={2}", PlayerHash, betSatoshi / 1000000,
                            mines));
                string responce = getPostResponce(newGameresponce);
                Data = Deserialize<GameData>(WebUtility.HtmlDecode(responce));
            }
            catch { Data = null; }
        }

        public BetData Bet(int squaer)
        {
            try
            {
                PrepRequest("https://satoshimines.com/action/checkboard.php");   
                byte[] betResponce =
                    Encoding.UTF8.GetBytes(
                        string.Format("game_hash={0}&guess={1}&v04=1", Data.game_hash, squaer));
                string responce = getPostResponce(betResponce);
                return Deserialize<BetData>(responce);
            }
            catch
            {
                return null;
            }
        }

        public CashOutData CashOut()
        {
            try
            {
                PrepRequest("https://satoshimines.com/action/cashout.php");   
                byte[] cashoutResponce =
                    Encoding.UTF8.GetBytes(
                        string.Format("game_hash={0}", Data.game_hash));
                string responce = getPostResponce(cashoutResponce);
                return Deserialize<CashOutData>(responce);
            }
            catch
            {
                return null;
            }
        }

        public DepositData GetDepositData()
        {
            if (_lastDepositData != null && _lastDepositData.status == "success")
                return _lastDepositData;
            try
            {
                PrepRequest("https://satoshimines.com/action/getaddr.php");   
                byte[] WithdrawResponce =
                    Encoding.UTF8.GetBytes(
                        string.Format("secret={0}", PlayerHash));
                string responce = getPostResponce(WithdrawResponce);
                return Deserialize<DepositData>(responce);
            }
            catch
            {
                return null;
            }
        }

        public void TryWithdraw(string BTCAddr, int AmmountSatoshi)
        {
            try
            {
                PrepRequest("https://satoshimines.com/action/full_cashout.php");   
                byte[] WithdrawResponce =
                    Encoding.UTF8.GetBytes(
                        string.Format("secret={0}&payto_address={1}&amount={2}", PlayerHash, BTCAddr, AmmountSatoshi / 1000000));
                getPostResponce(WithdrawResponce);
            }
            catch
            {
                
            }
        }

        private void PrepRequest(string url)
        {
            _httpRequests = (HttpWebRequest)WebRequest.Create(url);
            _httpRequests.Method = "POST";
            _httpRequests.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
        }

        private string getPostResponce(byte[] post)
        {
            _httpRequests.ContentLength = post.Length;
            using (Stream nStream = _httpRequests.GetRequestStream())
            {
                nStream.Write(post, 0, post.Length);
                nStream.Flush();
            }
            HttpWebResponse hhtpResounce = (HttpWebResponse)_httpRequests.GetResponse();
            StreamReader responceStream = new StreamReader(hhtpResounce.GetResponseStream());
            string responce = responceStream.ReadToEnd();
            return responce;
        }

        //https://gist.github.com/PatPositron/10076559
        private static T Deserialize<T>(string json)
        {
            var s = new DataContractJsonSerializer(typeof(T));
            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                return (T)s.ReadObject(ms);
            }
        }
    }

    public class GameData
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

    public class CashOutData
    {
        public string status { get; set; }
        public double win { get; set; }
        public string mines { get; set; }
        public string message { get; set; }
        public string random_string { get; set; }
        public string game_id { get; set; }
    }

    public class DepositData
    {
        public string status { get; set; }
        public string address { get; set; }
    }
    

}
