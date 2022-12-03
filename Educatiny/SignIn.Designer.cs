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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // signinbtn
            // 
            this.signinbtn.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signinbtn.ForeColor = System.Drawing.Color.LimeGreen;
            this.signinbtn.Location = new System.Drawing.Point(267, 339);
            this.signinbtn.Name = "signinbtn";
            this.signinbtn.Size = new System.Drawing.Size(208, 45);
            this.signinbtn.TabIndex = 0;
            this.signinbtn.Text = "Connexion";
            this.signinbtn.UseVisualStyleBackColor = true;
            this.signinbtn.Click += new System.EventHandler(this.signinbtn_Click);
            // 
            // passwordbox
            // 
            this.passwordbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordbox.Location = new System.Drawing.Point(295, 289);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.PlaceholderText = "Mot de passe";
            this.passwordbox.Size = new System.Drawing.Size(180, 20);
            this.passwordbox.TabIndex = 1;
            this.passwordbox.UseSystemPasswordChar = true;
            // 
            // emailbox
            // 
            this.emailbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailbox.Location = new System.Drawing.Point(295, 238);
            this.emailbox.Name = "emailbox";
            this.emailbox.PlaceholderText = "Email";
            this.emailbox.Size = new System.Drawing.Size(180, 20);
            this.emailbox.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.Green;
            this.linkLabel1.Location = new System.Drawing.Point(311, 387);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(119, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Créer un compte";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Educatiny.Properties.Resources.mail;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(267, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(24, 23);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Educatiny.Properties.Resources._lock;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(267, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(24, 24);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(267, 262);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 1);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(267, 315);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(208, 1);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::Educatiny.Properties.Resources.logo;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(311, 164);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(119, 47);
            this.panel5.TabIndex = 8;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Educatiny.Properties.Resources.signin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(741, 621);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.signinbtn);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button signinbtn;
        private TextBox passwordbox;
        private TextBox emailbox;
        private LinkLabel linkLabel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}