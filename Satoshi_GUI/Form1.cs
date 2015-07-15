using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satoshi_GUI
{
    public partial class Form1 : Form
    {
        private gamePanel _initGamepanel;
        private int toolstripOffset = 25;
        int tbOffset = 33;
        bool hasHadHor = false;
        private int horIndex = 1;
        private int vertIndex = 0;
        public Form1()
        {
            InitializeComponent();
            _initGamepanel = new gamePanel();
            _initGamepanel.Parent = this;
            _initGamepanel.Location = new Point(0, toolstripOffset);
            _initGamepanel.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = _initGamepanel.Height + tbOffset + toolstripOffset;
            this.Width = _initGamepanel.Width + 10;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (horIndex != 2)
            {
                if (!hasHadHor)
                    this.Width = (_initGamepanel.Width*2) + 10;
                hasHadHor = true;
                gamePanel ngp = new gamePanel();
                ngp.Parent = this;
                ngp.Location = new Point(ngp.Width * horIndex,
                    (vertIndex * ngp.Height) + toolstripOffset);
                ngp.Show();
                horIndex++;
            }
            else
            {
                horIndex = 0;
                vertIndex++;
                this.Height = (_initGamepanel.Height * (vertIndex + 1)) + tbOffset + toolstripOffset;
                gamePanel ngp = new gamePanel();
                ngp.Parent = this;
                ngp.Location = new Point(ngp.Width * horIndex,
                    (vertIndex * ngp.Height) + toolstripOffset);
                ngp.Show();
                horIndex++;
            }
        }
    }
}
