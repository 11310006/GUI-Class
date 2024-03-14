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
    public partial class FormButtun : Form
    {
        public FormButtun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "請按我一下")
                button1.Text = "我已經被按過了";

            else if (button1.Text == "我已經被按過了")
                button1.Text = "請按我一下";
        }
    }
}
