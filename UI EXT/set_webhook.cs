using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord_Webhook_Sender.UI_EXT
{
    public partial class set_webhook : Form
    {
        public set_webhook()
        {
            InitializeComponent();
        }

        private void set_webhook_Load(object sender, EventArgs e)
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
            Properties.Settings.Default.webhook = siticoneTextBox4.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Succesfully saved discord webhook!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
