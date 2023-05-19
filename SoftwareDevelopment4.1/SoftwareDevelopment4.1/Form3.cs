using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDevelopment4._1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox5.Text = "dd/mm/yyyy";
            textBox5.ForeColor = SystemColors.GrayText;

            textBox1.Text = "123456";
            textBox1.ForeColor = SystemColors.GrayText;

            textBox6.Text = "123456";
            textBox6.ForeColor = SystemColors.GrayText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUpSuccessfulyDone signUpSuccessfulyDone = new SignUpSuccessfulyDone();

            signUpSuccessfulyDone.Show();

            this.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
