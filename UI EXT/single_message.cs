using JNogueira.Discord.Webhook.Client;
using Siticone.UI.WinForms;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Discord_Webhook_Sender.UI_EXT
{
    public partial class single_message : Form
    {
        public single_message()
        {
            InitializeComponent();
        }

        private void single_message_Load(object sender, EventArgs e)
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

        private async void siticoneButton2_Click(object sender, EventArgs e)
        {
            try
            {
                    bool ttscheck = false;
                    if (siticoneComboBox1.SelectedItem.ToString() == "Enabled")
                    {
                        ttscheck = true;
                    }

                    var client = new DiscordWebhookClient(Properties.Settings.Default.webhook);

                    var message = new DiscordMessage(
                        siticoneTextBox3.Text,
                        username: siticoneTextBox1.Text,
                        avatarUrl: siticoneTextBox2.Text,
                        tts: ttscheck
                    );

                    await client.SendToDiscord(message);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siticoneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (siticoneButton1.Text == "Please load usernames...")
            {
                MessageBox.Show("Please load usernames before, spamming.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (string line in System.IO.File.ReadLines(siticoneTextBox15.Text))
                {

                    var client = new DiscordWebhookClient(Properties.Settings.Default.webhook);

                    var message = new DiscordMessage(
                        siticoneTextBox4.Text,
                        username: line,
                        avatarUrl: siticoneTextBox5.Text,
                        tts: false
                    );

                    await client.SendToDiscord(message);
                }
            }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Load Usernames",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                siticoneTextBox15.Text = openFileDialog1.FileName;
                var lineCount = File.ReadLines(openFileDialog1.FileName).Count();
                siticoneButton1.Text = $"Send Request ({lineCount} Times)";
                siticoneGroupBox16.Text = $"Usernames Loaded: {lineCount}";
            }
        }
    }
}
