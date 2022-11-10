using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Educatiny
{
    public partial class Cours : Form
    {
        public Cours()
        {
            InitializeComponent();
        }

        
        int Y = 0;
        SqlConnection con = new SqlConnection("Data Source=WASSIM-PC\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True");
        public string user { get; set; }
        private void OnButtonClick(object sender, EventArgs e)
        {
            string matiere = ((Button)sender).Text;
            Chapitre ch = new Chapitre();
            ch.stdname = matiere;
            ch.Show();
        }
        private void Cours_Load(object sender, EventArgs e)
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
                if(i % 2 == 0)
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
