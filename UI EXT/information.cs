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
    public partial class information : Form
    {
        public information()
        {
            InitializeComponent();
        }

        private void information_Load(object sender, EventArgs e)
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
    }
}
