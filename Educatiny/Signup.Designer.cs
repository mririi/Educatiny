namespace Educatiny
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
            this.ageBox = new System.Windows.Forms.TextBox();
            this.sexeBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nomBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.prenomBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // emailbox
            // 
            this.emailbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailbox.Location = new System.Drawing.Point(265, 278);
            this.emailbox.Name = "emailbox";
            this.emailbox.PlaceholderText = "Email";
            this.emailbox.Size = new System.Drawing.Size(215, 20);
            this.emailbox.TabIndex = 0;
            this.emailbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passbox
            // 
            this.passbox.BackColor = System.Drawing.SystemColors.Window;
            this.passbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passbox.Location = new System.Drawing.Point(265, 302);
            this.passbox.Name = "passbox";
            this.passbox.PlaceholderText = "Mot de passe";
            this.passbox.Size = new System.Drawing.Size(215, 20);
            this.passbox.TabIndex = 1;
            this.passbox.UseSystemPasswordChar = true;
            this.passbox.TextChanged += new System.EventHandler(this.passbox_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.LimeGreen;
            this.button1.Location = new System.Drawing.Point(265, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Créer un compte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.Green;
            this.linkLabel1.Location = new System.Drawing.Point(320, 416);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Connexion";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ageBox
            // 
            this.ageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ageBox.Location = new System.Drawing.Point(265, 231);
            this.ageBox.Name = "ageBox";
            this.ageBox.PlaceholderText = "Age";
            this.ageBox.Size = new System.Drawing.Size(215, 20);
            this.ageBox.TabIndex = 7;
            this.ageBox.TextChanged += new System.EventHandler(this.ageBox_TextChanged);
            // 
            // sexeBox
            // 
            this.sexeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sexeBox.Location = new System.Drawing.Point(265, 254);
            this.sexeBox.Name = "sexeBox";
            this.sexeBox.PlaceholderText = "Sexe";
            this.sexeBox.Size = new System.Drawing.Size(215, 20);
            this.sexeBox.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(265, 327);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Loisir";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::Educatiny.Properties.Resources.logo;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(311, 121);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(119, 47);
            this.panel5.TabIndex = 9;
            // 
            // nomBox
            // 
            this.nomBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomBox.Location = new System.Drawing.Point(265, 182);
            this.nomBox.Name = "nomBox";
            this.nomBox.PlaceholderText = "Nom";
            this.nomBox.Size = new System.Drawing.Size(215, 20);
            this.nomBox.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(265, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 1);
            this.panel3.TabIndex = 10;
            // 
            // prenomBox
            // 
            this.prenomBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prenomBox.Location = new System.Drawing.Point(265, 207);
            this.prenomBox.Name = "prenomBox";
            this.prenomBox.PlaceholderText = "Prenom";
            this.prenomBox.Size = new System.Drawing.Size(215, 20);
            this.prenomBox.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(265, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 1);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(265, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 1);
            this.panel2.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(265, 273);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 1);
            this.panel4.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel6.Location = new System.Drawing.Point(265, 297);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(215, 1);
            this.panel6.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel7.Location = new System.Drawing.Point(265, 321);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(215, 1);
            this.panel7.TabIndex = 16;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Educatiny.Properties.Resources.signup;
            this.ClientSize = new System.Drawing.Size(741, 621);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.prenomBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.sexeBox);
            this.Controls.Add(this.nomBox);
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
        private TextBox nomBox;
        private TextBox ageBox;
        private TextBox sexeBox;
        private ComboBox comboBox1;
        private Panel panel5;
        private Panel panel3;
        private TextBox prenomBox;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel6;
        private Panel panel7;
    }
}