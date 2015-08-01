using Satoshi_GUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Satoshi_GUI
{
    public delegate void SaveLogDelegate(string text);
    public partial class Form1 : Form
    {
        private List<gamePanel> currentPanels = new List<gamePanel>();
        private gamePanel _initGamepanel;
        private int toolstripOffset = 25;
        int tbOffset = 33;
        bool DontExtend = false;
        private int horIndex = 1;
        private int vertIndex = 0;
        static StreamWriter logStream;
        public Form1()
        {
            InitializeComponent();
            _initGamepanel = new gamePanel(true);
            _initGamepanel.Parent = this;
            _initGamepanel.Location = new Point(0, toolstripOffset);
            _initGamepanel.SaveLog += WriteToFile;
            _initGamepanel.Show();
        }

        private static void WriteToFile(string text)
        {
            if (logStream != null)
            {
                lock(logStream)
                {
                    logStream.WriteLine(text);
                    logStream.Flush();
                }
            }
        }

        public void LoadDefaultSettings()
        {
            if (!File.Exists("SatoshiBot.xml"))
                return;
            try
            {
                Global.DefaultGameSettings = new DefaultSettings();
                XDocument xDoc = XDocument.Load("SatoshiBot.xml");
                var settingsElement = xDoc.Element("SatoshiBot").Element("DefaultGameSettings");
                foreach (PropertyInfo property in typeof(DefaultSettings).GetProperties())
                {
                    Type propertyType = property.PropertyType;
                    var element = settingsElement.Element(property.Name);
                    if(element.Attribute("Type").Value == propertyType.ToString())
                    {
                        if (propertyType == typeof(string))
                            property.SetValue(Global.DefaultGameSettings, element.Value);
                        if (propertyType == typeof(int))
                            property.SetValue(Global.DefaultGameSettings, int.Parse(element.Value));
                        if (propertyType == typeof(decimal))
                            property.SetValue(Global.DefaultGameSettings, decimal.Parse(element.Value));
                        if (propertyType == typeof(bool))
                            property.SetValue(Global.DefaultGameSettings, element.Value == "1");
                        if (propertyType == typeof(int[]))
                        {
                            if(!string.IsNullOrEmpty(element.Value))
                                property.SetValue(Global.DefaultGameSettings, element.Value.Split('-').Select(n => int.Parse(n)).ToArray());
                        }
                            
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to load default settings. \n " + ex.Message);
            }
        }

        public void SaveDefaultSettings()
        {
            try
            {
                using (XmlTextWriter xml = new XmlTextWriter("SatoshiBot.xml", Encoding.UTF8))
                {
                    xml.Formatting = Formatting.Indented;
                    xml.WriteStartDocument();

                    xml.WriteStartElement("SatoshiBot");

                    xml.WriteStartElement("DefaultGameSettings");

                    foreach(PropertyInfo property in typeof(DefaultSettings).GetProperties())
                    {
                        Type propertyType = property.PropertyType;
                        object propertyValue = property.GetValue(Global.DefaultGameSettings);

                        xml.WriteStartElement(property.Name);

                        xml.WriteAttributeString("Type", propertyType.ToString());

                        if(propertyType == typeof(string))
                            xml.WriteCData(propertyValue.ToString());
                        if (propertyType == typeof(int))
                            xml.WriteString(propertyValue.ToString());
                        if (propertyType == typeof(decimal))
                            xml.WriteString(propertyValue.ToString());
                        if (propertyType == typeof(bool))
                            xml.WriteString(((bool)propertyValue) ? "1" : "0");
                        if (propertyType == typeof(int[]))
                        {
                            if(propertyValue != null)
                                xml.WriteString(string.Join("-", (int[])propertyValue));
                        }
                            
                        xml.WriteEndElement();
                    }

                    xml.WriteEndElement();//DefaultGameSettings

                    xml.WriteEndElement();//SatoshiBot

                    xml.WriteEndDocument();
                }
            }
            catch
            {
                MessageBox.Show("Failed to save default settings.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = _initGamepanel.Height + tbOffset + toolstripOffset;
            this.Width = _initGamepanel.Width + 10;
            this.Text += " - " + Application.ProductVersion;
            try
            {
                logStream = new StreamWriter("SatoshiBot.log", true, Encoding.UTF8);
                logStream.WriteLine("==");
                logStream.WriteLine("== [{0}] Bot started - BahNahNah", DateTime.Now.ToShortTimeString());
                logStream.WriteLine("==");
                logStream.Flush();
            }
            catch
            {
                logStream = null;
                MessageBox.Show("Failed to open log, make sure that \"SatoshiBot.log\" is not open in any programs then restart this bot");
            }
            LoadDefaultSettings();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            AddGamePanel(new gamePanel());
        }

        void AddGamePanel(gamePanel ngp)
        {
            currentPanels.Add(ngp);
            ngp.OnRemove += ngp_OnRemove;
            ngp.SaveLog += WriteToFile;
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
                    using (SettingsForm sf = new SettingsForm(Global.DefaultGameSettings))
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

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            using (SettingsForm sf = new SettingsForm(Global.DefaultGameSettings, true))
            {
                if(sf.ShowDialog() == DialogResult.OK)
                {
                    Global.DefaultGameSettings = sf.ToDefaultSettings();
                    WriteToFile("Default settings changed");
                    SaveDefaultSettings();
                }
            }
        }
    }
}
