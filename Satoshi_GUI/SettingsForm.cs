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

        public bool WriteLogToFile { get; private set; }
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
            BetAmmount = (int)numericUpDown1.Value;
            BetCost = betCostNUD.Value;
            WriteLogToFile = checkBox1.Checked;
            if (PlayerHash == string.Empty)
            {
                MessageBox.Show("Please enter a hash.");
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
