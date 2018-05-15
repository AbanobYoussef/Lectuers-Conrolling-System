using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS
{
    public partial class Form1 : Form
    {
        public static Form1 fr;

        public Form1()
        {
            InitializeComponent();
            fr = this;
            try
            {
                serialPort1.Open();
                PL.Main.MA.ShowDialog();
            }
            catch
            {
                PL.Main.MA.ShowDialog();
                return;
            }
            
        }

    }
}
