using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N11310006_GUI_Class
{
    public partial class FormTextBox : Form
    {
        public FormTextBox()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("text box 被改變了");

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = tbInput.Text;
        }

        private void FormTextBox_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a=Int32.Parse(textBox1.Text);
            int b=Int32.Parse(textBox2.Text);
            int sum = a + b;
            label4.Text = sum.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox3.Text);
            int b = Int32.Parse(textBox4.Text);
            int sum = a - b;
            label11.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox7.Text);
            int b = Int32.Parse(textBox5.Text);
            int sum = a * b;
            label13.Text = sum.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox8.Text);
            int b = Int32.Parse(textBox6.Text);
            int sum = a / b;
            label12.Text = sum.ToString();
        }   
    }
}
