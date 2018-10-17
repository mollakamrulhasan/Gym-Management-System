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
    public partial class link : Form
    {
        public link()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Pending_fees().Show();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new calculetor().Show();
         
        }

        private void acc_Click(object sender, EventArgs e)
        {
            user_account mango = new user_account();
            mango.Show();
        }
    }
}
