
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
            this.Grey = new System.Windows.Forms.Panel();
            this.AddGameBTN = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGS_Name_Label = new System.Windows.Forms.Label();
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
            this.RefreshBTN = new System.Windows.Forms.Button();
            this.Grey.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(208, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(580, 355);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // GameToLaunch
            // 
            this.GameToLaunch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameToLaunch.Location = new System.Drawing.Point(208, 401);
            this.GameToLaunch.Name = "GameToLaunch";
            this.GameToLaunch.Size = new System.Drawing.Size(495, 20);
            this.GameToLaunch.TabIndex = 1;
            this.GameToLaunch.Text = "Game";
            // 
            // LaunchBTN
            // 
            this.LaunchBTN.Location = new System.Drawing.Point(713, 399);
            this.LaunchBTN.Name = "LaunchBTN";
            this.LaunchBTN.Size = new System.Drawing.Size(75, 23);
            this.LaunchBTN.TabIndex = 2;
            this.LaunchBTN.Text = "Launch";
            this.LaunchBTN.UseVisualStyleBackColor = true;
            this.LaunchBTN.Click += new System.EventHandler(this.LaunchBTN_Click);
            // 
            // Grey
            // 
            this.Grey.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Grey.Controls.Add(this.AddGameBTN);
            this.Grey.Controls.Add(this.CloseButton);
            this.Grey.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Grey.Location = new System.Drawing.Point(-18, -36);
            this.Grey.Name = "Grey";
            this.Grey.Size = new System.Drawing.Size(853, 67);
            this.Grey.TabIndex = 3;
            // 
            // AddGameBTN
            // 
            this.AddGameBTN.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddGameBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddGameBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGameBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddGameBTN.Location = new System.Drawing.Point(537, 40);
            this.AddGameBTN.Name = "AddGameBTN";
            this.AddGameBTN.Size = new System.Drawing.Size(237, 23);
            this.AddGameBTN.TabIndex = 6;
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
            this.CloseButton.Location = new System.Drawing.Point(780, 40);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.RefreshBTN);
            this.panel1.Controls.Add(this.DGS_Name_Label);
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
            // DGS_Name_Label
            // 
            this.DGS_Name_Label.AutoSize = true;
            this.DGS_Name_Label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DGS_Name_Label.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGS_Name_Label.ForeColor = System.Drawing.SystemColors.Control;
            this.DGS_Name_Label.Location = new System.Drawing.Point(17, 291);
            this.DGS_Name_Label.Name = "DGS_Name_Label";
            this.DGS_Name_Label.Size = new System.Drawing.Size(197, 84);
            this.DGS_Name_Label.TabIndex = 17;
            this.DGS_Name_Label.Text = "DGS\r\nDigitalGameShelf\r\nBy TheSingleOne";
            this.DGS_Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenDGSFolderBTN
            // 
            this.OpenDGSFolderBTN.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OpenDGSFolderBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OpenDGSFolderBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenDGSFolderBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenDGSFolderBTN.Location = new System.Drawing.Point(28, 177);
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
            this.SFBTN.Location = new System.Drawing.Point(28, 206);
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
            this.OpenUserFolderBTN.Location = new System.Drawing.Point(28, 148);
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
            this.pictureBox2.Location = new System.Drawing.Point(18, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 130);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(27, 87);
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
            this.CloseDGSChkbx.Location = new System.Drawing.Point(30, 58);
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
            this.HideDGSChkbx.Location = new System.Drawing.Point(30, 40);
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
            this.label1.Location = new System.Drawing.Point(27, 24);
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
            this.DeleteSChkbx.Location = new System.Drawing.Point(30, 105);
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
            this.ExtrasText.Location = new System.Drawing.Point(27, 6);
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
            this.pictureBox1.Size = new System.Drawing.Size(196, 130);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // RefreshBTN
            // 
            this.RefreshBTN.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RefreshBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RefreshBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RefreshBTN.Location = new System.Drawing.Point(28, 235);
            this.RefreshBTN.Name = "RefreshBTN";
            this.RefreshBTN.Size = new System.Drawing.Size(177, 23);
            this.RefreshBTN.TabIndex = 18;
            this.RefreshBTN.Text = "Refresh Shorcut List";
            this.RefreshBTN.UseVisualStyleBackColor = false;
            this.RefreshBTN.Click += new System.EventHandler(this.RefreshBTN_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.LaunchBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grey);
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
            this.Grey.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox GameToLaunch;
        private System.Windows.Forms.Button LaunchBTN;
        private System.Windows.Forms.Panel Grey;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button AddGameBTN;
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
        private System.Windows.Forms.Label DGS_Name_Label;
        private System.Windows.Forms.Button RefreshBTN;
    }
}

