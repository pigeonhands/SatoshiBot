using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Net;
using System.Globalization;
using System.Threading;

namespace Satoshi_GUI
{
    public delegate void OnRemoveCallback(gamePanel sender);
    public partial class gamePanel : UserControl
    {
        private double wins = 0;
        private double loss = 0;
        private decimal BasebetCost = 0;
        private int currentBetStreak = 0;
        private int currentPlayStreak = 0;

        public event OnRemoveCallback OnRemove;
        public event SaveLogDelegate SaveLog;

        AutoResetEvent pauser = new AutoResetEvent(false);
        private GameSettings GameConfig;
        private GameData Data;
        private Random r = new Random();
        private HttpWebRequest _httpRequest;
        
        private bool running = false;
        string lastResponce = string.Empty;
        string lastSent = string.Empty;

        private decimal multiplyOnLoss = 1;
        private int stratergyIndex = 0;
        private bool notFirstClear = false;
        private bool IsWaiting = false;

        public gamePanel()
        {
            GameConfig = new GameSettings();
            InitializeComponent();
            Log("Welcome to BanowBot");
            Log("uid=2388291");
        }

        public gamePanel(bool hideStop)
        {
            GameConfig = new GameSettings();
            InitializeComponent();
            Log("Welcome to BanowBot");
            Log("uid=2388291");
            if (hideStop)
            {
                button2.Visible = false;
               // button1.Location = new Point(147, 19);
               // button1.Width = 307;
            }
        }

        public void StopRunning()
        {
            running = false;
        }

        public gamePanel(SettingsForm sf)
        {
            GameConfig = new GameSettings();
            InitializeComponent();
            Log("Welcome to BanowBot");
            Log("uid=2388291");
            GameConfig = sf.GameConfig;
            BasebetCost = GameConfig.BetCost / 1000000;
            GameConfig.BetCost = BasebetCost;
            multiplyOnLoss = GameConfig.PercentOnLoss / 100;
            stratergyIndex = 0;
            gameGroupBox.Text = GameConfig.ConfigTag;
            sf.Dispose();
            Log("Starting...");
            PrepRequest("https://satoshimines.com/action/newgame.php");
            byte[] newGameresponce = Bcodes("player_hash={0}&bet={1}&num_mines={2}", GameConfig.PlayerHash, GameConfig.BetCost.ToString("0.000000", new CultureInfo("en-US")),
                GameConfig.BombCount);
            running = true;
            button1.Text = "Stop after game.";
            getPostResponce(newGameresponce, EndNewGameResponce);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                currentPlayStreak = 0;
                using (SettingsForm sf = new SettingsForm(Global.DefaultGameSettings))
                {
                    if (sf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                        return;
                    GameConfig = sf.GameConfig;
                    BasebetCost = GameConfig.BetCost / 1000000;
                    GameConfig.BetCost = BasebetCost;
                    multiplyOnLoss = GameConfig.PercentOnLoss / 100;
                    stratergyIndex = 0;
                    gameGroupBox.Text = GameConfig.ConfigTag;
                }
                // button1.Enabled = false;
                Log("Starting...");

                
                running = true;
                button1.Text = "Stop after game.";
                PrepRequest("https://satoshimines.com/action/newgame.php");
                byte[] newGameresponce = Bcodes("player_hash={0}&bet={1}&num_mines={2}", GameConfig.PlayerHash, GameConfig.BetCost.ToString("0.000000", new CultureInfo("en-US")),
                    GameConfig.BombCount);
                getPostResponce(newGameresponce, EndNewGameResponce);
            }
            else
            {
                button1.Text = "Stopping after game...";
                button1.Enabled = false;
                running = false;
            }
        }

        private void AddWin()
        {
            wins++;
            ShowWinLosStats();
        }

        private void AddLoss()
        {
            loss++;
            ShowWinLosStats();
        }

        private void ShowWinLosStats()
        {
            this.Invoke((MethodInvoker)delegate()
            {
                double percent = 0;
                if (wins != 0 || loss != 0)
                    percent = (wins / (wins + loss)) * 100;
                winStats.Text = string.Format("{0}% | Wins: {1} | Losses: {2}", Math.Round(percent, 2), wins, loss);
            });
        }

        public void ClearLog(bool save)
        {
            string[] log = new string[] { };
            this.Invoke((MethodInvoker) delegate()
            {
                log = outputLog.Lines;
                outputLog.Clear();
            });
            if (SaveLog != null && GameConfig.SaveLogToFile && save)
                SaveLog(log);
        }

        public void SaveLogDisk()
        {
            string[] log = new string[] { };
            this.Invoke((MethodInvoker)delegate ()
            {
                log = outputLog.Lines;
            });
            if (SaveLog != null && GameConfig.SaveLogToFile)
                SaveLog(log);
        }

