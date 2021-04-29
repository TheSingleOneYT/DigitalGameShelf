﻿
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.SFBTN = new System.Windows.Forms.Button();
            this.AddGameBTN = new System.Windows.Forms.Button();
            this.Grey.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 355);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // GameToLaunch
            // 
            this.GameToLaunch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameToLaunch.Location = new System.Drawing.Point(12, 401);
            this.GameToLaunch.Name = "GameToLaunch";
            this.GameToLaunch.Size = new System.Drawing.Size(691, 20);
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
            this.Grey.Controls.Add(this.SFBTN);
            this.Grey.Controls.Add(this.CloseButton);
            this.Grey.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Grey.Location = new System.Drawing.Point(-18, -36);
            this.Grey.Name = "Grey";
            this.Grey.Size = new System.Drawing.Size(853, 67);
            this.Grey.TabIndex = 3;
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
            // SFBTN
            // 
            this.SFBTN.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SFBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SFBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SFBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SFBTN.Location = new System.Drawing.Point(686, 40);
            this.SFBTN.Name = "SFBTN";
            this.SFBTN.Size = new System.Drawing.Size(88, 23);
            this.SFBTN.TabIndex = 5;
            this.SFBTN.Text = "Shorcut Folder";
            this.SFBTN.UseVisualStyleBackColor = false;
            this.SFBTN.Click += new System.EventHandler(this.SFBTN_Click);
            // 
            // AddGameBTN
            // 
            this.AddGameBTN.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddGameBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddGameBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGameBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddGameBTN.Location = new System.Drawing.Point(30, 40);
            this.AddGameBTN.Name = "AddGameBTN";
            this.AddGameBTN.Size = new System.Drawing.Size(178, 23);
            this.AddGameBTN.TabIndex = 6;
            this.AddGameBTN.Text = "Add A Game To The Shelf";
            this.AddGameBTN.UseVisualStyleBackColor = false;
            this.AddGameBTN.Click += new System.EventHandler(this.AddGameBTN_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.LaunchBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.ControlBox = false;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox GameToLaunch;
        private System.Windows.Forms.Button LaunchBTN;
        private System.Windows.Forms.Panel Grey;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SFBTN;
        private System.Windows.Forms.Button AddGameBTN;
    }
}

