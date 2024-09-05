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
    public partial class MENUUPDATED : Form
    {
        public long balance;
        public string fname;
        public long ac;
        public MENUUPDATED(string fname,long balance ,long ac)
        {
            InitializeComponent();
            this.fname = fname;
            this.balance = balance;
            this.ac = ac;
        }

        private void MENUUPDATED_Load(object sender, EventArgs e)
        {
            lblname.Text=""+ fname;
            lblaccno.Text= ""+(long)balance;
        }

        private void btnwith_Click(object sender, EventArgs e)
        {
            Withdraw wd=new Withdraw(balance,ac);
            this.Hide();
            wd.Show();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Balance bl=new Balance(ac,balance,fname);
            bl.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            //Form1 fm = new Form1();
            Login_frm fm = new Login_frm();
            this.Hide();
            fm.Show();
        }
    }
}
