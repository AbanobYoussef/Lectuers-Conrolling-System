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
    public partial class Main : Form
    {
        DataTable dt = new DataTable();
        BL.CONTROL PA = new BL.CONTROL();
        public static Main MA = new Main();
        public Main()
        {
            InitializeComponent();
            MA=this;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Stop();

            dt = PA.prof_login(textBox1.Text);
            if (dt.Rows.Count > 0)
            {

                PL.Lecture frm = new PL.Lecture();
                frm.name = dt.Rows[0][4].ToString();
                frm.stage = dt.Rows[0][5].ToString();
                frm.lecture = dt.Rows[0][0].ToString();
                Form1.fr.serialPort1.Write("1");
                frm.ShowDialog();
                
            }
            else
            {
                dt = PA.loginuser(textBox1.Text);
                if (dt.Rows.Count > 0)
                {
                    PL.USERS user = new PL.USERS();
                    user.state = dt.Rows[0][2].ToString();
                    if (user.state == "Manager")
                        user.usersToolStripMenuItem.Enabled = true;
                    else
                        user.usersToolStripMenuItem.Enabled = false;
                    user.ShowDialog();
                }
                else
                {
                    MessageBox.Show("not allowed", "^_^", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

            textBox1.Text = "";
        }
    }
}
