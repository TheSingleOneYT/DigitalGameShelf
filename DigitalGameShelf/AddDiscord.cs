using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DigitalGameShelf
{
    public partial class AddDiscordForm : Form
    {
        public AddDiscordForm()
        {
            InitializeComponent();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var EXELoc = Directory.GetCurrentDirectory();
            var DiscordDir = textBox1.Text.ToString();

            if (File.Exists(DiscordDir + "/Discord.exe"))
            {
                File.WriteAllText(EXELoc + "/Apps/Discord.txt", DiscordDir + "/Discord.exe");
                MessageBox.Show("Discord Added, DigitalGameShelf Now Needs To Restart. Please Click OK.", "DigitalGameShelf", MessageBoxButtons.OK);

                Application.Exit();
                System.Diagnostics.Process.Start(Application.ExecutablePath);
            }
            else
            {
                MessageBox.Show("This is NOT a valid game in this directory. Please try again.", "DigitalGameShelf", MessageBoxButtons.OK);
                textBox1.Text = "";
            }
        }
    }
}
