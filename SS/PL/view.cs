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
    public partial class view : Form
    {
        PL.PRINT pr = new PL.PRINT();
        PL.PRINT2 pr2 = new PL.PRINT2();
        BL.CONTROL PA = new BL.CONTROL();
        DataTable dt = new DataTable();
        public view()
        {
            InitializeComponent();
        }

        private void del_Click(object sender, EventArgs e)
        {
            int x = dataGridView1.RowCount;
            string i = dataGridView1.Rows[x - 2].Cells[1].Value.ToString();
            PA.deletestu(i);
            DataTable dt = PA.allINCLASSstu();
            dataGridView1.DataSource = dt;
        }

        private void PrinT_Click(object sender, EventArgs e)
        {
            dt = PA.PRallINCLASSstu();

            if (!del.Visible)
            {
                pr2.Refresh();
                pr2.dOORDataSet1BindingSource.DataSource = PA.allstu(dt.Rows[0][1].ToString());
                    pr2.ShowDialog();
            }
            else
            {
                pr.Refresh();
                pr.dOORDataSetBindingSource.DataSource =dt;
                pr.ShowDialog();
            }
           
        }
    }
}
