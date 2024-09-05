using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atmsystem
{
    public partial class Balance : Form
    {
        private long ac, bl;
        private string fname;
        public Balance(long ac,long bl, string fname)
        {
            InitializeComponent();
            this.fname = fname;
            this.ac = ac;
            this.bl = bl;
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            lblname.Text= fname;
            label8.Text = " "+ac;
            label9.Text = " "+bl;
        }
    }
}
