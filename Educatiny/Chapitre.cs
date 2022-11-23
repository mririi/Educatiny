using System.Data.SqlClient;
using System.Data;
namespace Educatiny
{
    public partial class Chapitre : Form
    {
        public string stdname { get; set; }

        public Chapitre()
        {
            InitializeComponent();
        }
        private int Y = 0;
        SqlConnection con = new SqlConnection("Data Source=WASSIM-PC\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True");

        private void OnButtonClick(object sender, EventArgs e)
        {
            string matiere = ((Button)sender).Text;
            ChapitreContent ch = new ChapitreContent();
            ch.stdname = matiere;
            ch.Show();
        }
        private void Chapitre_Load(object sender, EventArgs e)
        {
            label1.Text += stdname;
            SqlDataAdapter cmd = new SqlDataAdapter("select * from [Chapitre] where matiereID=(select ID from Matiere where nom='"+stdname+"')", con);
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

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
