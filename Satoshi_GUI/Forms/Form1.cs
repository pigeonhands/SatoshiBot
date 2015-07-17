using Satoshi_GUI.Forms;
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
        private List<gamePanel> currentPanels = new List<gamePanel>();
        private gamePanel _initGamepanel;
        private int toolstripOffset = 25;
        int tbOffset = 33;
        bool DontExtend = false;
        private int horIndex = 1;
        private int vertIndex = 0;
        public Form1()
        {
            InitializeComponent();
            _initGamepanel = new gamePanel(true);
            _initGamepanel.Parent = this;
            _initGamepanel.Location = new Point(0, toolstripOffset);
            _initGamepanel.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = _initGamepanel.Height + tbOffset + toolstripOffset;
            this.Width = _initGamepanel.Width + 10;
            this.Text += " - " + Application.ProductVersion;
            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            AddGamePanel(new gamePanel());
        }

        void AddGamePanel(gamePanel ngp)
        {
            currentPanels.Add(ngp);
            ngp.OnRemove += ngp_OnRemove;
            ngp.Parent = this;
            if (horIndex != 2)//This number is how many game panels wide it will be. Default is 2
            {
                if (!DontExtend)
                    this.Width = (_initGamepanel.Width * (horIndex + 1)) + 10;
                ngp.Location = new Point(ngp.Width * horIndex,
                    (vertIndex * ngp.Height) + toolstripOffset);
                ngp.Show();
            }
            else
            {
                DontExtend = true;
                horIndex = 0;
                vertIndex++;
                this.Height = (_initGamepanel.Height * (vertIndex + 1)) + tbOffset + toolstripOffset;
                ngp.Location = new Point(ngp.Width * horIndex,
                    (vertIndex * ngp.Height) + toolstripOffset);
            }
            horIndex++;
            ngp.Show();
        }

        void ngp_OnRemove(gamePanel sender)
        {
            currentPanels.Remove(sender);
            sender.StopRunning();
            sender.Dispose();
            vertIndex = 0;
            horIndex = 1;
            foreach (gamePanel panel in currentPanels)
            {
                if (horIndex != 2)//This number is how many game panels wide it will be. Default is 2
                {
                    
                    panel.Location = new Point(panel.Width * horIndex,
                        (vertIndex * panel.Height) + toolstripOffset);
                    panel.Show();
                }
                else
                {
                    horIndex = 0;
                    vertIndex++;
                    panel.Location = new Point(panel.Width * horIndex,
                        (vertIndex * panel.Height) + toolstripOffset);
                }
                horIndex++;
            }
            this.Height = (_initGamepanel.Height * (vertIndex + 1)) + tbOffset + toolstripOffset;
            if (currentPanels.Count == 0)
            {
                this.Width = _initGamepanel.Width + 10;
                DontExtend = false;
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            using (CheckBalanceForm cbf = new CheckBalanceForm())
            {
                cbf.ShowDialog();
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            using (MultiAddForm maf = new MultiAddForm())
            {
                if (maf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    using (SettingsForm sf = new SettingsForm())
                    {
                        if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            for (int i = 0; i < maf.SpawnAmmount; i++)
                                AddGamePanel(new gamePanel(sf));
                        }
                    }
                }
            }
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            foreach (gamePanel gp in currentPanels)
            {
                gp.StopRunning();
                gp.Dispose();
            }
            currentPanels.Clear();
            this.Height = _initGamepanel.Height + tbOffset + toolstripOffset;
            this.Width = _initGamepanel.Width + 10;
            DontExtend = false;
            vertIndex = 0;
            horIndex = 1;
        }
    }
}
