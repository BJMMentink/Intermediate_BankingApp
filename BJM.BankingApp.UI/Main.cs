using BJM.BankingApp.BL;
using BJM.BankingApp.PL;

namespace BJM.BankingApp.UI
{
    public partial class Main : Form
    {
        private CustomerCollection customers = new CustomerCollection();
        public Main()
        {
            InitializeComponent();
            customers.LoadFromDB();
            Rebindustomers();
            //customers.PopulateTests();
            //customer.Sort();
        }
        private void Rebindustomers()
        {
            lbxCustomers.DataSource = null; // unbinds Customer
            lbxCustomers.DataSource = customers; // Rebinds Customer
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
                selectedCustomer.LoadTransactionsFromDB();
                RebindTransactions(selectedCustomer.DepositList, selectedCustomer.WithdrawalList);
            }
        }
        private void RebindTransactions(List<Deposit> Deposit, List<Withdrawal> Withdrawal)
        {
            dgvDeposits.DataSource = null;
            dgvDeposits.DataSource = Deposit;
            dgvWithdrawals.DataSource = null;
            dgvWithdrawals.DataSource = Withdrawal;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            lblID.Text = string.Empty; // Clears text
            txtfName.Text = string.Empty;
            txtlName.Text = string.Empty;  
            txtSSN.Text = string.Empty;
            txtBDate.Text = string.Empty;
            lblAge.Text = string.Empty;
            lbxCustomers.SelectedIndex = -1;
            dgvDeposits.DataSource = null;
            dgvWithdrawals.DataSource = null;
            lblID.Text = customers.GetNextID().ToString();
            //lbxCustomers.SelectionMode = SelectionMode.None;
            //lbxCustomers.SelectionMode = SelectionMode.One;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime DT;
            Customer customer = new Customer();
            Customer? selectedCustomer = lbxCustomers.SelectedItem as Customer;
            if (selectedCustomer != null) // if there is a customer selected (updating current customer)
            {
                if (DateTime.TryParse(txtBDate.Text, out DT)) // if bdate is in the correct format
                {
                    selectedCustomer.FirstName = txtfName.Text;
                    selectedCustomer.LastName = txtlName.Text;
                    selectedCustomer.SSN = txtSSN.Text;
                    selectedCustomer.BirthDate =  DT;
                    Rebindustomers();
                    
                }
                else { MessageBox.Show("Birthdate is in incorrect format, please use MM/dd/yyyy", "ERROR"); } 
            }
            else // (creating a new customer)
            {if (txtfName.Text != string.Empty) // checks if fname is empty
                {if (txtlName.Text != string.Empty) // checks if lname is empty
                    {if (txtSSN.Text != string.Empty) // checks if SSN is empty
                        {if (DateTime.TryParse(txtBDate.Text, out DT)) // checks if bdate is in the correct format
                            {
                                customer.BirthDate = DT;
                                customer.FirstName = txtfName.Text;
                                customer.LastName = txtlName.Text;
                                customer.SSN = txtSSN.Text;
                                customers.Add(customer);
                                Rebindustomers();
                            }
                            else { MessageBox.Show("Birthdate is in incorrect format, please use MM/dd/yyyy", "ERROR"); }
                        }else { MessageBox.Show("Please Enter your SSN", "ERROR"); }
                    }else { MessageBox.Show("Please Enter your Last Name", "ERROR"); }
                }else { MessageBox.Show("Please Enter your First Name", "ERROR"); }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Customer? selectedCustomer = lbxCustomers.SelectedItem as Customer;
            DialogResult dialogResult = MessageBox.Show("Would you like to Delete?", "Confirm Delete", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                if (selectedCustomer != null)
                {
                    customers.Remove(selectedCustomer);
                    Rebindustomers();
                    lblID.Text = string.Empty; // see add btn 
                    txtfName.Text = string.Empty;
                    txtlName.Text = string.Empty;
                    txtSSN.Text = string.Empty;
                    txtBDate.Text = string.Empty;
                    lblAge.Text = string.Empty;
                    lbxCustomers.SelectedIndex = -1;
                    dgvDeposits.DataSource = null;
                    dgvWithdrawals.DataSource = null;
                }
            }
        }

        private void btnSaveXML_Click(object sender, EventArgs e)
        {
            customers.SaveToXml(); // calls save to xml
        }

        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            Type type = typeof(CustomerCollection);

            try
            {
                CustomerCollection? temp = DataAccess.LoadXml(type) as CustomerCollection;
                customers = (temp != null) ? temp : new CustomerCollection();
            }
            catch
            {
                customers = new CustomerCollection();
            }
            if (customers.Count > 0)
            {
                Rebindustomers();
            }

        }
    }
}