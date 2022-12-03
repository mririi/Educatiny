using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educatiny
{
    public partial class Quiz : Form
    {
        public string user { get; set; }
        public Quiz()
        {
            InitializeComponent();
            CenterToScreen();
        }
        SqlConnection con = new SqlConnection("Data Source=WASSIM-PC\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True");
        private void OnButtonClick(object sender, EventArgs e)
        {
            string matiere = ((Button)sender).Text;
            SqlDataAdapter cmd = new SqlDataAdapter("select * from [Quiz] where IDUser='"+user+"' and IDMatiere=(select ID from [Matiere] where nom='"+matiere+"')", con);
            DataTable dtable = new DataTable();
            cmd.Fill(dtable);
            if (dtable.Rows.Count > 0)
            {
                MessageBox.Show("Vous avez déja fait ce Quiz!");
            }
            else
            {
            QuizContent window = new QuizContent();
            window.stdname = matiere;
            window.user =user;
            window.Show();
            }
        }
        private void Quiz_Load(object sender, EventArgs e)
        {
            SqlDataAdapter cmd = new SqlDataAdapter("select * from [Matiere]", con);
            DataTable dtable = new DataTable();
            cmd.Fill(dtable);

            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Location = new System.Drawing.Point(116, 167);
            flowLayoutPanel.Size = new System.Drawing.Size(508, 424);
            Controls.Add(flowLayoutPanel);

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                Button btn = new Button();
                btn.Text = dtable.Rows[i][1].ToString();
                btn.Name = dtable.Rows[i][1].ToString();
                btn.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                btn.BackColor = System.Drawing.Color.FromName(dtable.Rows[i][3].ToString());
                btn.ForeColor = System.Drawing.Color.White;
                btn.Image = global::Educatiny.Properties.Resources.trigonometry;
                btn.Location = new System.Drawing.Point(3, 3);
                btn.Size = new System.Drawing.Size(248, 100);
                btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                btn.UseVisualStyleBackColor = false;
                flowLayoutPanel.Controls.Add(btn);
                btn.Click += new EventHandler(OnButtonClick);
            }
        }
    }
}
