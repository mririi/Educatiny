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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Educatiny
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1QNC461\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True");
        private void signinbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter cmd = new SqlDataAdapter("select * from [User] where email = '" + emailbox.Text + "' and password= '" + passwordbox.Text + "'", con);
                DataTable dtable = new DataTable();
                cmd.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }
    }
}
