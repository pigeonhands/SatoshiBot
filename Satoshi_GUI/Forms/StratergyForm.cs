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
    public partial class StratergyForm : Form
    {
        public int[] StratergyArray { get; private set; }
        public StratergyForm()
        {
            InitializeComponent();
            
        }

        private void StratergyForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> p_ind = new List<int>();
            for (int i = 0; i < startergyGrid1.Squares.Length; i++)
            {
                if (startergyGrid1.Squares[i].IsGlowing)
                    p_ind.Add(i);
            }
            StratergyArray = p_ind.ToArray();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }

   
}
