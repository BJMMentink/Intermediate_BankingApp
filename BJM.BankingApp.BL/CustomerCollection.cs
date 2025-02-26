﻿using BJM.BankingApp.PL;
using System;
using System.Collections.Generic;
using System.Data;
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


            customer = new Customer(); // creates a hard coded test customer
            customer.CustomerID = 1;
            customer.FirstName= "Bobby";
            customer.LastName= "Robertson";
            customer.SSN = "NotClearText1";
            customer.BirthDate = new DateTime(2000, 01, 01);
            customer.WithdrawalList= withdrawalList;
            customer.DepositList= depositList;
            
            withdrawal = new Withdrawal(); // creates a hard coded withdrawl set
            withdrawal.WithdrawlID = 1;
            withdrawal.WithdrawlDate = new DateTime(2023, 04, 09);
            withdrawal.setDeposit(100.55);
            withdrawalList.Add(withdrawal);

            deposit = new Deposit(); // creates a hard coded deposit set
            deposit.DepositID = 1;
            deposit.DepositDate = new DateTime(2023, 04, 08);
            deposit.setDeposit(100.55);
            depositList.Add(deposit);
            Add(customer);

            List<Deposit> depositList1 = new List<Deposit>(); // creates new list deposit
            List<Withdrawal> withdrawalList1 = new List<Withdrawal>(); // creates new list for withdrawl
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
            withdrawal.setDeposit(1000.55);
            withdrawalList1.Add(withdrawal);
            withdrawal = new Withdrawal();
            withdrawal.WithdrawlID = 2;
            withdrawal.WithdrawlDate = new DateTime(2023, 03, 09);
            withdrawal.setDeposit(2000.55);
            withdrawalList1.Add(withdrawal);
            withdrawal = new Withdrawal();
            withdrawal.WithdrawlID = 3;
            withdrawal.WithdrawlDate = new DateTime(2023, 02, 09);
            withdrawal.setDeposit(3000.55);
            withdrawalList1.Add(withdrawal);

            deposit = new Deposit();
            deposit.DepositID = 1;
            deposit.DepositDate = new DateTime(2023, 01, 08);
            deposit.setDeposit(1001.55);
            depositList1.Add(deposit);
            deposit = new Deposit();
            deposit.DepositID = 2;
            deposit.DepositDate = new DateTime(2023, 01, 03);
            deposit.setDeposit(2001.55);
            depositList1.Add(deposit);
            deposit = new Deposit();
            deposit.DepositID = 3;
            deposit.DepositDate = new DateTime(2023, 01, 02);
            deposit.setDeposit(3001.55);
            depositList1.Add(deposit);
            Add(customer);



        }
        public CustomerCollection()
        {
            DataAccess.XMLFilePath = "customers.xml";
            DataAccess.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        public void SaveToXml()
        {
            DataAccess.SaveXML(typeof(CustomerCollection), this); // calls the saveXML
        }
        public int GetNextID()
        {
            int temp1 = 0;
            foreach (Customer customer in this) // checks every customer in this customer list
            {
                if(customer.CustomerID >= temp1) // checks if the id is greater then the last one
                {
                    temp1 = customer.CustomerID; // sets the highest id to temp1
                }
            }
            return temp1 + 1; // returns the highest id + 1

        }
        public void LoadFromDB()
        {
            string sql = "SELECT * FROM customers";
            DataTable table = DataAccess.SelectFromDB(sql);
            foreach (DataRow row in table.Rows)
            {
                Add(new Customer(row));
            }
        }
    }
}
