using Discord_Webhook_Sender.UI_EXT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Discord_Webhook_Sender
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void siticonePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneCircleButton1_MouseHover(object sender, EventArgs e)
        {
            siticoneToolTip1.SetToolTip(siticoneCircleButton1, "Send a simple plain text message to custom discord webhook, such as 'hello'");
        }

        private void siticoneCircleButton4_MouseHover(object sender, EventArgs e)
        {
               
        }

        private void siticoneCircleButton2_MouseHover(object sender, EventArgs e)
        {
            siticoneToolTip1.SetToolTip(siticoneCircleButton2, "Delete a custom discord webhook, nice and easy simply one click!");
        }

        private void siticoneCircleButton3_MouseHover(object sender, EventArgs e)
        {
            siticoneToolTip1.SetToolTip(siticoneCircleButton3, "View more information on this application. Such as developers, links and legal advice.");
        }

        private void currenttime_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("h:mm:ss tt");
        }

        private void UI_Load(object sender, EventArgs e)
        {
            this.siticonePanel2.Controls.Clear();
            set_webhook open = new set_webhook
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticonePanel2.Controls.Add(open);
            open.Show();

            currenttime.Start();

            if (Properties.Settings.Default.mode == "Dark")
            {
                this.BackColor = Color.FromArgb(14, 14, 14);
                siticonePanel2.FillColor = Color.FromArgb(14, 14, 14);
                siticoneCircleButton6.Image = Properties.Resources.light_on_34px;
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
                siticonePanel2.FillColor = Color.WhiteSmoke;
                siticoneCircleButton6.Image = Properties.Resources.moon_and_stars_34px;
            }

        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            this.siticonePanel2.Controls.Clear();
            single_message open = new single_message
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticonePanel2.Controls.Add(open);
            open.Show();
        }

        private void siticoneCircleButton5_Click(object sender, EventArgs e)
        {
            this.siticonePanel2.Controls.Clear();
            set_webhook open = new set_webhook
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticonePanel2.Controls.Add(open);
            open.Show();
        }

        private void siticoneCircleButton2_Click(object sender, EventArgs e)
        {
            this.siticonePanel2.Controls.Clear();
            delete_webhook open = new delete_webhook
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticonePanel2.Controls.Add(open);
            open.Show();
        }

        private void siticoneCircleButton3_Click(object sender, EventArgs e)
        {
            this.siticonePanel2.Controls.Clear();
            information open = new information
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticonePanel2.Controls.Add(open);
            open.Show();
        }

        private void siticoneCircleButton5_MouseHover(object sender, EventArgs e)
        {
            siticoneToolTip1.SetToolTip(siticoneCircleButton5, "Set the current webhook you would like to send messages to.");
        }

        private void siticoneCircleButton6_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.mode == "Light")
            {
                this.BackColor = Color.FromArgb(14, 14, 14);
                siticoneCircleButton6.Image = Properties.Resources.light_on_34px;
                Properties.Settings.Default.mode = "Dark";
                Properties.Settings.Default.Save();
                Application.Restart();
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
                siticoneCircleButton6.Image = Properties.Resources.moon_and_stars_34px;
                Properties.Settings.Default.mode = "Light";
                Properties.Settings.Default.Save();
                Application.Restart();
            }
        }

        private void siticoneCircleButton6_MouseHover(object sender, EventArgs e)
        {
            siticoneToolTip1.SetToolTip(siticoneCircleButton6, "Toggle light mode and dark mode, switch between the two!");
        }

        private void siticoneCircleButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
