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
    public partial class Form3pass : Form
    {
        int min=0, max=100;
        int answer;
        public Form3pass()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int input = Int32.Parse(textBox1.Text);
                if (input == this.answer)
                {
                    MessageBox.Show("恭喜答對!");1

                }
                else if (input< this.answer)
                {ring
                    this.min=input;
                }
                else if (input< this.answer)
                {
                    this.max=input;
                }
                label.Text =st
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.answer = r.Next(100);
            MessageBox.Show(answer.ToString());
            label1.Text =string.Format("提示:請輸入(0)~(1)正整數", min, max);
        }
    }
}
