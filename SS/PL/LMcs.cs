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
    public partial class LMcs : Form
    {
        public string lmstate;
        BL.CONTROL cn = new BL.CONTROL();
        public LMcs()
        {
            InitializeComponent();
            comboBox1.DataSource = cn.ALL_PROF();
            comboBox1.DisplayMember = "PROF_NAME";
            comboBox1.ValueMember = "RPOF_ID";
            comboBox2.DataSource = cn.STAGES();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "ID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lmstate == "add")
            {
                cn.addlec(textBox1.Text, comboBox4.Text, comboBox1.SelectedValue.ToString(), Convert.ToInt32(comboBox2.SelectedValue), comboBox3.Text);
                textBox1.Text =  string.Empty;
            }
            else if(lmstate == "update")
            {
                cn.updatelec(textBox1.Text, comboBox4.Text, comboBox1.SelectedValue.ToString(), Convert.ToInt32(comboBox2.SelectedValue), comboBox3.Text);
                textBox1.Text = string.Empty;
            }
        }

       

        
    }
}
