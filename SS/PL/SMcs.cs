using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SS.PL
{
    public partial class SMcs : Form
    {
         public string smstate;
        BL.CONTROL cn = new BL.CONTROL();
        public SMcs()
        {
            InitializeComponent();
            comboBox1.DataSource = cn.STAGES();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(smstate=="add")
            {
                cn.addstu(textBox1.Text,textBox2.Text,Convert.ToInt32(comboBox1.SelectedValue));
                textBox1.Text = textBox2.Text = string.Empty;
            }
            else if(smstate=="update")
            {
                cn.UPDATEstu(textBox1.Text, textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue));
                textBox1.Text = textBox2.Text =comboBox1.Text= string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
