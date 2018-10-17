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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string user;
        private void button2_Click(object sender, EventArgs e)
        {
            if (user == "Admin")
            {
                SqlConnection log = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\login\login\gym.mdf;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", log);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();

                    Main ss = new Main();
                    ss.Show();
                }
                else
                {
                    MessageBox.Show("Please Check your Username & Password");
                }
                // Main ss = new Main();
                // ss.Show();

            }
            else if (user == "User")
            {

                SqlConnection log = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\login\login\gym.mdf;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", log);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();

                        link l = new link();
                        l.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please Check your Username & Password");
                    }


                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            user = "Admin";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            user = "User";
        }
    }
}
