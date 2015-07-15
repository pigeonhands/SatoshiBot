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
    public partial class CheckBalanceForm : Form
    {
        public CheckBalanceForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            try
            {
                string resp = await GetBalance(textBox1.Text);
                BalanceData bd = Deserialize<BalanceData>(resp);
                if (bd == null || bd.status != "success")
                    throw new Exception();

                balanceLabel.Text = bd.balance.ToString();
            }
            catch
            {
                balanceLabel.Text = "Failed";
            }
            button1.Enabled = true;
        }

        private static T Deserialize<T>(string json)
        {
            var s = new DataContractJsonSerializer(typeof(T));
            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                return (T)s.ReadObject(ms);
            }
        }

        private async Task<string> GetBalance(string SecretKey)
        {
            string Parameters = string.Format("secret={0}", SecretKey);
            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                return await wc.UploadStringTaskAsync(new Uri("https://satoshimines.com/action/refresh_balance.php"), "POST", Parameters);
            }
        }
    }
}
