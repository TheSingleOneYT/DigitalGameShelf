using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DigitalGameShelf
{
    public partial class AddGame : Form
    {
        public AddGame()
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
            var GameDir = textBox1.Text.ToString();
            var GameName = textBox2.Text.ToString();
            var ShortCutName = textBox3.Text.ToString();

            if (File.Exists(GameDir + "/" + GameName + ".exe"))
            {
                if (ShortCutName == "Shortcut Name")
                {
                    File.WriteAllText(EXELoc + "/Games/" + GameName + ".txt", GameDir + "/" + GameName + ".exe");
                }
                else
                {
                    if (ShortCutName == "")
                    {
                        File.WriteAllText(EXELoc + "/Games/" + GameName + ".txt", GameDir + "/" + GameName + ".exe");
                    }
                    else
                    {
                        File.WriteAllText(EXELoc + "/Games/" + ShortCutName + ".txt", GameDir + "/" + GameName + ".exe");
                    }
                }
                MessageBox.Show("Game Added, DigitalGameShelf Now Needs To Restart. Please Click OK.", "DigitalGameShelf", MessageBoxButtons.OK);
                Application.Exit();
                System.Diagnostics.Process.Start(Application.ExecutablePath);
            }
            else
            {
                MessageBox.Show("This is NOT a valid game in this directory. Please try again.", "DigitalGameShelf", MessageBoxButtons.OK);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
