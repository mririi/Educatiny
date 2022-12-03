namespace Educatiny
{
    partial class Home
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Educatiny.Properties.Resources.book;
            this.button1.Location = new System.Drawing.Point(102, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cours";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenue";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Educatiny.Properties.Resources.quiz;
            this.button2.Location = new System.Drawing.Point(391, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 100);
            this.button2.TabIndex = 2;
            this.button2.Text = "Quiz";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Educatiny.Properties.Resources.evaluation;
            this.button3.Location = new System.Drawing.Point(102, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(248, 100);
            this.button3.TabIndex = 3;
            this.button3.Text = "Notes";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Educatiny.Properties.Resources.joystick;
            this.button4.Location = new System.Drawing.Point(391, 384);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(248, 100);
            this.button4.TabIndex = 4;
            this.button4.Text = "Enjoy";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Educatiny.Properties.Resources.logo1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(284, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 64);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(1, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 2);
            this.panel2.TabIndex = 6;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(636, 90);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 20);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Déconnecter";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 621);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Panel panel2;
        private LinkLabel linkLabel1;
    }
}