using System;
using System.Linq;
using System.Windows.Forms;

namespace atmsystem
{
    public partial class Login_frm : Form
    {
        private static Login_frm defaultInstance;
        private ATMDataContext db;
        public string tb;

        public Login_frm()
        {
            InitializeComponent();
            textBox1.Visible = false;
            button1.Visible = false;
            btnlogin.Visible = true;
        }

        #region Default Instance
        public static Login_frm Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new Login_frm();
                    defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
                }
                return defaultInstance;
            }
        }

        static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            defaultInstance = null;
        }
        #endregion

        private void btnlogin_Click(object sender, EventArgs e)
        {
            db=new ATMDataContext();
            //private void btnlogin_Click(object sender, EventArgs e)
            // {
            if (string.IsNullOrEmpty(txtpin.Text) && string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter the PIN.");
                return;
            }

            try
            {
                using (db = new ATMDataContext())
                {
                    var user = db.Check1s.FirstOrDefault(u => u.AN == int.Parse(txtpin.Text));
                    
                        if (user != null)
                        {
                        
                            string fullName = user.Fname;
                            long accountNo = (long)user.AN;
                            long balance = (long)user.Balance;
                            string type = user.Gender;
                            int isBlocked = (int)user.Blocked;

                            if (isBlocked == 1)
                            {
                                MessageBox.Show("Your account is currently blocked. Contact the Administrator for help.");
                            }

                            else if (tb == "a")
                            {
                                MessageBox.Show($"Welcome {fullName}, you logged in as Administrator.");
                                
                            }
                            else
                            {
                          
                             
                            MENUUPDATED mu = new MENUUPDATED(fullName,balance,accountNo);
                            this.Hide();
                            mu.ShowDialog   ();
                            }
                        }
                        else
                        {
                            MessageBox.Show("You are not registered! Please register if you are new.");
                        }
                    }
                
                }
                catch (FormatException)
            {
                MessageBox.Show("Invalid PIN format. Please enter digits only.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                txtpin.Text = string.Empty;
            }
        }
    

       // }

        private void llblreg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Regs_frm.Default.Show();
        }

        private void Login_frm_Load(object sender, EventArgs e)
        {
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            button1.Visible = true;
            btnlogin.Visible = false;
            textBox1.Visible = true;
            txtpin.Visible = false;
            tb=textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Admin a=new Admin();
            a.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_frm f = new Login_frm();
            f.Show();

        }
    }
}
