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
    public partial class ExceptionForm : Form
    {
        public ExceptionForm(string ex)
        {
            InitializeComponent();
            richTextBox1.Text = ex;
        }

        public ExceptionForm(string ex, Dictionary<string, string> OtherData)
        {
            InitializeComponent();
            foreach (var dat in OtherData)
            {
                richTextBox1.Text += dat.Key + ": " + dat.Value + "\r\n";
            }
            richTextBox1.Text += ex;
        }

        private void ExceptionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
