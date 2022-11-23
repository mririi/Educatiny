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
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public string user { get; set; }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=WASSIM-PC\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True");

        private void Notes_Load(object sender, EventArgs e)
        {
            SqlDataAdapter cmd = new SqlDataAdapter("select note,IDUser,IDMatiere from [Quiz] where IDUser='"+user+"'", con);
            DataTable dtable = new DataTable();
            cmd.Fill(dtable);
            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                SqlDataAdapter cmdMatiere = new SqlDataAdapter("select nom from [Matiere] where ID='"+ dtable.Rows[i][2].ToString()+"'", con);
                DataTable dtableMatiere = new DataTable();
                cmdMatiere.Fill(dtableMatiere);
                dataGridView1.Rows.Add(dtableMatiere.Rows[0][0].ToString(), dtable.Rows[i][0].ToString());
            }
        }
    }
}
