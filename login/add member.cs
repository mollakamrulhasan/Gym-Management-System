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
    public partial class add_member : Form
    {
        public add_member()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\login\login\gym.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
         
            SqlCommand cmd1 = new SqlCommand("INSERT INTO member (Rec_no,Name,Gender,Height,Weight,Contact,Batch,Member,Workout,Fees_mode) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "', '" + comboBox1.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "','" + comboBox3.Text + "', '" + comboBox4.Text + "', '" + comboBox5.Text + "','"+comboBox6.Text+"')", cn1);
           

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
            comboBox1.Text= " ";
            textBox3.Text = " ";
            comboBox2.Text = " ";
            textBox4.Text = " ";
            comboBox7.Text = " ";
            textBox5.Text = " ";
            comboBox3.Text = " ";
            comboBox4.Text = " ";
            comboBox5.Text = " ";
            comboBox6.Text = " ";
        }



        private void button2_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\login\login\gym.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();

            //SqlCommand cmd1 = new SqlCommand("update  member set Name='" + textBox2.Text + "',Height='" + textBox3.Text + "',Weight='" + textBox4.Text + "',Contact='" + textBox5.Text + "',Batch='" + comboBox4.Text + "',Member='" + comboBox5.Text + "',Workout='" + comboBox5.Text + "',Fees_mode='" + comboBox5.Text + "' where Rec_no='" + textBox1.Text + "')", cn1);

            SqlCommand cmd1 = new SqlCommand("update  member set Name='" + textBox2.Text + "',Height='" + textBox3.Text + "',Weight='" + textBox4.Text + "',Contact='" + textBox5.Text + "',Batch='" + comboBox4.Text + "',Member='" + comboBox5.Text + "',Workout='" + comboBox5.Text + "',Fees_mode='" + comboBox5.Text + "'  where Rec_no='" + textBox1.Text + "'", cn1);


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

        private void button3_Click(object sender, EventArgs e)
        {

            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\login\login\gym.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
            SqlCommand cmd1 = new SqlCommand("DELETE FROM member where rec_no='" + textBox1.Text + "'", cn1);


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

        private void button4_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\login\login\gym.mdf;Integrated Security=True";
            SqlConnection cn1 = new SqlConnection(cns);

            cn1.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select *from member", cn1);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            // dataGridView1.DataSource = data1;
            dataGridView1.DataSource = data1;
            cn1.Close();    
        }

        private void add_member_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Close();
        }
    }
}
