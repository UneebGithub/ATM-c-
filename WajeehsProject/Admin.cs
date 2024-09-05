using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace atmsystem
{
 

    public partial class Admin : Form
    {
        ATMDataContext db;

        public Admin()
        {
            InitializeComponent();
            db = new ATMDataContext(); 
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                int accountNumber;
                if (!int.TryParse(AC.Text, out accountNumber))
                {
                    MessageBox.Show("Invalid account number input.");
                    return;
                }

                long phoneNumber;
                if (!long.TryParse(Phone.Text, out phoneNumber))
                {
                    MessageBox.Show("Invalid phone number input.");
                    return;
                }

                var check = db.Check1s.FirstOrDefault(sd=>sd.AN==accountNumber && sd.Phone==phoneNumber);

               DialogResult dc= MessageBox.Show("Do you want to delete this data ? "," Delete Data",MessageBoxButtons.YesNoCancel);
                if(DialogResult.Yes == dc)
                {
                    db.Check1s.DeleteOnSubmit(check);
                    db.SubmitChanges();
                    MessageBox.Show("Message Deleted Successfully ");
                    DataGridView1.Refresh();
                }
                else if(DialogResult.No == dc)
                {
                    MessageBox.Show("Message Not Deleted  ");

                }

            }
            catch(Exception ex) { 
            
            }
            }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                int accountNumber;
                if (!int.TryParse(AC.Text, out accountNumber))
                {
                    MessageBox.Show("Invalid account number input.");
                    return;
                }

                long phoneNumber;
                if (!long.TryParse(Phone.Text, out phoneNumber))
                {
                    MessageBox.Show("Invalid phone number input.");
                    return;
                }

                var check = from c in db.Check1s
                            where c.AN == accountNumber || c.Phone == phoneNumber
                            select c;

                if (check.Any())
                {
                    DataGridView1.DataSource = null;
                    DataGridView1.DataSource = check.ToList();
                }
                else
                {
                    MessageBox.Show("No matching records found.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Input exceeds valid range: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnblock_Click(object sender, EventArgs e)
        {
            try
            {
                int accountNumber;
                if (!int.TryParse(AC.Text, out accountNumber))
                {
                    MessageBox.Show("Invalid account number input.");
                    return;
                }

                long phoneNumber;
                if (!long.TryParse(Phone.Text, out phoneNumber))
                {
                    MessageBox.Show("Invalid phone number input.");
                    return;
                }

                var check = from c in db.Check1s
                            where c.AN == accountNumber || c.Phone == phoneNumber
                            select c;

                var account = check.FirstOrDefault();

                if (account != null)
                {
                    account.Blocked = 1;
                    db.SubmitChanges();
                    MessageBox.Show($"Account {account.AN} blocked successfully.");
                }
                else
                {
                    MessageBox.Show("No matching account found.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Input exceeds valid range: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnunblock_Click(object sender, EventArgs e)
        {
            try
            {
                int accountNumber;
                if (!int.TryParse(AC.Text, out accountNumber))
                {
                    MessageBox.Show("Invalid account number input.");
                    return;
                }

                long phoneNumber;
                if (!long.TryParse(Phone.Text, out phoneNumber))
                {
                    MessageBox.Show("Invalid phone number input.");
                    return;
                }

                var check = from c in db.Check1s
                            where c.AN == accountNumber || c.Phone == phoneNumber
                            select c;

                var account = check.FirstOrDefault();

                if (account != null)
                {
                    account.Blocked = 0;
                    db.SubmitChanges();
                    MessageBox.Show($"Account {account.AN} unblocked successfully.");
                }
                else
                {
                    MessageBox.Show("No matching account found.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Input exceeds valid range: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                int accountNumber;
                if (!int.TryParse(txtAcctNo.Text, out accountNumber))
                {
                    MessageBox.Show("Invalid account number input.");
                    return;
                }

                
                var account = db.Check1s.FirstOrDefault(c => c.AN == accountNumber);

                if (account != null)
                {
                    
                    account.PinCode = Convert.ToInt32(txtPincode.Text);                     
                    account.Fname = txtfnme.Text;
                    account.Lname = txtlnme.Text;
                    account.Adr = txtaddr.Text;
                    account.Phone = Convert.ToInt64(txtcontact.Text);
                    account.Gender = cbGender.Text;
                    account.Balance = Convert.ToInt64(textBox1.Text); 

                    db.SubmitChanges();
                    MessageBox.Show($"Account {account.AN} updated successfully.");
                }
                else
                {
                    MessageBox.Show("No matching account found.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Input exceeds valid range: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }





        private void btnedit_Click(object sender, EventArgs e)
        {
            
        }


        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int accountNumber;
                if (!int.TryParse(AC.Text, out accountNumber))
                {
                    MessageBox.Show("Invalid account number input.");
                    return;
                }

                long phoneNumber;
                if (!long.TryParse(Phone.Text, out phoneNumber))
                {
                    MessageBox.Show("Invalid phone number input.");
                    return;
                }

                var account = db.Check1s.FirstOrDefault(c => c.AN == accountNumber || c.Phone == phoneNumber);

                if (account != null)
                {

                    txtAcctNo.Text = account.AN.ToString();
                    txtPincode.Text = account.PinCode.ToString();
                    txtfnme.Text=account.Fname.ToString();
                    txtlnme.Text = account.Lname.ToString();
                    txtaddr.Text=account.Adr.ToString();
                    txtcontact.Text=account.Phone.ToString();
                    cbGender.Text= account.Gender.ToString();
                    textBox1.Text=account.Balance.ToString();
                    

                    MessageBox.Show("Account details loaded for editing.");
                }
                else
                {
                    MessageBox.Show("No matching account found.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Input exceeds valid range: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ck = from i in db.Check1s select i;
            DataGridView1.DataSource = ck.ToList();
        }
    }
}
