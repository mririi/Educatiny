namespace Educatiny
{
    partial class SignIn
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
            this.signinbtn = new System.Windows.Forms.Button();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // signinbtn
            // 
            this.signinbtn.Location = new System.Drawing.Point(205, 177);
            this.signinbtn.Name = "signinbtn";
            this.signinbtn.Size = new System.Drawing.Size(94, 29);
            this.signinbtn.TabIndex = 0;
            this.signinbtn.Text = "Sign In";
            this.signinbtn.UseVisualStyleBackColor = true;
            this.signinbtn.Click += new System.EventHandler(this.signinbtn_Click);
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(196, 118);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.PlaceholderText = "Password";
            this.passwordbox.Size = new System.Drawing.Size(125, 27);
            this.passwordbox.TabIndex = 1;
            this.passwordbox.UseSystemPasswordChar = true;
            // 
            // emailbox
            // 
            this.emailbox.Location = new System.Drawing.Point(196, 64);
            this.emailbox.Name = "emailbox";
            this.emailbox.PlaceholderText = "Email";
            this.emailbox.Size = new System.Drawing.Size(125, 27);
            this.emailbox.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(214, 227);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign Up";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 273);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.signinbtn);
            this.Name = "SignIn";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button signinbtn;
        private TextBox passwordbox;
        private TextBox emailbox;
        private LinkLabel linkLabel1;
    }
}