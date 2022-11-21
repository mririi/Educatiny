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
using static System.Windows.Forms.LinkLabel;

namespace Educatiny
{
    public partial class Enjoy : Form
    {
        public Enjoy()
        {
            InitializeComponent();
        }
        public string user { get; set; }
        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void Enjoy_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        SqlConnection con = new SqlConnection("Data Source=WASSIM-PC\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True");

        public async void InitBrowser()
        {
            await initizated();
            SqlDataAdapter cmdd = new SqlDataAdapter("select IDLoisir from [User] where ID='" + user + "'", con);
            DataTable dtablee = new DataTable();
            cmdd.Fill(dtablee);
            string id="";
            if (dtablee.Rows.Count > 0)
            {
                id = dtablee.Rows[0][0].ToString();
            }
            if (id!="")
            {
            SqlDataAdapter cmd = new SqlDataAdapter("select lien from [Jeu] where IDLoisir='" + id + "'", con);
            DataTable dtable = new DataTable();
            cmd.Fill(dtable);
            String Link = "https://www.friv.com/z/games/";
            if (dtable.Rows.Count > 0)
            {
                Link = dtable.Rows[0][0].ToString();
            }

            webView21.CoreWebView2.Navigate(Link);
            }
            else
            {
                webView21.CoreWebView2.Navigate("https://www.friv.com/z/games/");
            }
        }
    }
}
