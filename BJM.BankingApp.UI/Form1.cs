using BJM.BankingApp.BL;

namespace BJM.BankingApp.UI
{
    public partial class Form1 : Form
    {
        private CustomerCollection customer = new CustomerCollection();
        public Form1()
        {
            InitializeComponent();
            customer.PopulateTests();
            //customer.Sort();
            if (customer.Count > 0)
            {
                Rebindustomers();
            }
            

        }

        private void Rebindustomers()
        {
            lbxCustomers.DataSource = null;
            lbxCustomers.DataSource = customer;
        }

        private void lbxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer? selectedCustomer = lbxCustomers.SelectedItem as Customer;
            if (selectedCustomer != null) 
            {
                lblID.Text = selectedCustomer.CustomerID.ToString();
                txtfName.Text = selectedCustomer.FirstName;
                txtlName.Text = selectedCustomer.LastName;
                txtSSN.Text = selectedCustomer.SSN;
                txtBDate.Text = selectedCustomer.BirthDate.ToString("MM/dd/yyyy");
                lblAge.Text = selectedCustomer.Age.ToString();
                dgvDeposits.DataSource = selectedCustomer.DepositList;
                dgvWithdrawals.DataSource = selectedCustomer.WithdrawalList;
            }
            

        }
    }
}