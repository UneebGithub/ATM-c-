using System;
using System.Linq;
using System.Windows.Forms;

namespace atmsystem
{
    public partial class Regs_frm : Form
    {
        private static Regs_frm defaultInstance;
        private ATMDataContext db;

        public Regs_frm()
        {
            InitializeComponent();
        }

        #region Default Instance
        public static Regs_frm Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new Regs_frm();
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtfname.Text) ||
                string.IsNullOrEmpty(txtlname.Text) ||
                string.IsNullOrEmpty(txtPincode.Text) ||
                string.IsNullOrEmpty(txtAcctNo.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            try
            {
                using (db = new ATMDataContext())
                {
                    var newUser = new Check1
                    {
                        Fname = txtfname.Text,
                        Lname = txtlname.Text,
                        PinCode = int.Parse(txtPincode.Text),
                        AN = long.Parse(txtAcctNo.Text),
                        Gender = "user", // Default to user, change as needed
                        Adr = txtaddr.Text,
                        Phone = long.Parse(txtcontact.Text),
                       // DOB = DateTime.Parse(cbmonth.Text), 
                        Balance = 0,
                        //OutBalance = 0
                    };

                    db.Check1s.InsertOnSubmit(newUser);
                    db.SubmitChanges();
                    MessageBox.Show("Registration successful!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // db1;

        private void Regs_frm_Load(object sender, EventArgs e)
        {
          //  db1=new aDataContext();
           // var charc=db1.uis.FirstOrDefault(d=>d.roll == 1);
            //if(charc != null)
            //{
              //  MessageBox.Show("hello");
            //}
            //else
            //{

              //  MessageBox.Show("not");
            //}
        }
    }
}
