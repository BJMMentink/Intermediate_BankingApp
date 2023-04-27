using BJM.BankingApp.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace BJM.BankingApp.BL
{
    public class Deposit
    {
        public Deposit() { }
        public int DepositID { get; set; }
        private double Amount1 { get; set; }
        public string Amount
        {
            get {return Amount1.ToString("c"); }
        }
        public DateTime DepositDate { get; set;}
        public void setDeposit(double amount)
        {
            Amount1 = amount;
        }
        public Deposit(DataRow transactionRow)
        {
            DepositID = Convert.ToInt32(transactionRow["ID"]);
            Amount1 = Convert.ToDouble(transactionRow["Amount"])!;
            DepositDate = Convert.ToDateTime(transactionRow["Date"])!;
        }

    }
}
