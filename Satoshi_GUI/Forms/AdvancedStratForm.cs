using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satoshi_GUI.Forms
{
    public partial class AdvancedStratForm : Form
    {
        public int BetCost { get; set; }
        public int BombRepeatTimes { get; set; }
        public AdvancedStratForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BetCost = (int)betCostNUD.Value;
            BombRepeatTimes = (int)numericUpDown1.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
