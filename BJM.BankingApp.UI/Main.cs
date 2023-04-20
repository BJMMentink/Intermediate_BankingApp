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
                lblID.Text = selectedCustomer.CustomerID.ToString(); // Sets saved ID
                txtfName.Text = selectedCustomer.FirstName; // sets saved Fname
                txtlName.Text = selectedCustomer.LastName; // sets saved Lname
                txtSSN.Text = selectedCustomer.SSN; // sets saved SSN
                txtBDate.Text = selectedCustomer.BirthDate.ToString("MM/dd/yyyy"); // sets saved DOB
                lblAge.Text = selectedCustomer.Age.ToString(); // sets saved age
                dgvDeposits.DataSource = selectedCustomer.DepositList; // sets Deposits 
                dgvWithdrawals.DataSource = selectedCustomer.WithdrawalList; // sets Withdrawls 
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            lblID.Text = string.Empty; // Clears text
            txtfName.Text = string.Empty;
            txtlName.Text = string.Empty;  
            txtSSN.Text = string.Empty;
            txtBDate.Text = string.Empty;
            lblAge.Text = string.Empty;
            lbxCustomers.SelectedIndex = -1; // unselects a customer from the list
            dgvDeposits.DataSource = null; // clears Deposits
            dgvWithdrawals.DataSource = null; // sets Deposits 
            lblID.Text = customers.GetNextID().ToString(); // sets next ID (highest set ID + 1)
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
                    selectedCustomer.FirstName = txtfName.Text; // sets fname
                    selectedCustomer.LastName = txtlName.Text; // sets lname
                    selectedCustomer.SSN = txtSSN.Text; // sets SSN
                    selectedCustomer.BirthDate =  DT; // sets Bdate
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
                                customer.BirthDate = DT; // sets bdate
                                customer.FirstName = txtfName.Text; // sets fname
                                customer.LastName = txtlName.Text; // sets lname
                                customer.SSN = txtSSN.Text; // sets ssn
                                customers.Add(customer); // adds customer to the customer list
                                Rebindustomers();
                            }else { MessageBox.Show("Birthdate is in incorrect format, please use MM/dd/yyyy", "ERROR"); }
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
                    customers.Remove(selectedCustomer); // removes selected customer from the customer list
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