using System.Data.SqlClient;

namespace Educatiny
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection("Data Source=WASSIM-PC\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            SqlCommand cmd = new SqlCommand("insert into [User] (email,password) values (@email,@password)", con);
            cmd.Parameters.AddWithValue("@email", emailbox.Text);
            cmd.Parameters.AddWithValue("@password", passbox.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
            }
            catch
            {
            MessageBox.Show("Error");
            }
            finally
            {
            con.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }
    }
}