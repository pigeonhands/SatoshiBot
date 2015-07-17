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
        public SettingsForm()
        {
            InitializeComponent();
            BombCount = 3;
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
            ConfigTag = cfgTag.Text;
            if (PlayerHash == string.Empty)
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
    }
}
