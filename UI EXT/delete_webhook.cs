using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord_Webhook_Sender.UI_EXT
{
    public partial class delete_webhook : Form
    {
        public delete_webhook()
        {
            InitializeComponent();
        }

        private void delete_webhook_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.mode == "Dark")
            {
                this.BackColor = Color.FromArgb(14, 14, 14);
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var httpRequest = (HttpWebRequest)WebRequest.Create(siticoneTextBox1.Text);
                httpRequest.Method = "DELETE";
                httpRequest.Accept = "*/*";
                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                MessageBox.Show("Succesfully deleted discord webhook!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Invalid discord webhook! Please retry with a valid webhook.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
