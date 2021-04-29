using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DigitalGameShelf
{
    public partial class Main : Form
    {
        public Main()
        {
            var EXELoc = Directory.GetCurrentDirectory();

            InitializeComponent();

            if (Directory.Exists(EXELoc + "/Games"))
            {
                var GamesDir = EXELoc + "/Games";
                var files = Directory.GetFiles(GamesDir);

                foreach (var file in files)
                {
                    listBox1.Items.Add(Path.GetFileNameWithoutExtension(file));
                }
            }
            else
            {
                Directory.CreateDirectory(EXELoc + "/Games");
            }
        }

        private void LaunchBTN_Click(object sender, EventArgs e)
        {
            var Game = GameToLaunch.Text.ToString();
            var EXELoc = Directory.GetCurrentDirectory();

            if (File.Exists(EXELoc + "/Games/" + Game + ".txt"))
            {
                var GameTXTPath = EXELoc + "/Games/" + Game + ".txt";
                var GameEXEPath = File.ReadAllText(GameTXTPath);

                if (File.Exists(GameEXEPath))
                {
                    Process.Start(GameEXEPath);
                    this.WindowState = FormWindowState.Minimized;
                }
                else
                {
                    MessageBox.Show("The chosen game directory does not currently exist.", "DigitalGameShelf", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("The chosen game has not been added to the shelf.", "DigitalGameShelf", MessageBoxButtons.OK);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            var processess = Process.GetProcessesByName("DigitalGameShelf");

            foreach (var process in processess)
            {
                process.Kill();
            }
        }

        private void AddGameBTN_Click(object sender, EventArgs e)
        {
            AddGame addGame = new AddGame();
            addGame.Show();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var Selected = listBox1.SelectedItem.ToString();
            GameToLaunch.Text = Selected;
        }

        private void SFBTN_Click(object sender, EventArgs e)
        {
            var EXELoc = Directory.GetCurrentDirectory();
            Process.Start(EXELoc + "/Games/");
        }
    }
}
