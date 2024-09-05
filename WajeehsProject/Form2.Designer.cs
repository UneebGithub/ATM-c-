// VBConversions Note: VB project level imports
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
// End of VB project level imports


namespace atmsystem
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Regs_frm : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPincode = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblAccNo = new System.Windows.Forms.Label();
            this.txtAcctNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbyear = new System.Windows.Forms.ComboBox();
            this.cbmonth = new System.Windows.Forms.ComboBox();
            this.cbday = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtaddr = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbldate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtPincode);
            this.groupBox1.Controls.Add(this.Label6);
            this.groupBox1.Controls.Add(this.lblAccNo);
            this.groupBox1.Controls.Add(this.txtAcctNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(660, 140);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AccountInfo";
            // 
            // txtPincode
            // 
            this.txtPincode.Location = new System.Drawing.Point(239, 80);
            this.txtPincode.Margin = new System.Windows.Forms.Padding(4);
            this.txtPincode.Name = "txtPincode";
            this.txtPincode.Size = new System.Drawing.Size(396, 22);
            this.txtPincode.TabIndex = 6;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(27, 78);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(108, 25);
            this.Label6.TabIndex = 5;
            this.Label6.Text = "Pin Code:";
            // 
            // lblAccNo
            // 
            this.lblAccNo.AutoSize = true;
            this.lblAccNo.Location = new System.Drawing.Point(235, 162);
            this.lblAccNo.Name = "lblAccNo";
            this.lblAccNo.Size = new System.Drawing.Size(0, 16);
            this.lblAccNo.TabIndex = 4;
            // 
            // txtAcctNo
            // 
            this.txtAcctNo.Location = new System.Drawing.Point(239, 32);
            this.txtAcctNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAcctNo.Name = "txtAcctNo";
            this.txtAcctNo.Size = new System.Drawing.Size(396, 22);
            this.txtAcctNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Number:";
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(187, 41);
            this.txtfname.Margin = new System.Windows.Forms.Padding(4);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(448, 22);
            this.txtfname.TabIndex = 3;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(187, 87);
            this.txtlname.Margin = new System.Windows.Forms.Padding(4);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(448, 22);
            this.txtlname.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address:";
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Silver;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(331, 297);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(123, 44);
            this.Button1.TabIndex = 8;
            this.Button1.Text = "Cancel";
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.Button1);
            this.groupBox2.Controls.Add(this.cbyear);
            this.groupBox2.Controls.Add(this.cbmonth);
            this.groupBox2.Controls.Add(this.cbday);
            this.groupBox2.Controls.Add(this.btnRegister);
            this.groupBox2.Controls.Add(this.Label8);
            this.groupBox2.Controls.Add(this.cbGender);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Controls.Add(this.txtaddr);
            this.groupBox2.Controls.Add(this.Label7);
            this.groupBox2.Controls.Add(this.txtcontact);
            this.groupBox2.Controls.Add(this.txtlname);
            this.groupBox2.Controls.Add(this.txtfname);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.menuStrip1);
            this.groupBox2.Location = new System.Drawing.Point(16, 177);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(660, 366);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PersonalInfo";
            // 
            // cbyear
            // 
            this.cbyear.FormattingEnabled = true;
            this.cbyear.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014"});
            this.cbyear.Location = new System.Drawing.Point(549, 224);
            this.cbyear.Margin = new System.Windows.Forms.Padding(4);
            this.cbyear.Name = "cbyear";
            this.cbyear.Size = new System.Drawing.Size(68, 24);
            this.cbyear.TabIndex = 17;
            // 
            // cbmonth
            // 
            this.cbmonth.FormattingEnabled = true;
            this.cbmonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cbmonth.Location = new System.Drawing.Point(407, 224);
            this.cbmonth.Margin = new System.Windows.Forms.Padding(4);
            this.cbmonth.Name = "cbmonth";
            this.cbmonth.Size = new System.Drawing.Size(68, 24);
            this.cbmonth.TabIndex = 16;
            // 
            // cbday
            // 
            this.cbday.FormattingEnabled = true;
            this.cbday.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbday.Location = new System.Drawing.Point(484, 224);
            this.cbday.Margin = new System.Windows.Forms.Padding(4);
            this.cbday.Name = "cbday";
            this.cbday.Size = new System.Drawing.Size(56, 24);
            this.cbday.TabIndex = 15;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Silver;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(200, 297);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(123, 44);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(319, 223);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(76, 25);
            this.Label8.TabIndex = 14;
            this.Label8.Text = "B-day:";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(187, 223);
            this.cbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(123, 24);
            this.cbGender.TabIndex = 13;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(35, 224);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(90, 25);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Gender:";
            // 
            // txtaddr
            // 
            this.txtaddr.Location = new System.Drawing.Point(187, 134);
            this.txtaddr.Margin = new System.Windows.Forms.Padding(4);
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(448, 22);
            this.txtaddr.TabIndex = 11;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(27, 180);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(127, 25);
            this.Label7.TabIndex = 10;
            this.Label7.Text = "Contact No:";
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(187, 180);
            this.txtcontact.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(448, 22);
            this.txtcontact.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(4, 19);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbldate.Location = new System.Drawing.Point(443, 554);
            this.lbldate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(43, 18);
            this.lbldate.TabIndex = 6;
            this.lbldate.Text = "Date";
            // 
            // Regs_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(703, 583);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Regs_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.Regs_frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtPincode;
		private System.Windows.Forms.Label Label6;
		private System.Windows.Forms.Label lblAccNo;
		private System.Windows.Forms.TextBox txtAcctNo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtfname;
		private System.Windows.Forms.TextBox txtlname;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button Button1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtaddr;
		private System.Windows.Forms.Label Label7;
		private System.Windows.Forms.TextBox txtcontact;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnRegister;
		internal System.Windows.Forms.ComboBox cbGender;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.ComboBox cbday;
		internal System.Windows.Forms.ComboBox cbmonth;
		internal System.Windows.Forms.ComboBox cbyear;
		internal System.Windows.Forms.Label lbldate;
        private MenuStrip menuStrip1;
    }
	
}
