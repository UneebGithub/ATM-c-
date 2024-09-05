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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Login_frm : System.Windows.Forms.Form
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
            this.llblreg = new System.Windows.Forms.LinkLabel();
            this.txtpin = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // llblreg
            // 
            this.llblreg.AutoSize = true;
            this.llblreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblreg.Location = new System.Drawing.Point(424, 170);
            this.llblreg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblreg.Name = "llblreg";
            this.llblreg.Size = new System.Drawing.Size(69, 17);
            this.llblreg.TabIndex = 4;
            this.llblreg.TabStop = true;
            this.llblreg.Text = "Register";
            this.llblreg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblreg_LinkClicked);
            // 
            // txtpin
            // 
            this.txtpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpin.Location = new System.Drawing.Point(192, 53);
            this.txtpin.Margin = new System.Windows.Forms.Padding(4);
            this.txtpin.Name = "txtpin";
            this.txtpin.PasswordChar = '*';
            this.txtpin.Size = new System.Drawing.Size(268, 34);
            this.txtpin.TabIndex = 6;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.White;
            this.GroupBox1.Controls.Add(this.linkLabel2);
            this.GroupBox1.Controls.Add(this.button1);
            this.GroupBox1.Controls.Add(this.textBox1);
            this.GroupBox1.Controls.Add(this.linkLabel1);
            this.GroupBox1.Controls.Add(this.txtpin);
            this.GroupBox1.Controls.Add(this.llblreg);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.btnlogin);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(16, 15);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(504, 190);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Login";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(128, 108);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(201, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(242, 30);
            this.textBox1.TabIndex = 8;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(8, 170);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 17);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Admin";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(52, 57);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(125, 29);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Pin Code :";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnlogin.Location = new System.Drawing.Point(272, 108);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(136, 41);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(238, 170);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(48, 17);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "LogIn";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Login_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(536, 230);
            this.Controls.Add(this.GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Login_frm_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.LinkLabel llblreg;
		internal System.Windows.Forms.TextBox txtpin;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button btnlogin;
        private TextBox textBox1;
        internal LinkLabel linkLabel1;
        internal Button button1;
        internal LinkLabel linkLabel2;
    }
	
}
