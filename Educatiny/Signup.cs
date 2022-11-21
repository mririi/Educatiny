using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Educatiny
{
    public partial class Signup : Form
    {
        SqlConnection con = new SqlConnection("Data Source=WASSIM-PC\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True");
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
            SqlDataAdapter cmd1 = new SqlDataAdapter("select nom from [Loisir]", con);
            DataTable dtable1 = new DataTable();
            cmd1.Fill(dtable1);
            for (int i=0;i<dtable1.Rows.Count;i++)
            {
                comboBox1.Items.Add(dtable1.Rows[i][0].ToString());
            }
        }
        private static bool IsValid(string email)
        {
            var valid = true;

            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }

            return valid;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (emailbox.Text == "" || nomBox.Text == "" || prenomBox.Text == "" || sexeBox.Text == "" || ageBox.Text == "")
            {
                MessageBox.Show("Les champs ne doivent pas etre vide!");
                return;
            }
            if (IsValid(emailbox.Text)==false)
            {
                MessageBox.Show("Saisir un email valide!");
                return;
            }
            if (passbox.Text.Length<6)
            {
                MessageBox.Show("Saisir un mot de passe de taille plus que 6 characters!");
                return;
            }
            try
            {
                Int32.Parse(ageBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("L'age doit etre un entier!");
                return;
            }
            try
            {
            SqlCommand cmd = new SqlCommand("insert into [User] (email,password,nom,prenom,sexe,age,IDLoisir) values (@email,@password,@nom,@prenom,@sexe,@age,@IDLoisir)", con);
            cmd.Parameters.AddWithValue("@email", emailbox.Text);
            cmd.Parameters.AddWithValue("@password", passbox.Text);
            cmd.Parameters.AddWithValue("@nom", nomBox.Text);
            cmd.Parameters.AddWithValue("@prenom", prenomBox.Text);
            cmd.Parameters.AddWithValue("@sexe", sexeBox.Text);
            cmd.Parameters.AddWithValue("@age", ageBox.Text);
            SqlDataAdapter cmd1 = new SqlDataAdapter("select ID from [Loisir] where nom='"+comboBox1.SelectedItem+"'", con);
            DataTable dtable1 = new DataTable();
            cmd1.Fill(dtable1);
            cmd.Parameters.AddWithValue("@IDLoisir", dtable1.Rows[0][0].ToString());
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


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}