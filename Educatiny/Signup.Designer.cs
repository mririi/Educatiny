﻿namespace Educatiny
{
    partial class Signup
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.emailbox = new System.Windows.Forms.TextBox();
            this.passbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // emailbox
            // 
            this.emailbox.Location = new System.Drawing.Point(87, 56);
            this.emailbox.Name = "emailbox";
            this.emailbox.PlaceholderText = "Email";
            this.emailbox.Size = new System.Drawing.Size(161, 27);
            this.emailbox.TabIndex = 0;
            this.emailbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passbox
            // 
            this.passbox.BackColor = System.Drawing.SystemColors.Window;
            this.passbox.Location = new System.Drawing.Point(87, 120);
            this.passbox.Name = "passbox";
            this.passbox.PlaceholderText = "Password";
            this.passbox.Size = new System.Drawing.Size(161, 27);
            this.passbox.TabIndex = 1;
            this.passbox.UseSystemPasswordChar = true;
            this.passbox.TextChanged += new System.EventHandler(this.passbox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(127, 226);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign In";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 268);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.emailbox);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox emailbox;
        private TextBox passbox;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}