using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS.PL
{
    public partial class PM : Form
    {
        public string prostate;
        BL.CONTROL cn = new BL.CONTROL();
        public PM()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (prostate == "add")
            {
                cn.addprof(textBox1.Text,textBox2.Text);
                textBox1.Text = textBox2.Text = string.Empty;

            }
            else if (prostate == "update")
            {
                cn.updateprof(textBox1.Text, textBox2.Text);
                textBox1.Text = textBox2.Text = string.Empty;
            }
        }

    }
}
