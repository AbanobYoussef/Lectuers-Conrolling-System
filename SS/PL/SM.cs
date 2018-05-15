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
    public partial class SM : Form
    {
        public string samstate;
        BL.CONTROL cn = new BL.CONTROL();
        public SM()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (samstate == "add")
            {
                cn.addSTAGE(textBox1.Text, Convert.ToInt32(textBox2.Text));
                textBox1.Text = textBox2.Text = string.Empty;
            }
            else if (samstate == "update")
            {
                cn.updateSTAGE(textBox1.Text, Convert.ToInt32(textBox2.Text));
                textBox1.Text = textBox2.Text = string.Empty;
            }
        }
    }
}
