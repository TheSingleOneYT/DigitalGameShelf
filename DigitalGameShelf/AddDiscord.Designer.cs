
namespace DigitalGameShelf
{
    partial class AddDiscordForm
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
            this.Grey = new System.Windows.Forms.Panel();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Grey.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grey
            // 
            this.Grey.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Grey.Controls.Add(this.CloseBTN);
            this.Grey.Controls.Add(this.CloseButton);
            this.Grey.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Grey.Location = new System.Drawing.Point(-266, -42);
            this.Grey.Name = "Grey";
            this.Grey.Size = new System.Drawing.Size(590, 67);
            this.Grey.TabIndex = 8;
            // 
            // CloseBTN
            // 
            this.CloseBTN.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CloseBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseBTN.Location = new System.Drawing.Point(558, 42);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(26, 23);
            this.CloseBTN.TabIndex = 5;
            this.CloseBTN.Text = "X";
            this.CloseBTN.UseVisualStyleBackColor = false;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseButton.Location = new System.Drawing.Point(780, 40);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Discord As An App";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Discord Directory";
            // 
            // AddDiscordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 100);
            this.ControlBox = false;
            this.Controls.Add(this.Grey);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddDiscordForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Discord - DigitalGameShelf";
            this.Grey.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Grey;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}