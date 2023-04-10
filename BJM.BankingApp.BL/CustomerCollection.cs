using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJM.BankingApp.BL
{
    public class CustomerCollection : List<Customer>
    {
        public void PopulateTests()
        {
            List<Deposit> depositList = new List<Deposit>();
            List<Withdrawal> withdrawalList = new List<Withdrawal>();
            Customer customer;
            Withdrawal withdrawal;
            Deposit deposit;


            customer = new Customer();
            customer.CustomerID = 1;
            customer.FirstName= "Bobby";
            customer.LastName= "Robertson";
            customer.SSN = "NotClearText1";
            customer.BirthDate = new DateTime(2000, 01, 01);
            customer.WithdrawalList= withdrawalList;
            customer.DepositList= depositList;
            
            withdrawal = new Withdrawal();
            withdrawal.WithdrawlID = 1;
            withdrawal.WithdrawlDate = new DateTime(2023, 04, 09);
            withdrawal.Ammount = 100.55;
            withdrawalList.Add(withdrawal);

            deposit = new Deposit();
            deposit.DepositID = 1;
            deposit.DepositDate = new DateTime(2023, 04, 08);
            deposit.Ammount = 100.55;
            depositList.Add(deposit);
            Add(customer);

            List<Deposit> depositList1 = new List<Deposit>();
            List<Withdrawal> withdrawalList1 = new List<Withdrawal>();
            customer = new Customer();
            customer.CustomerID = 2;
            customer.FirstName = "Robby";
            customer.LastName = "Bobertson";
            customer.SSN = "NotClearText2";
            customer.BirthDate = new DateTime(2008, 11, 11);
            customer.WithdrawalList = withdrawalList1;
            customer.DepositList = depositList1;
            
            withdrawal = new Withdrawal();
            withdrawal.WithdrawlID = 1;
            withdrawal.WithdrawlDate = new DateTime(2023, 04, 09);
            withdrawal.Ammount = 1000.55;
            withdrawalList1.Add(withdrawal);
            withdrawal = new Withdrawal();
            withdrawal.WithdrawlID = 2;
            withdrawal.WithdrawlDate = new DateTime(2023, 03, 09);
            withdrawal.Ammount = 2000.55;
            withdrawalList1.Add(withdrawal);
            withdrawal = new Withdrawal();
            withdrawal.WithdrawlID = 3;
            withdrawal.WithdrawlDate = new DateTime(2023, 02, 09);
            withdrawal.Ammount = 3000.55;
            withdrawalList1.Add(withdrawal);

            deposit = new Deposit();
            deposit.DepositID = 1;
            deposit.DepositDate = new DateTime(2023, 01, 08);
            deposit.Ammount = 1001.55;
            depositList1.Add(deposit);
            deposit = new Deposit();
            deposit.DepositID = 2;
            deposit.DepositDate = new DateTime(2023, 01, 03);
            deposit.Ammount = 2001.55;
            depositList1.Add(deposit);
            deposit = new Deposit();
            deposit.DepositID = 3;
            deposit.DepositDate = new DateTime(2023, 01, 02);
            deposit.Ammount = 3001.55;
            depositList1.Add(deposit);
            Add(customer);



        }
        public List<Customer>? Customers { get; set; }

    }
}
