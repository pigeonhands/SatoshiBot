using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satoshi_GUI
{
    

    public partial class SettingsForm : Form
    {
        public int BombCount { get; private set; }
        public string PlayerHash { get; private set; }
        public int BetAmmount { get; private set; }
        public decimal BetCost { get; private set; }
        public decimal PercentOnLoss { get; private set; }
        public bool StopAfterWin { get; private set; }
        public bool ShowExceptionWindow { get; private set; }
        public int[] StratergySquares { get; private set; }
        public bool UseStrat { get; private set; }
        public bool ShowGameBombs { get; private set; }
        public string ConfigTag { get; private set; }
        public bool SaveLogToFile { get; private set; }
        private bool settingDefaults = false;
        private bool LoadingDefaults = false;
        public SettingsForm()
        {
            InitializeComponent();
            BombCount = 3;
        }
        public SettingsForm(DefaultSettings ds)
        {
            InitializeComponent();
            LoadDefaultSettings(ds);
        }

        public SettingsForm(DefaultSettings ds, bool settingDef)
        {
            InitializeComponent();
            LoadDefaultSettings(ds);
            if(settingDef)
            {
                settingDefaults = true;
                this.Text = "Default settings";
            }
        }

        private void LoadDefaultSettings(DefaultSettings ds)
        {
            if (ds == null)
                return;
            LoadingDefaults = true;
            pHash.Text = ds.PlayerHash;
            numberofBets.Value = ds.BetAmmount;
            UseStrat = ds.UseStrat;
            useStratCheck.Checked = UseStrat;
            StratergySquares = ds.StratergySquares;
            if (UseStrat)
            {
                stratDisplay.Reset();
                foreach (int sv in StratergySquares)
                {
                    stratDisplay.SetSquare(sv, Brushes.Green);
                }
            }

            betCostNUD.Value = ds.BetCost;
            stopAfterWinCheck.Checked = ds.StopAfterWin;
            showExWindow.Checked = ds.ShowExceptionWindow;
            precentOnLoss.Value = ds.PercentOnLoss;
            showGBombsCheck.Checked = ds.ShowGameBombs;
            saveLog.Checked = ds.SaveLogToFile;
            cfgTag.Text = ds.ConfigTag;

            switch (ds.BombCount)
            {
                case 1:
                    radioButton1.Checked = true;
                    break;
                case 3:
                    radioButton2.Checked = true;
                    break;
                case 5:
                    radioButton3.Checked = true;
                    break;
                case 24:
                    radioButton4.Checked = true;
                    break;
            }
            numberofBets.Enabled = !UseStrat;
            LoadingDefaults = false;
        }

        public DefaultSettings ToDefaultSettings()
        {
            DefaultSettings ds = new DefaultSettings();
            ds.BombCount = BombCount;
            ds.PlayerHash = PlayerHash;
            ds.BetAmmount = BetAmmount;
            ds.BetCost = BetCost;
            ds.PercentOnLoss = PercentOnLoss;
            ds.StopAfterWin = StopAfterWin;
            ds.ShowExceptionWindow = ShowExceptionWindow;
            ds.StratergySquares = StratergySquares;
            ds.UseStrat = UseStrat;
            ds.ShowGameBombs = ShowGameBombs;
            ds.ConfigTag = ConfigTag;
            ds.SaveLogToFile = SaveLogToFile;
            return ds;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            BombCount = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            BombCount = 3;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            BombCount = 5;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            BombCount = 24;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerHash = pHash.Text;
            BetAmmount = (int)numberofBets.Value;
            if (UseStrat)
                BetAmmount = StratergySquares.Length;
            BetCost = betCostNUD.Value;
            StopAfterWin = stopAfterWinCheck.Checked;
            ShowExceptionWindow = showExWindow.Checked;
            PercentOnLoss = precentOnLoss.Value;
            ShowGameBombs = showGBombsCheck.Checked;
            SaveLogToFile = saveLog.Checked;
            ConfigTag = cfgTag.Text;
            if (PlayerHash == string.Empty && !settingDefaults)
            {
                MessageBox.Show("Please enter a hash.");
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StratergyForm sf = new StratergyForm())
            {
                sf.ShowDialog();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (useStratCheck.Checked)
            {
                if (LoadingDefaults)
                    return;
                using (StratergyForm sf = new StratergyForm())
                {
                    if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        StratergySquares = sf.StratergyArray;
                        UseStrat = StratergySquares != null && StratergySquares.Length > 0;
                        if (UseStrat)
                        {
                            /*
                            for (int i = 0; i < StratergySquares.Length; i++)
                            {
                                if (StratergySquares[i] == 1)
                                {
                                    stratDisplay.SetSquare(i, Brushes.Green);
                                }
                            }*/
                            foreach (int sv in StratergySquares)
                            {
                                stratDisplay.SetSquare(sv, Brushes.Green);
                            }
                        }
                        else
                        {
                            useStratCheck.Checked = false;
                            stratDisplay.Reset();
                        }
                    }
                    else
                    {
                        useStratCheck.Checked = false;
                        UseStrat = false;
                    }
                }
            }
            else
            {
                UseStrat = false;
                stratDisplay.Reset();
            }
            numberofBets.Enabled = !UseStrat;
        }

        private void precentOnLoss_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
