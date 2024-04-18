using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace N11310006_GUI_Class
{
    public partial class 期中考_攝氏轉華氏 : Form
    {
        public 期中考_攝氏轉華氏()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Int32.Parse(textBox1.Text);
            double sum = a * 9/5+32;
            label3.Text = sum.ToString();
        }
    }
}
