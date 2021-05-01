﻿using System;
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

            if (Directory.Exists(EXELoc + "/Preferences"))
            {
                var PrefDir = EXELoc + "/Preferences";

                if (File.Exists(PrefDir + "/HideDGSChkbx.DGSPref"))
                {
                    var PrefOnHide = File.ReadAllText(PrefDir + "/HideDGSChkbx.DGSPref");

                    if (PrefOnHide == "true")
                    {
                        HideDGSChkbx.Checked = true;
                    }
                    else
                    {
                        HideDGSChkbx.Checked = false;
                    }
                }
                else
                {
                    HideDGSChkbx.Checked = true;
                    File.WriteAllText(PrefDir + "/HideDGSChkbx.DGSPref", "true");
                }

                if (File.Exists(PrefDir + "/CloseDGSChkbx.DGSPref"))
                {
                    var PrefOnClose = File.ReadAllText(PrefDir + "/CloseDGSChkbx.DGSPref");

                    if (PrefOnClose == "true")
                    {
                        CloseDGSChkbx.Checked = true;
                    }
                    else
                    {
                        CloseDGSChkbx.Checked = false;
                    }
                }
                else
                {
                    CloseDGSChkbx.Checked = false;
                    File.WriteAllText(PrefDir + "/CloseDGSChkbx.DGSPref", "false");
                }
            }
            else
            {
                var PrefDir = EXELoc + "/Preferences";
                Directory.CreateDirectory(EXELoc + "/Preferences");
                HideDGSChkbx.Checked = true;
                File.WriteAllText(PrefDir + "/HideDGSChkbx.DGSPref", "true");
                CloseDGSChkbx.Checked = false;
                File.WriteAllText(PrefDir + "/CloseDGSChkbx.DGSPref", "false");
            }
        }

        private void LaunchBTN_Click(object sender, EventArgs e)
        {
            var EXELoc = Directory.GetCurrentDirectory();

            if (DeleteSChkbx.Checked == true)
            {
                var GameToDel = GameToLaunch.Text.ToString();

                if (File.Exists(EXELoc + "/Games/" + GameToDel + ".txt"))
                {
                    File.Delete(EXELoc + "/Games/" + GameToDel + ".txt");

                    listBox1.Items.Clear();

                    var GamesDir = EXELoc + "/Games";
                    var files = Directory.GetFiles(GamesDir);

                    foreach (var file in files)
                    {
                        listBox1.Items.Add(Path.GetFileNameWithoutExtension(file));
                    }
                }
                else
                {
                    MessageBox.Show("The chosen game has not been added to the shelf.", "DigitalGameShelf", MessageBoxButtons.OK);
                }
            }
            else
            {
                int i = 0;
                if (HideDGSChkbx.Checked == true)
                {
                    if (CloseDGSChkbx.Checked == true)
                    {
                        i = 1;
                    }
                }

                if (CloseDGSChkbx.Checked == true)
                {
                    if (HideDGSChkbx.Checked == true)
                    {
                        i = 1;
                    }
                }

                if (i == 1)
                {
                    MessageBox.Show("The Close And Hide DSG Checkboxes are both checked. Please only check one.", "DigitalGameShelf", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var Game = GameToLaunch.Text.ToString();

                    if (File.Exists(EXELoc + "/Games/" + Game + ".txt"))
                    {
                        var GameTXTPath = EXELoc + "/Games/" + Game + ".txt";
                        var GameEXEPath = File.ReadAllText(GameTXTPath);

                        if (File.Exists(GameEXEPath))
                        {
                            Process.Start(GameEXEPath);

                            if (HideDGSChkbx.Checked == true)
                            {
                                this.WindowState = FormWindowState.Minimized;
                            }
                            else if (CloseDGSChkbx.Checked == true)
                            {
                                var processess = Process.GetProcessesByName("DigitalGameShelf");

                                foreach (var process in processess)
                                {
                                    process.Kill();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("The chosen game directory does not currently exist.", "DigitalGameShelf", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The chosen game has not been added to the shelf.", "DigitalGameShelf", MessageBoxButtons.OK);
                    }
                }
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

            private void HideDGSChkbx_CheckedChanged(object sender, EventArgs e)
            {
                var EXELoc = Directory.GetCurrentDirectory();
                var PrefDir = EXELoc + "/Preferences";

                if (HideDGSChkbx.Checked == true)
                {
                    File.WriteAllText(PrefDir + "/HideDGSChkbx.DGSPref", "true");
                }
                else
                {
                    File.WriteAllText(PrefDir + "/HideDGSChkbx.DGSPref", "false");
                }
            }

            private void CloseDGSChkbx_CheckedChanged(object sender, EventArgs e)
            {
                var EXELoc = Directory.GetCurrentDirectory();
                var PrefDir = EXELoc + "/Preferences";

                if (CloseDGSChkbx.Checked == true)
                {
                    File.WriteAllText(PrefDir + "/CloseDGSChkbx.DGSPref", "true");
                }
                else
                {
                    File.WriteAllText(PrefDir + "/CloseDGSChkbx.DGSPref", "false");
                }
            }

            private void OpenUserFolderBTN_Click(object sender, EventArgs e)
            {
                var EXELoc = Directory.GetCurrentDirectory();
                var PrefDir = EXELoc + "/Preferences";

                Process.Start(PrefDir);
            }

            private void OpenDGSFolderBTN_Click(object sender, EventArgs e)
            {
                var EXELoc = Directory.GetCurrentDirectory();

                Process.Start(EXELoc);
            }

            private void DeleteSChkbx_CheckedChanged(object sender, EventArgs e)
            {
                if (DeleteSChkbx.Checked == true)
                {
                    LaunchBTN.Text = "Delete";
                }
                else
                {
                    LaunchBTN.Text = "Launch";
                }
            }

        private void RefreshBTN_Click(object sender, EventArgs e)
        {
            var EXELoc = Directory.GetCurrentDirectory();

            listBox1.Items.Clear();

            var GamesDir = EXELoc + "/Games";
            var files = Directory.GetFiles(GamesDir);

            foreach (var file in files)
            {
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }
    }
    }