using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class calculetor : Form
    {
        public calculetor()
        {
            InitializeComponent();
        }

        string total()
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double t = Math.Pow(a, 2);
            double z = b / t;

            string m = Convert.ToString(z);

            label4.Text = m;
            if (z < 1.9)
            {
                MessageBox.Show("underweight! you should improve your weight");
            }
            else if (z >= 1.9 && z < 2.7)
            { MessageBox.Show("Normal weight.You Can Continue your regular Food"); }
            else if (z >= 2.7)

            { MessageBox.Show("OH MY GOD!!!you should control"); }
            
            return m;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            total();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

              private void button0_Click_1(object sender, EventArgs e)
        {
            new Main().Show();
            this.Close();
        }

              private void calculetor_Load(object sender, EventArgs e)
              {

              }
    }
}
