using BJM.BankingApp.PL;
using System.Data;
using System.Data.SqlClient;
namespace BJM.BankingApp.BL

{
    public class Customer : Person
    {
        public int CustomerID { get; set; }
        public Deposit? LastDeposit { get; set; }
        public Withdrawal? LastWithdrawl { get; set; }
        public List<Deposit>? DepositList { get; set; } = new List<Deposit>();
        public List<Withdrawal>? WithdrawalList { get; set;} = new List<Withdrawal>();
        public Customer()
        {

        }
        public Customer(DataRow customerRow)
        {
            CustomerID = Convert.ToInt32(customerRow["ID"]);
            FirstName = Convert.ToString(customerRow["FirstName"])!;
            LastName = Convert.ToString(customerRow["LastName"])!;
            BirthDate = Convert.ToDateTime(customerRow["BirthDate"])!;
            SSN = Convert.ToString(customerRow["SSN"])!;
        }
        public void LoadTransactionsFromDB()
        {
            

            string sql = "SELECT * FROM transactions WHERE SSN = @SSN";
            DataTable table = DataAccess.SelectFromDB(sql, GetParameters());

            foreach (DataRow row in table.Rows)
            {
                double amount = Convert.ToDouble(row["Amount"]);
                
                if (amount >= 0)
                {
                    // Amount is positive or zero
                    DepositList.Add(new Deposit(row));
                }
                else
                {
                    // Amount is negative
                    WithdrawalList.Add(new Withdrawal(row));
                }

            }
        }
        public void InsertIntoDB()
        {
            string sql = "Insert Into customers(FirstName, LastName, SSN, BirthDate) VALUES(@FirstName, @LastName, @SSN, @BirthDate); Select SCOPE_IDENTITY()";

            CustomerID = DataAccess.ExecuteSql(sql, GetParameters());
        }
        public void UpdateIntoDB()
        {
            string sql = "Update customers SET FirstName = @FirstName, LastName = @LastName, BirthDate = @BirthDate, SSN = @SSN WHERE ID = @ID";
            DataAccess.ExecuteSql(sql, GetParameters());
        }
        public void DeleteFromDB()
        {
            string sql = "DELETE from customers WHERE ID = @ID";
            DataAccess.ExecuteSql(sql, GetParameters());
        }
        private List<SqlParameter> GetParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ID", CustomerID));
            parameters.Add(new SqlParameter("@FirstName", FirstName));
            parameters.Add(new SqlParameter("@LastName", LastName));
            parameters.Add(new SqlParameter("@SSN", SSN));
            parameters.Add(new SqlParameter("@BirthDate", BirthDate));
            //parameters.Add(new SqlParameter("@Age", Age));
            return parameters;
        }
        
    }
}