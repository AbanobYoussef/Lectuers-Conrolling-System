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
using System.IO.Ports;
using Microsoft.Office.Interop.Word;
namespace SS.PL
{
    public partial class Lecture : Form
    {
        bool open = false, system = true;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        BL.CONTROL PA = new BL.CONTROL();
        public string name, lecture, stage;
        PL.view re = new PL.view();
        OpenFileDialog ofd = new OpenFileDialog();
        PL.PRINT pr = new PL.PRINT();
        public Lecture()
        {
            InitializeComponent();
            timer2.Start();
            wordToolStripMenuItem.Enabled = false;
            closeToolStripMenuItem.Enabled = false;
            activateToolStripMenuItem.Enabled = false;
            axAcroPDF1.Visible = false;
        }
        private void endit()
        {
            timer2.Stop();
             Form1.fr.serialPort1.Write("2");
            MessageBox.Show("WE finshed our LECTURE\nplease save your file", "LECTURE ENDED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pr.Refresh();
            pr.dOORDataSetBindingSource.DataSource = PA.PRallINCLASSstu(); ;
            pr.ShowDialog();
            PA.CLEARCLASS();
            Form1.fr.serialPort1.Write("4");
            this.Close();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open = true;
            openToolStripMenuItem.Enabled = false;
            closeToolStripMenuItem.Enabled = true;
             Form1.fr.serialPort1.Write("2");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open = false;
            closeToolStripMenuItem.Enabled = false;
            openToolStripMenuItem.Enabled = true;
             Form1.fr.serialPort1.Write("3");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                timer1.Start();
        }

        private void activateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            system = true;
            activateToolStripMenuItem.Enabled = false;
            dactivateToolStripMenuItem.Enabled = true;
        }

        private void dactivateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            system = false;
            activateToolStripMenuItem.Enabled = true;
            dactivateToolStripMenuItem.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            dt = PA.verify_stu(textBox1.Text);
            if (system == true)
            {
                if (dt.Rows.Count > 0)
                {
                    if (stage == dt.Rows[0][2].ToString())
                    {
                        PA.insertstu(dt.Rows[0][1].ToString(), lecture, name, Convert.ToInt32(stage), textBox1.Text);
                        if(open==false)
                        {
                            Form1.fr.serialPort1.Write("1");
                        }
                    }
                    else
                        MessageBox.Show("not your stage");
                }
                else
                {
                    MessageBox.Show("no access now");
                }
            }
            textBox1.Text = "";
        }

        private void allStudentdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt = PA.allstu(Convert.ToInt32(stage));
            re.dataGridView1.DataSource = dt;
            re.del.Visible = false;
            re.ShowDialog();
        }

        private void inClassStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt = PA.allINCLASSstu();
            re.dataGridView1.DataSource = dt;
            re.del.Visible = true;
            re.ShowDialog();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
            toolStripTextBox1.Text = Convert.ToString(DateTime.Now.ToLongTimeString());
            dt2 = PA.endlec();
            if(dt2.Rows.Count>0)
            {
                
                endit();
            }
        }

        private void pdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.Visible = true;
            wordToolStripMenuItem.Enabled = true;
            displayToolStripMenuItem.Enabled = false;
            hideToolStripMenuItem.Enabled = true;
            ofd.Filter = "|*pdf";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                axAcroPDF1.src = ofd.FileName;
            }
        }

        

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            endit();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.Visible = false;
            displayToolStripMenuItem.Enabled =true;
            hideToolStripMenuItem.Enabled = false;
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.Visible = true;
            displayToolStripMenuItem.Enabled = false;
            hideToolStripMenuItem.Enabled = true;
        }

        

    }
}
