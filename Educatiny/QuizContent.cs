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
    public partial class QuizContent : Form
    {
        private DataTable qtable = new DataTable();
        private string questID;
        private int nbrightanswers = 0;
        private int nbq = 0;
        private int nbbtn = 0;
        private int Y = 0;
        private string answer;
        private int i = 0;
        private double note = 0;
        private String type;
        private SqlConnection con = new SqlConnection("Data Source=WASSIM-PC\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True");

        public string stdname { get; set; }
        public string user { get; set; }
        public QuizContent()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            if (qtable.Rows[i][2].ToString() == "Radiobutton")
            {
                answer = ((RadioButton)sender).Text;
            }
            else if (qtable.Rows[i][2].ToString() == "Checkbox")
            {
                answer = ((CheckBox)sender).Text;
            }
        }

        private void deletebtn()
        {
            foreach (FlowLayoutPanel rb in Controls.OfType<FlowLayoutPanel>())
            {
                Controls.Remove(rb);
            }
        }
        private void askQuestion(int i)
        {
            if (i < nbq)
            {
                label2.Text = qtable.Rows[i][1].ToString();
                label2.Location = new System.Drawing.Point(265, 280);
                SqlDataAdapter cmd1 = new SqlDataAdapter("select * from [Reponse] where IDQuestion='" + qtable.Rows[i][0].ToString() + "'", con);
                DataTable dtable1 = new DataTable();
                cmd1.Fill(dtable1);
                nbbtn = dtable1.Rows.Count;

                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.AutoScroll = true;
                flowLayoutPanel.Location = new System.Drawing.Point(240, 297);
                flowLayoutPanel.Margin = new System.Windows.Forms.Padding(15);
                flowLayoutPanel.Padding = new System.Windows.Forms.Padding(30);
                flowLayoutPanel.Size = new System.Drawing.Size(293, 128);
                Controls.Add(flowLayoutPanel);
                for (int j = 0; j < dtable1.Rows.Count; j++)
                {
                    if (qtable.Rows[i][2].ToString() == "Radiobutton")
                    {
                        type = "Radiobutton";
                        RadioButton btn = new RadioButton();
                        btn.Text = dtable1.Rows[j][1].ToString();
                        btn.Name = dtable1.Rows[j][1].ToString();
                        
                        if (dtable1.Rows[j][2].ToString() == "1")
                        {
                            nbrightanswers++;
                        }
                        btn.Click += new EventHandler(OnButtonClick);
                        flowLayoutPanel.Controls.Add(btn);
                    }
                    else if (qtable.Rows[i][2].ToString() == "Checkbox")
                    {
                        type = "Checkbox";
                        CheckBox btn = new CheckBox();
                        btn.Text = dtable1.Rows[j][1].ToString();
                        btn.Name = dtable1.Rows[j][1].ToString();
                        if (dtable1.Rows[j][2].ToString() == "1")
                        {
                            nbrightanswers++;
                            
                        }
                        btn.Click += new EventHandler(OnButtonClick);
                        flowLayoutPanel.Controls.Add(btn);
                    }
                }
                questID = qtable.Rows[i][0].ToString();
            }
        }
        private void QuizContent_Load(object sender, EventArgs e)
        {
            label1.Text += stdname;
            SqlDataAdapter cmd = new SqlDataAdapter("select * from [Question] where IDMatiere=(select ID from Matiere where nom='" + stdname + "')", con);
            cmd.Fill(qtable);
            nbq = qtable.Rows.Count;
            askQuestion(0);

        }

        private void checkanswer(string answer)
        {
            SqlDataAdapter cmd1 = new SqlDataAdapter("select * from [Reponse] where IDQuestion='" + questID + "' and reponse='" + answer + "'", con);
            DataTable dtable1 = new DataTable();
            cmd1.Fill(dtable1);
            if (dtable1.Rows.Count > 0 && dtable1.Rows[0][2].ToString() == "1")
            {
                note++;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            deletebtn();
            checkanswer(answer);
            askQuestion(i);
            if (i == nbq)
            {
                try
                {
                    SqlDataAdapter cmd1 = new SqlDataAdapter("select ID from [Matiere] where nom='" + stdname + "'", con);
                    DataTable dtable1 = new DataTable();
                    cmd1.Fill(dtable1);
                    SqlCommand cmd = new SqlCommand("insert into [Quiz] (note,IDMatiere,IDUser) values (@note,@IDMatiere,@IDUser)", con);
                    cmd.Parameters.AddWithValue("@note", Convert.ToDouble(String.Format("{0:0.00}", 20 * note / nbrightanswers)));
                    cmd.Parameters.AddWithValue("@IDMatiere", dtable1.Rows[0][0].ToString());
                    cmd.Parameters.AddWithValue("@IDUser", user);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
                finally
                {
                    con.Close();
                    Hide();
                    Notes window = new Notes();
                    window.user = user;
                    window.Show();
                }
            }
        }
    }
}
