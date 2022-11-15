using System.Data.SqlClient;
using System.Net.Mail;

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
        SqlConnection con = new SqlConnection("Data Source=WASSIM-PC\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            /*if (emailbox.Text == "" || nomBox.Text == "" || prenomBox.Text == "" || sexeBox.Text == "" || ageBox.Text == "")
            {
                MessageBox.Show("Les champs ne doivent pas etre vide!");
                return;
            }*/
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
            SqlCommand cmd = new SqlCommand("insert into [User] (email,password,nom,prenom,sexe,age) values (@email,@password,@nom,@prenom,@sexe,@age)", con);
            cmd.Parameters.AddWithValue("@email", emailbox.Text);
            cmd.Parameters.AddWithValue("@password", passbox.Text);
            cmd.Parameters.AddWithValue("@nom", nomBox.Text);
            cmd.Parameters.AddWithValue("@prenom", prenomBox.Text);
            cmd.Parameters.AddWithValue("@sexe", sexeBox.Text);
            cmd.Parameters.AddWithValue("@age", ageBox.Text);
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