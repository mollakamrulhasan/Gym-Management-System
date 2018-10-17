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
    public partial class user_account : Form
    {
        public user_account()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\gym project\login\login\gym.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
         
            SqlCommand cmd1 = new SqlCommand("INSERT INTO login (Username,Password) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "')", cn1);
           

            try
            {
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Successfully Saved");
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to save on database");
                cn1.Close();
                
            }
            

        }
        private void  cleartext()
        {
           
        }

        private void save_Click(object sender, EventArgs e)
        {
           
             string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\gym project\login\login\gym.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
         
            SqlCommand cmd1 = new SqlCommand("INSERT INTO login (Username,Password) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "')", cn1);
           

            try
            {
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Successfully Saved");
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to save on database");
                cn1.Close();
                
            }
        
        }

        private void chang_Click(object sender, EventArgs e)
        {
             
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\gym project\login\login\gym.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();

            SqlCommand cmd1 = new SqlCommand(" update login set Password='"+textBox3.Text+"' where Username='"+textBox1.Text+"' ", cn1);


            try
            {
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Successfully Saved :V");
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to save on database");
                cn1.Close();

            }
        }


        }

       
    }


