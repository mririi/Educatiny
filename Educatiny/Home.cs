using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educatiny
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public string user { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            Cours window = new Cours();
            window.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quiz window = new Quiz();
            window.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Enjoy window = new Enjoy();
            window.user=user;
            window.Show();
        }
    }
}
