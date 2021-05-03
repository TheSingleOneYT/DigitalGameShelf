
namespace DigitalGameShelf
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GameToLaunch = new System.Windows.Forms.TextBox();
            this.LaunchBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGS = new System.Windows.Forms.Label();
            this.Discord_Chkbx = new System.Windows.Forms.CheckBox();
            this.Discord_BTN = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.RefreshBTN = new System.Windows.Forms.Button();
            this.OpenDGSFolderBTN = new System.Windows.Forms.Button();
            this.SFBTN = new System.Windows.Forms.Button();
            this.OpenUserFolderBTN = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseDGSChkbx = new System.Windows.Forms.CheckBox();
            this.HideDGSChkbx = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteSChkbx = new System.Windows.Forms.CheckBox();
            this.ExtrasText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.AboutBTN = new System.Windows.Forms.Button();
            this.AddGameBTN = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.WelcomeText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(208, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(580, 342);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // GameToLaunch
            // 
            this.GameToLaunch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameToLaunch.Location = new System.Drawing.Point(208, 386);
            this.GameToLaunch.Name = "GameToLaunch";
            this.GameToLaunch.Size = new System.Drawing.Size(495, 20);
            this.GameToLaunch.TabIndex = 1;
            this.GameToLaunch.Text = "Game";
            // 
            // LaunchBTN
            // 
            this.LaunchBTN.Location = new System.Drawing.Point(713, 386);
            this.LaunchBTN.Name = "LaunchBTN";
            this.LaunchBTN.Size = new System.Drawing.Size(75, 23);
            this.LaunchBTN.TabIndex = 2;
            this.LaunchBTN.Text = "Launch";
            this.LaunchBTN.UseVisualStyleBackColor = true;
            this.LaunchBTN.Click += new System.EventHandler(this.LaunchBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.DGS);
            this.panel1.Controls.Add(this.Discord_Chkbx);
            this.panel1.Controls.Add(this.Discord_BTN);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.RefreshBTN);
            this.panel1.Controls.Add(this.OpenDGSFolderBTN);
            this.panel1.Controls.Add(this.SFBTN);
            this.panel1.Controls.Add(this.OpenUserFolderBTN);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CloseDGSChkbx);
            this.panel1.Controls.Add(this.HideDGSChkbx);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DeleteSChkbx);
            this.panel1.Controls.Add(this.ExtrasText);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(-15, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 419);
            this.panel1.TabIndex = 7;
            // 
            // DGS
            // 
            this.DGS.AutoSize = true;
            this.DGS.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DGS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGS.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DGS.Location = new System.Drawing.Point(85, 338);
            this.DGS.Name = "DGS";
            this.DGS.Size = new System.Drawing.Size(60, 25);
            this.DGS.TabIndex = 24;
            this.DGS.Text = "DGS";
            this.DGS.Click += new System.EventHandler(this.DGS_Click);
            // 
            // Discord_Chkbx
            // 
            this.Discord_Chkbx.AutoSize = true;
            this.Discord_Chkbx.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Discord_Chkbx.Enabled = false;
            this.Discord_Chkbx.ForeColor = System.Drawing.SystemColors.Control;
            this.Discord_Chkbx.Location = new System.Drawing.Point(28, 76);
            this.Discord_Chkbx.Name = "Discord_Chkbx";
            this.Discord_Chkbx.Size = new System.Drawing.Size(172, 17);
            this.Discord_Chkbx.TabIndex = 23;
            this.Discord_Chkbx.Text = "Run Discord On Game Launch";
            this.Discord_Chkbx.UseVisualStyleBackColor = false;
            this.Discord_Chkbx.CheckedChanged += new System.EventHandler(this.Discord_Chkbx_CheckedChanged);
            // 
            // Discord_BTN
            // 
            this.Discord_BTN.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Discord_BTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Discord_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Discord_BTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Discord_BTN.Location = new System.Drawing.Point(27, 287);
            this.Discord_BTN.Name = "Discord_BTN";
            this.Discord_BTN.Size = new System.Drawing.Size(177, 23);
            this.Discord_BTN.TabIndex = 20;
            this.Discord_BTN.Text = "Discord BTN";
            this.Discord_BTN.UseVisualStyleBackColor = false;
            this.Discord_BTN.Click += new System.EventHandler(this.Discord_BTN_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox3.Location = new System.Drawing.Point(17, 277);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(196, 43);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // RefreshBTN
            // 
            this.RefreshBTN.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RefreshBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RefreshBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RefreshBTN.Location = new System.Drawing.Point(27, 239);
            this.RefreshBTN.Name = "RefreshBTN";
            this.RefreshBTN.Size = new System.Drawing.Size(177, 23);
            this.RefreshBTN.TabIndex = 18;
            this.RefreshBTN.Text = "Refresh Shorcut List";
            this.RefreshBTN.UseVisualStyleBackColor = false;
            this.RefreshBTN.Click += new System.EventHandler(this.RefreshBTN_Click);
            // 
            // OpenDGSFolderBTN
            // 
            this.OpenDGSFolderBTN.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OpenDGSFolderBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OpenDGSFolderBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenDGSFolderBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenDGSFolderBTN.Location = new System.Drawing.Point(27, 181);
            this.OpenDGSFolderBTN.Name = "OpenDGSFolderBTN";
            this.OpenDGSFolderBTN.Size = new System.Drawing.Size(177, 23);
            this.OpenDGSFolderBTN.TabIndex = 16;
            this.OpenDGSFolderBTN.Text = "Open DGS Folder";
            this.OpenDGSFolderBTN.UseVisualStyleBackColor = false;
            this.OpenDGSFolderBTN.Click += new System.EventHandler(this.OpenDGSFolderBTN_Click);
            // 
            // SFBTN
            // 
            this.SFBTN.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SFBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SFBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SFBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SFBTN.Location = new System.Drawing.Point(27, 210);
            this.SFBTN.Name = "SFBTN";
            this.SFBTN.Size = new System.Drawing.Size(177, 23);
            this.SFBTN.TabIndex = 5;
            this.SFBTN.Text = "Open Shorcut Folder";
            this.SFBTN.UseVisualStyleBackColor = false;
            this.SFBTN.Click += new System.EventHandler(this.SFBTN_Click);
            // 
            // OpenUserFolderBTN
            // 
            this.OpenUserFolderBTN.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OpenUserFolderBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OpenUserFolderBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenUserFolderBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenUserFolderBTN.Location = new System.Drawing.Point(27, 152);
            this.OpenUserFolderBTN.Name = "OpenUserFolderBTN";
            this.OpenUserFolderBTN.Size = new System.Drawing.Size(177, 23);
            this.OpenUserFolderBTN.TabIndex = 7;
            this.OpenUserFolderBTN.Text = "Open Preferences Folder";
            this.OpenUserFolderBTN.UseVisualStyleBackColor = false;
            this.OpenUserFolderBTN.Click += new System.EventHandler(this.OpenUserFolderBTN_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox2.Location = new System.Drawing.Point(17, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 128);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(24, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "App Modes";
            // 
            // CloseDGSChkbx
            // 
            this.CloseDGSChkbx.AutoSize = true;
            this.CloseDGSChkbx.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CloseDGSChkbx.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseDGSChkbx.Location = new System.Drawing.Point(28, 57);
            this.CloseDGSChkbx.Name = "CloseDGSChkbx";
            this.CloseDGSChkbx.Size = new System.Drawing.Size(165, 17);
            this.CloseDGSChkbx.TabIndex = 13;
            this.CloseDGSChkbx.Text = "Close DGS On Game Launch";
            this.CloseDGSChkbx.UseVisualStyleBackColor = false;
            this.CloseDGSChkbx.CheckedChanged += new System.EventHandler(this.CloseDGSChkbx_CheckedChanged);
            // 
            // HideDGSChkbx
            // 
            this.HideDGSChkbx.AutoSize = true;
            this.HideDGSChkbx.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HideDGSChkbx.ForeColor = System.Drawing.SystemColors.Control;
            this.HideDGSChkbx.Location = new System.Drawing.Point(28, 39);
            this.HideDGSChkbx.Name = "HideDGSChkbx";
            this.HideDGSChkbx.Size = new System.Drawing.Size(161, 17);
            this.HideDGSChkbx.TabIndex = 12;
            this.HideDGSChkbx.Text = "Hide DGS On Game Launch";
            this.HideDGSChkbx.UseVisualStyleBackColor = false;
            this.HideDGSChkbx.CheckedChanged += new System.EventHandler(this.HideDGSChkbx_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Preferences";
            // 
            // DeleteSChkbx
            // 
            this.DeleteSChkbx.AutoSize = true;
            this.DeleteSChkbx.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DeleteSChkbx.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteSChkbx.Location = new System.Drawing.Point(28, 116);
            this.DeleteSChkbx.Name = "DeleteSChkbx";
            this.DeleteSChkbx.Size = new System.Drawing.Size(166, 17);
            this.DeleteSChkbx.TabIndex = 10;
            this.DeleteSChkbx.Text = "Enable Delete Shortcut Mode";
            this.DeleteSChkbx.UseVisualStyleBackColor = false;
            this.DeleteSChkbx.CheckedChanged += new System.EventHandler(this.DeleteSChkbx_CheckedChanged);
            // 
            // ExtrasText
            // 
            this.ExtrasText.AutoSize = true;
            this.ExtrasText.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ExtrasText.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ExtrasText.Location = new System.Drawing.Point(25, 7);
            this.ExtrasText.Name = "ExtrasText";
            this.ExtrasText.Size = new System.Drawing.Size(39, 13);
            this.ExtrasText.TabIndex = 9;
            this.ExtrasText.Text = "Extras:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(18, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 136);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox4.Location = new System.Drawing.Point(-24, -111);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(899, 143);
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // AboutBTN
            // 
            this.AboutBTN.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AboutBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AboutBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AboutBTN.Location = new System.Drawing.Point(714, 5);
            this.AboutBTN.Name = "AboutBTN";
            this.AboutBTN.Size = new System.Drawing.Size(48, 23);
            this.AboutBTN.TabIndex = 28;
            this.AboutBTN.Text = "About";
            this.AboutBTN.UseVisualStyleBackColor = false;
            this.AboutBTN.Click += new System.EventHandler(this.AboutBTN_Click);
            // 
            // AddGameBTN
            // 
            this.AddGameBTN.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddGameBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddGameBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGameBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddGameBTN.Location = new System.Drawing.Point(472, 5);
            this.AddGameBTN.Name = "AddGameBTN";
            this.AddGameBTN.Size = new System.Drawing.Size(237, 23);
            this.AddGameBTN.TabIndex = 27;
            this.AddGameBTN.Text = "Add A Game To The Shelf";
            this.AddGameBTN.UseVisualStyleBackColor = false;
            this.AddGameBTN.Click += new System.EventHandler(this.AddGameBTN_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseButton.Location = new System.Drawing.Point(768, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 23);
            this.CloseButton.TabIndex = 26;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // WelcomeText
            // 
            this.WelcomeText.AutoSize = true;
            this.WelcomeText.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WelcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeText.ForeColor = System.Drawing.SystemColors.Control;
            this.WelcomeText.Location = new System.Drawing.Point(8, 6);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(83, 18);
            this.WelcomeText.TabIndex = 29;
            this.WelcomeText.Text = "Welcome!";
            // 
            // Main
            // 
            this.AcceptButton = this.LaunchBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.ControlBox = false;
            this.Controls.Add(this.WelcomeText);
            this.Controls.Add(this.AboutBTN);
            this.Controls.Add(this.AddGameBTN);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LaunchBTN);
            this.Controls.Add(this.GameToLaunch);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DigitalGameShelf";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox GameToLaunch;
        private System.Windows.Forms.Button LaunchBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OpenDGSFolderBTN;
        private System.Windows.Forms.Button SFBTN;
        private System.Windows.Forms.Button OpenUserFolderBTN;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CloseDGSChkbx;
        private System.Windows.Forms.CheckBox HideDGSChkbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox DeleteSChkbx;
        private System.Windows.Forms.Label ExtrasText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RefreshBTN;
        private System.Windows.Forms.CheckBox Discord_Chkbx;
        private System.Windows.Forms.Button Discord_BTN;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label DGS;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button AboutBTN;
        private System.Windows.Forms.Button AddGameBTN;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label WelcomeText;
    }
}