        public void Log(string input, params object[] format)
        {
            try
            {
                string fStr = string.Format(input, format);
                if (this.InvokeRequired)
                {
                    this.Invoke((MethodInvoker) delegate()
                    {
                        outputLog.AppendText(fStr + "\r\n");
                        outputLog.SelectionStart = outputLog.Text.Length;
                        outputLog.ScrollToCaret();
                    });
                }
                else
                {
                    outputLog.AppendText(fStr + "\r\n");
                    outputLog.SelectionStart = outputLog.Text.Length;
                    outputLog.ScrollToCaret();
                }
            }
            catch { }
        }
        public byte[] Bcodes(string c, params object[] formatting)
        {
            byte[] ret = Encoding.UTF8.GetBytes(string.Format(c, formatting));
            formatting[0] = "ProtectHash";
            lastSent = string.Format(c, formatting);
            return ret;
        }

        public int getNextSquare()
        {
            if (GameConfig.UseStrat)
            {
                lock (this)
                {
                    
                    if ((GameConfig.StratergySquares.Length == 1) || (stratergyIndex > GameConfig.StratergySquares.Length - 2))
                        stratergyIndex = 0;
                    else
                        stratergyIndex++;
                    return GameConfig.StratergySquares[stratergyIndex] + 1;
                }
            }
            int i = r.Next(1, 26);
            try
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    while (!gameSquares.IsIdle(i - 1))
                        i = r.Next(1, 26);
                });
            }
            catch
            {
                i = r.Next(1, 26);
            }
            return i;
        }

        public void glowSquare(int s)
        {
            this.Invoke((MethodInvoker)delegate()
            {
                gameSquares.SetSquare(s - 1, Brushes.Green);
            });
        }

        public void bombSquare(int s)
        {
            this.Invoke((MethodInvoker)delegate()
            {
                gameSquares.SetSquare(s - 1, Brushes.Red);
            });
        }
        public void FadebombSquare(int s)
        {
            this.Invoke((MethodInvoker)delegate()
            {
                if (!gameSquares.IsIdle(s - 1))
                    return;
                gameSquares.SetSquare(s - 1, Brushes.LightSalmon);
            });
        }

        public void clearSquares()
        {
            this.Invoke((MethodInvoker)delegate()
            {
                gameSquares.Reset();
            });
        }

        public void clearSquare(int s)
        {
            this.Invoke((MethodInvoker)delegate()
            {
                gameSquares.IdleSquare(s - 1);
            });
        }

        private void endCashoutResponce(IAsyncResult AR)
        {
            try
            {
                CashOutData cd;
                HttpWebResponse httpResponce = (HttpWebResponse)_httpRequest.EndGetResponse(AR);
                using (StreamReader sr = new StreamReader(httpResponce.GetResponseStream()))
                {
                    lastResponce = sr.ReadToEnd();
                    cd = Deserialize<CashOutData>(lastResponce);
                }
                httpResponce.Close();
                if (cd == null || cd.status != "success")
                    throw new Exception();
                if (GameConfig.ShowGameBombs)
                {
                    string[] bmbz = cd.mines.Split('-');
                    foreach (string s in bmbz)
                    {
                        int bS;
                        if (int.TryParse(s, out bS))
                            FadebombSquare(bS);
                    }
                }
                Log(cd.message);
                string url = string.Format("https://satoshimines.com/s/{0}/{1}/", cd.game_id, cd.random_string);
                Log("Url: {0}", url);
                AddWin();
                bool ShouldStop = false;
                var data = BalanceStopShouldStop(out ShouldStop);

                if (GameConfig.StopAfterWin && running)
                {
                    Log("Stop After win is enabled... Stopping...");
                    SaveLogDisk();
                    notFirstClear = false;
                    running = false;
                }
                else if (ShouldStop && !running)
                {
                    Log("Balance level met ({0} bits)... Stopping...", data.balance);
                    SaveLogDisk();
                    notFirstClear = false;
                    running = false;
                }

                CheckLastGame();

                Log("");
                int betSquare = getNextSquare();
                PrepRequest("https://satoshimines.com/action/newgame.php");
                byte[] newGameresponce =
                        Bcodes("player_hash={0}&bet={1}&num_mines={2}", GameConfig.PlayerHash, GameConfig.BetCost.ToString("0.000000", new CultureInfo("en-US")),
                            GameConfig.BombCount);
                if (running)
                    getPostResponce(newGameresponce, EndNewGameResponce);
                else
                    BSta(true);
            }
            catch(Exception ex)
            {
                if (GameConfig.ShowExceptionWindow)
                {
                    using (ExceptionForm except = new ExceptionForm(ex.ToString()))
                    {
                        except.ShowDialog();
                    }
                }
                Log("Failed to cashout.");
                BSta(true);
            }
        }

        BalanceData BalanceStopShouldStop(out bool ShouldStop)
        {
            try
            {
                if(!GameConfig.CheckBalance)
                {
                    ShouldStop = false;
                    return null;
                }
                Log("Checking balance...");
                string resp = string.Empty;
                string Parameters = string.Format("secret={0}", GameConfig.PlayerHash);
                using (WebClient wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    resp = wc.UploadString(new Uri("https://satoshimines.com/action/refresh_balance.php"), "POST", Parameters);
                }
                BalanceData bd = Deserialize<BalanceData>(resp);
                if (bd == null || bd.status != "success")
                {
                    ShouldStop = false;
                    return null;
                }

                float checkVal = bd.balance * 1000000;

                if(GameConfig.BalanceStopAbove != -1)
                {
                    if(checkVal > GameConfig.BalanceStopAbove)
                    {
                        ShouldStop = true;
                        return bd;
                    }
                }

                if(GameConfig.BalanceStopBelow != -1)
                {
                    if(checkVal < GameConfig.BalanceStopBelow)
                    {
                        ShouldStop = true;
                        return bd;
                    }
                }

                ShouldStop = false;
                return null;
            }
            catch
            {
                ShouldStop = false;
                return null;
            }
            
        }

        void CheckLastGame()
        {
            if (GameConfig.StopAfterGames && running)
            {
                currentPlayStreak ++;
                if (currentPlayStreak > GameConfig.StopAfterGamesAmmount -1)
                {
                    Log("Completed {0} games... Stopping...", currentPlayStreak);
                    SaveLogDisk();
                    notFirstClear = false;
                    running = false;
                }
            }
        }
        private void EndBetResponce(IAsyncResult AR)
        {
            try
            {
                BetData bd;
                HttpWebResponse httpResponce = (HttpWebResponse)_httpRequest.EndGetResponse(AR);
                using (StreamReader sr = new StreamReader(httpResponce.GetResponseStream()))
                {
                    bd = Deserialize<BetData>(sr.ReadToEnd());
                }
                if (bd == null || bd.status != "success")
                    throw new Exception();

                
                

                if (bd.outcome == "bomb")
                {
                    bombSquare(bd.guess);
                    AddLoss();
                    Log("Bomb. Loss: {0}", bd.stake);
                    if (GameConfig.ShowGameBombs)
                    {
                        string[] bmbz = bd.bombs.Split('-');
                        foreach (string s in bmbz)
                        {
                            int bS;
                            if (int.TryParse(s, out bS))
                                FadebombSquare(bS);
                        }
                    }

                    bool ShouldStop = false;
                    var data = BalanceStopShouldStop(out ShouldStop);

                    CheckLastGame();

                    if (GameConfig.StopAfterLoss && !running)
                    {
                        Log("Stop After loss is enabled... Stopping...");
                        SaveLogDisk();
                        notFirstClear = false;
                        running = false;
                        BSta(true);
                    }
                    else if (ShouldStop && running)
                    {
                        Log("Balance level met ({0} bits)... Stopping...", data.balance);
                        SaveLogDisk();
                        notFirstClear = false;
                        running = false;
                        BSta(true);
                    }
                    else
                    {
                        if (multiplyOnLoss != 1)
                        {
                            Log("Betting increced from {0} to {1}", GameConfig.BetCost, GameConfig.BetCost * multiplyOnLoss);
                            GameConfig.BetCost = GameConfig.BetCost * multiplyOnLoss;
                        }
                        //string url = string.Format("https://satoshimines.com/s/{0}/{1}/", bd.game_id, bd.random_string);
                        //Log("Url: {0}", url);
                        Log("");

                        PrepRequest("https://satoshimines.com/action/newgame.php");
                        byte[] newGameresponce =
                                Bcodes("player_hash={0}&bet={1}&num_mines={2}", GameConfig.PlayerHash, GameConfig.BetCost.ToString("0.000000", new CultureInfo("en-US")),
                                        GameConfig.BombCount);
                        if (running)
                            getPostResponce(newGameresponce, EndNewGameResponce);
                        else
                            BSta(true);
                    }
                }
                else
                {
                    Log("Found {0} bits", bd.outcome);
                    glowSquare(bd.guess);
                    int betSquare = getNextSquare();
                    currentBetStreak++;
                    if (currentBetStreak >= GameConfig.BetAmmount)
                    {
                        GameConfig.BetCost = BasebetCost;
                        Log("Cashing out...");
                        PrepRequest("https://satoshimines.com/action/cashout.php");
                        byte[] cashoutResponce =
                            Bcodes("game_hash={0}", Data.game_hash);
                        
                        getPostResponce(cashoutResponce, endCashoutResponce);
                    }
                    else
                    {
                        Log("betting square {0}", betSquare);
                        PrepRequest("https://satoshimines.com/action/checkboard.php");
                        byte[] betResponce =
                            Bcodes("game_hash={0}&guess={1}&v04=1", Data.game_hash, betSquare);
                        getPostResponce(betResponce, EndBetResponce);
                    }

                }

            }
            catch(Exception ex)
            {
                if (GameConfig.ShowExceptionWindow)
                {
                    using (ExceptionForm except = new ExceptionForm(ex.ToString()))
                    {
                        except.ShowDialog();
                    }
                }
                Log("Failed bet.");
                PrepRequest("https://satoshimines.com/action/checkboard.php");
                int betSquare = getNextSquare();
                byte[] betResponce =
                    Bcodes("game_hash={0}&guess={1}&v04=1", Data.game_hash, betSquare);
                getPostResponce(betResponce, EndBetResponce);
            }
        }

        private void EndNewGameResponce(IAsyncResult AR)
        {
            try
            {

                HttpWebResponse httpResponce = (HttpWebResponse)_httpRequest.EndGetResponse(AR);
                using (StreamReader sr = new StreamReader(httpResponce.GetResponseStream()))
                {
                    lastResponce = sr.ReadToEnd();
                    Data = Deserialize<GameData>(lastResponce);
                }
                httpResponce.Close();

                clearSquares();
                currentBetStreak = 0;
                
                if (Data == null)
                    throw new Exception("Deserialize failed, object is null.");
                if (Data.status != "success")
                    throw new Exception("Json Error: " + Data.message);
                ClearLog(notFirstClear);
                notFirstClear = true;
                Log("=[Game Started]=");
                Log("Type: {0} | Bombs: {1}", Data.gametype, Data.num_mines);
                int betSquare = getNextSquare();
                Log("betting square {0}", betSquare);
                PrepRequest("https://satoshimines.com/action/checkboard.php");
                byte[] betResponce =
                    Bcodes("game_hash={0}&guess={1}&v04=1", Data.game_hash, betSquare);
                getPostResponce(betResponce, EndBetResponce);
            }
            catch(Exception ex)
            {
                if (GameConfig.ShowExceptionWindow)
                {
                    using (ExceptionForm except = new ExceptionForm(ex.ToString(), new Dictionary<string,string>
                    {
                        {"BetBase", BasebetCost.ToString()},
                        {"LastResounce", lastResponce},
                        {"LastSent", lastSent}
                    }))
                    {
                        except.ShowDialog();
                    }
                }
                Log("Failed to start new game.");
                running = false;
                BSta(true);
            }
        }

        void BSta(bool en)
        {
            try
            {
                this.Invoke((MethodInvoker) delegate()
                {
                    button1.Enabled = en;
                    if (en)
                    {
                        button1.Text = "Start";
                        running = false;
                    }
                });
            }
            catch { }
        }

        private static T Deserialize<T>(string json)
        {
            var s = new DataContractJsonSerializer(typeof(T));
            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                return (T)s.ReadObject(ms);
            }
        }

        private void PrepRequest(string url)
        {
            if (IsWaiting)
            {
                Log("Pausing....");
                pauser.WaitOne();
            }
            _httpRequest = (HttpWebRequest)WebRequest.Create(url);
           // _httpRequest.Timeout = 5000;
            _httpRequest.Method = "POST";
            _httpRequest.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";//application/x-www-form-urlencoded; charset=UTF-8
            _httpRequest.UserAgent =
                "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.132 Safari/537.36";
        }

        private void getPostResponce(byte[] post, AsyncCallback call)
        {
            _httpRequest.ContentLength = post.Length;
            var result = _httpRequest.BeginGetRequestStream(endGetRequestStream, new object[] { post, call });
        }

        private void endGetRequestStream(IAsyncResult AR)
        {
            try
            {
                Stream nStream = _httpRequest.EndGetRequestStream(AR);
                object[] data = (object[])AR.AsyncState;
                byte[] post = (byte[])data[0];
                AsyncCallback call = (AsyncCallback)data[1];
                nStream.Write(post, 0, post.Length);
                nStream.Flush();
                _httpRequest.BeginGetResponse(call, null);
            }
            catch
            {
                Log("Failed to start new game.");
                running = false;
                BSta(true);
            }
        }

        private void gamePanel_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (OnRemove != null)
                OnRemove(this);
        }

        private void gameGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Clear starts for this game?", "Clear stats", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                loss = 0;
                wins = 0;
                ShowWinLosStats();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(!IsWaiting)
            {
                IsWaiting = true;
                button4.Text = "Resume";
            }
            else
            {
                button4.Text = "Pause";
                IsWaiting = false;
                pauser.Set();
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void winStats_Click(object sender, EventArgs e)
        {

        }
    }
}
