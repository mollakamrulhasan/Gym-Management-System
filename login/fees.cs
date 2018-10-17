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
    public partial class fees : Form
    {
        public fees()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\login\login\gym.mdf;Integrated Security=True";
            SqlConnection cn1 = new SqlConnection(cns);

            cn1.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select *from m_fees", cn1);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            // dataGridView1.DataSource = data1;
            dataGridView1.DataSource = data1;
            cn1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\login\login\gym.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();

            SqlCommand cmd1 = new SqlCommand("INSERT INTO m_fees (Rec_no,Name,Workout,Fees_mode,Fees,Date) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "', '" + comboBox2.Text + "','" + comboBox1.Text + "', '" + textBox3.Text + "', '" + dateTimePicker1.Text + "')", cn1);
           

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
            cleartext();

        }
        private void  cleartext()
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            comboBox2.Text= " ";
            comboBox1.Text = " ";
            textBox3.Text = " ";
           
        }

        private void button0_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\login\login\gym.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
            SqlCommand cmd1 = new SqlCommand("DELETE FROM m_fees where rec_no='" + textBox1.Text + "'", cn1);


            try
            {
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Successfully remove");
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to remove on database");
                cn1.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\login\login\gym.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();

            SqlCommand cmd1 = new SqlCommand("update  m_fees set Name='" + textBox2.Text + "',Workout='" + comboBox2.Text + "',Fees_mode='" + comboBox1.Text + "',Fees='" + textBox3.Text + "'  where Rec_no='" + textBox1.Text + "'", cn1);


            try
            {
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Successfully edited");
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to update on database");
                cn1.Close();

            }
        }
    }
}
