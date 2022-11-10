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
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
using static System.Windows.Forms.LinkLabel;

namespace Educatiny
{
    public partial class ChapitreContent : Form
    {
        

        public string stdname { get; set; }
        public ChapitreContent()
        {
            InitializeComponent();
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=WASSIM-PC\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True");

        private void ChapitreContent_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
        private async Task initizated()
        {
            await webView2.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowser()
        {
            await initizated();
            SqlDataAdapter cmd = new SqlDataAdapter("select video from [Chapitre] where titre='" + stdname + "'", con);
            DataTable dtable = new DataTable();
            cmd.Fill(dtable);
            String Link = "https://www.youtube.com";
            if (dtable.Rows.Count>0)
            {
                Link = dtable.Rows[0][0].ToString();
            }
                webView2.CoreWebView2.Navigate(Link);
        }
        private void webView2_Click(object sender, EventArgs e)
        {

        }
    }
}
