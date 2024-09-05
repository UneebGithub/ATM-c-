
using System.Diagnostics;
using System;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Linq;



namespace atmsystem
{
	public partial class transreceipt
	{
        private long a;
        private long b;
        private int bl;
		public transreceipt(long ac,long balance ,int blc)
		{
			InitializeComponent();
            this.a = ac;
            this.b = balance;
            this.bl = blc;
		}

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void transreceipt_Load(object sender, EventArgs e)
        {
            label8.Text = " " + a;
            label9.Text = " " + b;
            label10.Text = " " + bl;
        }
    }
}
