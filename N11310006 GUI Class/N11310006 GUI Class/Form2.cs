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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /*double input = Double.Parse(textBoxl.Text);
                double sum = input + 100;
                buttonl.Text = sum.ToString();*/
                throw new IndexOutOfRangeException();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("輸入的格式有問題");
            }
            catch (Exception)
            {
                MessageBox.Show("發生問題了,甚麼問題不知道");
            }
            finally
            {
                MessageBox.Show("執行到最後");
            }




        }
    }
}
