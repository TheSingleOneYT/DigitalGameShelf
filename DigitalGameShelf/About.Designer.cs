
namespace DigitalGameShelf
{
    partial class About
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.Grey = new System.Windows.Forms.Panel();
            this.DGS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GithubBTN = new System.Windows.Forms.Button();
            this.YouTubeBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Grey.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseButton.Location = new System.Drawing.Point(522, 39);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Grey
            // 
            this.Grey.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Grey.Controls.Add(this.CloseButton);
            this.Grey.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Grey.Location = new System.Drawing.Point(-32, -36);
            this.Grey.Name = "Grey";
            this.Grey.Size = new System.Drawing.Size(853, 67);
            this.Grey.TabIndex = 4;
            // 
            // DGS
            // 
            this.DGS.AutoSize = true;
            this.DGS.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DGS.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGS.Location = new System.Drawing.Point(168, 34);
            this.DGS.Name = "DGS";
            this.DGS.Size = new System.Drawing.Size(174, 73);
            this.DGS.TabIndex = 25;
            this.DGS.Text = "DGS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(145, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "By TheSingleOne";
            // 
            // GithubBTN
            // 
            this.GithubBTN.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GithubBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GithubBTN.Location = new System.Drawing.Point(12, 158);
            this.GithubBTN.Name = "GithubBTN";
            this.GithubBTN.Size = new System.Drawing.Size(498, 23);
            this.GithubBTN.TabIndex = 27;
            this.GithubBTN.Text = "Github: DigitalGameShelf";
            this.GithubBTN.UseVisualStyleBackColor = false;
            this.GithubBTN.Click += new System.EventHandler(this.GithubBTN_Click);
            // 
            // YouTubeBTN
            // 
            this.YouTubeBTN.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.YouTubeBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.YouTubeBTN.Location = new System.Drawing.Point(12, 187);
            this.YouTubeBTN.Name = "YouTubeBTN";
            this.YouTubeBTN.Size = new System.Drawing.Size(233, 23);
            this.YouTubeBTN.TabIndex = 28;
            this.YouTubeBTN.Text = "YouTube: TheSingleOne YT";
            this.YouTubeBTN.UseVisualStyleBackColor = false;
            this.YouTubeBTN.Click += new System.EventHandler(this.YouTubeBTN_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(277, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Twitter: @TheSingleOneYT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(145, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Github: TheSingleOne";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(522, 258);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.YouTubeBTN);
            this.Controls.Add(this.GithubBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGS);
            this.Controls.Add(this.Grey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Grey.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel Grey;
        private System.Windows.Forms.Label DGS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GithubBTN;
        private System.Windows.Forms.Button YouTubeBTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}