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
    public partial class USERS : Form
    {
        public string state;
        PL.profmanage manage = new PL.profmanage();
        DataTable dt = new DataTable();
        BL.CONTROL con=new BL.CONTROL();

        public USERS()
        {
            InitializeComponent();
        }

        private void profeseursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manage.dataGridView1.DataSource= con.ALL_PROF();
            manage.Text = "PROFESSEURS";
            manage.ShowDialog();
        }

        private void lecteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manage.dataGridView1.DataSource = con.ALLLECTURE();
            manage.Text = "LECTURES";
            manage.ShowDialog();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manage.dataGridView1.DataSource = con.ALLLSTUDENTS();
            manage.Text = "STUDENTS";
            manage.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manage.dataGridView1.DataSource = con.ALLUSERS();
            manage.Text = "USERS";
            manage.ShowDialog();
        }

        private void endToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manage.dataGridView1.DataSource = con.STAGES();
            manage.Text = "STAGES";
            manage.ShowDialog();
        }

        

       
    }
}
