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

        private void button1_Click(object sender, EventArgs e)
        {
            var EXELoc = Directory.GetCurrentDirectory();
            var GameDir = textBox1.Text.ToString();
            var GameName = textBox2.Text.ToString();

            if (File.Exists(GameDir + "/" + GameName + ".exe"))
            {
                File.WriteAllText(EXELoc + "/Games/" + GameName + ".txt", GameDir + "/" + GameName + ".exe");
                MessageBox.Show("Game Added, DigitalGameShelf Now Needs To Restart. Please Click OK.", "DigitalGameShelf", MessageBoxButtons.OK);
                Process.Start(EXELoc + "/DigitalGameShelf.exe");
                var processess = Process.GetProcessesByName("DigitalGameShelf");

                foreach (var process in processess)
                {
                    process.Kill();
                }
            }
            else
            {
                MessageBox.Show("This is NOT a valid game in this directory. Please try again.", "DigitalGameShelf", MessageBoxButtons.OK);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
        }
    }
}
