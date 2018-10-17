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
    public partial class Purchase_product : Form
    {
        public Purchase_product()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

      
        private void button0_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Close();
         }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\gym project\login\login\gym.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
            SqlCommand cmd1 = new SqlCommand("DELETE FROM pur where id='" + textBox1.Text + "'", cn1);


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
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\gym project\login\login\gym.mdf;Integrated Security=True";
            SqlConnection cn1 = new SqlConnection(cns);

            cn1.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select * from pur", cn1);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            // dataGridView1.DataSource = data1;
            dataGridView1.DataSource = data1;
            cn1.Close();    
        }

        private void mango_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox3.Text);

            int b = Convert.ToInt32(textBox4.Text);

            int c = a * b;
            textBox5.Text = Convert.ToString(c);
            textBox5.Show();
            
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\gym project\login\login\gym.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();

            // SqlCommand cmd1 = new SqlCommand("INSERT INTO purchase (Product_id, Product_name,Quantity,Rate,Total_Amount,Date,Description) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "',  '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "','" + dateTimePicker1.Text +"', '" + textBox6.Text + "')", cn1);

            SqlCommand cmd1 = new SqlCommand("INSERT INTO pur (id,name,quantity,rate,amount,date,descrip) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "',  '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "','" + dateTimePicker1.Text + "', '" + textBox6.Text + "')", cn1);


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
           
            textBox3.Text = " ";
           
            textBox4.Text = " ";
           
            textBox5.Text = " ";
            textBox6.Text = " ";
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\gym project\login\login\gym.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();

            // SqlCommand cmd1 = new SqlCommand("INSERT INTO purchase (Product_id, Product_name,Quantity,Rate,Total_Amount,Date,Description) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "',  '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "','" + dateTimePicker1.Text +"', '" + textBox6.Text + "')", cn1);

            SqlCommand cmd1 = new SqlCommand("update  pur  set name='"+textBox2.Text+"' where id='"+textBox1.Text+"'", cn1);


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
    }
}

