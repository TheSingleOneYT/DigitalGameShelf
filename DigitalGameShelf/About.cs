using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DigitalGameShelf
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
        }

        private void GithubBTN_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/TheSingleOneYT/DigitalGameShelf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/TheSingleOneYT");
        }

        private void YouTubeBTN_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCaCMegNb4sWCc9rSF2GTpSg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/TheSingleOneYT/");
        }
    }
}
