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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Withdraw : System.Windows.Forms.Form
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
            this.lblaccno = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblaccno
            // 
            this.lblaccno.AutoSize = true;
            this.lblaccno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaccno.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblaccno.Location = new System.Drawing.Point(4, 9);
            this.lblaccno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblaccno.Name = "lblaccno";
            this.lblaccno.Size = new System.Drawing.Size(71, 24);
            this.lblaccno.TabIndex = 17;
            this.lblaccno.Text = "Ac no:";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbldate.Location = new System.Drawing.Point(426, 9);
            this.lbldate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(48, 18);
            this.lbldate.TabIndex = 16;
            this.lbldate.Text = "Date:";
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.Silver;
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Location = new System.Drawing.Point(216, 159);
            this.btnok.Margin = new System.Windows.Forms.Padding(4);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(117, 58);
            this.btnok.TabIndex = 13;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(127, 79);
            this.txtamount.Margin = new System.Windows.Forms.Padding(4);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(356, 30);
            this.txtamount.TabIndex = 18;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(15, 82);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(93, 25);
            this.Label3.TabIndex = 19;
            this.Label3.Text = "Amount:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label4.Location = new System.Drawing.Point(123, 114);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(330, 18);
            this.Label4.TabIndex = 20;
            this.Label4.Text = "Maximum Withdraw amount is  25,000 only";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 238);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.lblaccno);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.btnok);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Label lblaccno;
		internal System.Windows.Forms.Label lbldate;
		internal System.Windows.Forms.Button btnok;
		internal System.Windows.Forms.TextBox txtamount;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
	}
	
}
