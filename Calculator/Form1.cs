using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string num1str, num2str;
        float num1, num2;
        float result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            getNumbers();
            result = num1 + num2;

            lblResult.Text = result.ToString();

        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            getNumbers();
            result = num1 - num2;

            lblResult.Text = result.ToString();

        }



        private void btnMul_Click(object sender, EventArgs e)
        {
            getNumbers();
            result = num1 * num2;

            lblResult.Text = result.ToString();

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            getNumbers();
            result = (float) num1 / num2;

            lblResult.Text = result.ToString();

        }

        private void  getNumbers()
        {
            try
            {
                num1str = this.txtNum1.Text.ToString();
                num2str = this.txtNum2.Text.ToString();

                num1 = float.Parse(num1str);
                num2 = float.Parse(num2str);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
