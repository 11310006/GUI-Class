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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new FormButtun();
            form.Show();
        }

        private void btnTextBox_Click(object sender, EventArgs e)
        {
            Form form = new FormTextBox();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form form = new 期中考_攝氏轉華氏();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formt3Timer = new Formt3timer();
            formt3Timer.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form form = new Form3pass();
            form.Show(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new FormCheckBox();
            form.Show();
        }
    }
}
