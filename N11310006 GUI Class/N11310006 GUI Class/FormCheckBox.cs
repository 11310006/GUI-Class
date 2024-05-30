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
    public partial class FormCheckBox : Form
    {
        public FormCheckBox()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                MessageBox.Show("方塊已被按下");
            else
                MessageBox.Show("方塊已被取消");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach(Control c in panel1.Controls)
            {
                if(c is CheckBox)
                {
                    CheckBox chk= (CheckBox)c;
                    if(chk.Checked)
                    {
                        MessageBox.Show(chk.Text);
                    }
                }
            }


            foreach (Control c in panel2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    if (chk.Checked)
                    {
                        MessageBox.Show(chk.Text);
                    }
                }
            }

        }
    }
}
