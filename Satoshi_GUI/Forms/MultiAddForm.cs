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
    public partial class MultiAddForm : Form
    {
        public int SpawnAmmount { get; private set; }
        public MultiAddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpawnAmmount = (int)numericUpDown1.Value;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void MultiAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
