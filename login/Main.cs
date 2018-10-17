using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace login
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new add_member().Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            calculetor c = new calculetor();
            c.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Purchase_product().Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new fees().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          //  lie.Windowstate = FormWindowState.Minimized;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Pending_fees().Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            new user_account().Show();
            this.Hide();
        }
    }
}
