using System.Data;
using System.Data.SqlClient;

namespace Educatiny
{
    public partial class Cours : Form
    {
        public Cours()
        {
            InitializeComponent();
        }

        
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
