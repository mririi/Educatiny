using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

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
            SqlDataAdapter cmd = new SqlDataAdapter("select m.nom,note from [Quiz] q,[Matiere] m where q.IDMatiere=m.ID and IDUser='"+user+"'", con);
            DataTable dtable = new DataTable();
            cmd.Fill(dtable);

            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Location = new System.Drawing.Point(12, 107);
            flowLayoutPanel.Margin = new System.Windows.Forms.Padding(15);
            flowLayoutPanel.Padding = new System.Windows.Forms.Padding(30);
            flowLayoutPanel.Size = new System.Drawing.Size(700, 500);
            flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            Controls.Add(flowLayoutPanel);
            Label mat = new Label();
            Label note = new Label();
            mat.Text = "Subject";
            note.Text = "Note";
            mat.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            note.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mat.Size = new System.Drawing.Size(300, 100);
            note.Size = new System.Drawing.Size(300,100);

            flowLayoutPanel.Controls.Add(mat);
            flowLayoutPanel.Controls.Add(note);
            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                Label matlab = new Label();
                Label notelab = new Label();
                matlab.Size = new System.Drawing.Size(300, 70);
                notelab.Size = new System.Drawing.Size(300, 70);
                matlab.Text = dtable.Rows[i][0].ToString();
                notelab.Text = dtable.Rows[i][1].ToString();
                matlab.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                notelab.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                flowLayoutPanel.Controls.Add(matlab);
                flowLayoutPanel.Controls.Add(notelab);

                //SqlDataAdapter cmdMatiere = new SqlDataAdapter("select nom from [Matiere] where ID='"+ dtable.Rows[i][2].ToString()+"'", con);
                //DataTable dtableMatiere = new DataTable();
                //cmdMatiere.Fill(dtableMatiere);
                //dataGridView1.Rows.Add(dtableMatiere.Rows[0][0].ToString(), dtable.Rows[i][0].ToString());
            }
        }
    }
}
