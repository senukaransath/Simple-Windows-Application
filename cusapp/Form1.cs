using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cusapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

        private void button1_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void label3_ForeColorChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txt_uname.Text;
            string upass = txt_pass.Text;

            if (username == "admin" && upass == "123")
            {
                MessageBox.Show("Login Success!");
                cusManage mm = new cusManage();
                mm.Show();
                this.Hide();

            }else
            {
                MessageBox.Show("Sorry! wrong username or password.");
            }

        }
    }
}
