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
        public Quiz()
        {
            InitializeComponent();
        }
        public string user { get; set; }
        int Y = 0;
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
            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                Button btn = new Button();
                btn.Text = dtable.Rows[i][1].ToString();
                btn.Name = dtable.Rows[i][1].ToString();
                btn.Click += new EventHandler(OnButtonClick);
                btn.Size = new Size(300, 100);
                if (i % 2 == 0)
                {
                    btn.Location = new Point(90, 100 * (Y + 1));
                }
                else
                {
                    btn.Location = new Point(450, 100 * Y);
                }
                Y++;
                Controls.Add(btn);
            }
        }
    }
}
