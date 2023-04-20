using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJM.BankingApp.BL
{
    public class Deposit
    {
        public Deposit() { }
        public int DepositID { get; set; }
        private double Amount { get; set; }
        public string AmountFormat 
        {
            get { return Amount.ToString("c"); }
        }
        public DateTime DepositDate { get; set;}
        public void setDeposit(double amount)
        {
            Amount = amount;
        }
    }
}
