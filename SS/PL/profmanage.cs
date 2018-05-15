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
    public partial class profmanage : Form
    {
        BL.CONTROL cn = new BL.CONTROL();
        PL.PM pr = new PL.PM();
        PL.SMcs sm = new PL.SMcs();
        PL.UM um = new PL.UM();
        PL.SM sam = new PL.SM();
        PL.LMcs lm = new PL.LMcs();
        public profmanage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.Text=="PROFESSEURS")
            {
                pr.textBox1.Text =  pr.textBox2.Text =string.Empty;
                pr.Text = "ADDTOIN";
                pr.button1.Text = "add";
                pr.prostate = "add";
                pr.textBox2.Enabled = true;
                pr.ShowDialog();
                dataGridView1.DataSource = cn.ALL_PROF();
            }
            else if(this.Text=="STUDENTS")
            {
                sm.textBox1.Text = sm.textBox2.Text = sm.comboBox1.Text = string.Empty;
                sm.Text = "ADDTION";
                sm.button1.Text = "add";
                sm.smstate = "add";
                sm.textBox2.Enabled = true;
                sm.ShowDialog();
                dataGridView1.DataSource = cn.ALLLSTUDENTS();
            }
            else if (this.Text == "USERS")
            {
                um.textBox1.Text = um.textBox2.Text = um.comboBox1.Text = string.Empty;
                um.Text = "ADDTION";
                um.button1.Text = "add";
                um.umstate = "add";
                um.textBox2.Enabled = true;
                um.ShowDialog();
                dataGridView1.DataSource = cn.ALLUSERS();
               
            }
            else if (this.Text == "STAGES")
            {
                sam.textBox1.Text = sam.textBox2.Text  = string.Empty;
                sam.Text = "ADDTION";
                sam.button1.Text = "add";
                sam.samstate = "add";
                sam.textBox2.Enabled = true;
                sam.ShowDialog();
                dataGridView1.DataSource = cn.STAGES();
            }
            else if (this.Text == "LECTURES")
            {
                lm.textBox1.Text   = string.Empty;
                lm.textBox2.Text = lm.textBox3.Text = "00:00:00";
                lm.Text = "ADDTION";
                lm.button1.Text = "add";
                lm.lmstate = "add";
                lm.textBox1.Enabled = lm.textBox2.Enabled = lm.textBox3.Enabled = true;
                lm.ShowDialog();
                dataGridView1.DataSource = cn.ALLLECTURE();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Text == "PROFESSEURS")
            {
                pr.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                pr.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                pr.Text = "UPDATE";
                pr.button1.Text = "update";
                pr.prostate = "update";
                pr.textBox2.Enabled = false;
                pr.ShowDialog();
                dataGridView1.DataSource = cn.ALL_PROF();
            }
            else if (this.Text == "STUDENTS")
            {
                sm.textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                sm.textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sm.comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                sm.Text = "UPDATE";
                sm.button1.Text = "update";
                sm.smstate = "update";
                sm.textBox2.Enabled = false;
                sm.ShowDialog();
                dataGridView1.DataSource = cn.ALLLSTUDENTS();
            }
            else if (this.Text == "USERS")
            {
                um.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                um.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                um.comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                um.Text = "UPDATE";
                um.button1.Text = "uptade";
                um.umstate = "update";
                um.textBox2.Enabled = false;
                um.ShowDialog();
                dataGridView1.DataSource = cn.ALLUSERS();
            }
            else if (this.Text == "STAGES")
            {
                sam.textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sam.textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                sam.Text = "UPDATE";
                sam.button1.Text = "uptade";
                sam.samstate = "update";
                sam.textBox2.Enabled = false;
                sam.ShowDialog();
                dataGridView1.DataSource = cn.STAGES();
            }
            else if (this.Text == "LECTURES")
            {
                lm.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                lm.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                lm.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                lm.comboBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                lm.comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                lm.comboBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                lm.comboBox3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                lm.Text = "UPDATE";
                lm.button1.Text = "update";
                lm.lmstate = "update";
                lm.textBox1.Enabled = lm.textBox2.Enabled =lm.textBox3.Enabled= false;
                lm.ShowDialog();
                dataGridView1.DataSource = cn.ALLLECTURE();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.Text == "PROFESSEURS")
            {
                cn.DELPROF(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                dataGridView1.DataSource = cn.ALL_PROF();
            }
            else if (this.Text == "STUDENTS")
            {
                cn.delstu(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                dataGridView1.DataSource = cn.ALLLSTUDENTS();
            }
            else if (this.Text == "USERS")
            {
                cn.deluser(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                dataGridView1.DataSource = cn.ALLUSERS();
            }
            else if (this.Text == "STAGES")
            {
                cn.delSTAGE(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                dataGridView1.DataSource = cn.STAGES();
            }
            else if (this.Text == "LECTURES")
            {
                cn.deldatelec(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                dataGridView1.DataSource = cn.ALLLECTURE();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.Text == "PROFESSEURS")
            {
                dataGridView1.DataSource = cn.search_PROF(textBox1.Text);
            }
            else if (this.Text == "STUDENTS")
            {
                dataGridView1.DataSource = cn.search_stu(textBox1.Text);
            }
            else if (this.Text == "USERS")
            {
                dataGridView1.DataSource = cn.search_USERS(textBox1.Text);
            }
            else if (this.Text == "STAGES")
            {
                dataGridView1.DataSource = cn.search_STAGE(textBox1.Text);
            }
            else if (this.Text == "LECTURES")
            {
                dataGridView1.DataSource = cn.SERAECH_LECTURE(textBox1.Text);
            }
        }

    }
}
