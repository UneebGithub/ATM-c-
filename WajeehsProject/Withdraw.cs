using System;
using System.Linq;
using System.Windows.Forms;

namespace atmsystem
{
    public partial class Withdraw : Form
    {

        private ATMDataContext db;
        //private string accountNumber;
        private long balance;
        private long ac;
        public Withdraw(long balance,long ac)
        {
            InitializeComponent();
            this.balance = balance;
            this.ac = ac;
        }
        

       
     
        //public static object Default { get; internal set; }

        public void Withdraw_Load(object sender, EventArgs e)
        {
           
             lblaccno.Text=" "+ac;        
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            db = new ATMDataContext();
            try
            {
                int amount;
                if (!int.TryParse(txtamount.Text, out amount))
                {
                    MessageBox.Show("Please enter a valid amount.");
                    return;
                }

                var accountRecord = db.Check1s.FirstOrDefault(atm => atm.AN == ac);
                if (accountRecord != null)
                {
                    if (amount > 25000)
                    {
                        MessageBox.Show("Your balance is greater than 25,000.");
                    }
                    else if (accountRecord.Balance.HasValue && accountRecord.Balance >= amount)
                    {
                        long newBalance = accountRecord.Balance.Value - amount;
                        accountRecord.Balance = newBalance;

                        db.SubmitChanges();

                        transreceipt receipt = new transreceipt(ac, newBalance, amount);
                        this.Hide();
                        receipt.Show();
                    }
                    else
                    {
                        MessageBox.Show("Insufficient balance or balance is not available.");
                    }
                }
                else
                {
                    MessageBox.Show("Account not found.");
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Check1 ck=new Check1();
           // MENUUPDATED up = new MENUUPDATED(ck.Fname,balance,ac);
            this.Hide();
           // up.Show();
        }
    }
}
