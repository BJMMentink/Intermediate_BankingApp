using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJM.BankingApp.BL
{
    public class Withdrawal
    {
        public Withdrawal() { }
        public int WithdrawlID { get; set; }
        private double Amount1 { get; set; }
        public string Amount
        {
            get 
            {
                Amount1 = Amount1 * -1;
                return Amount1.ToString("c");
            }
        }
        public DateTime WithdrawlDate { get; set; }
        public void setDeposit(double amount)
        {
            Amount1 = amount;
        }
        public Withdrawal(DataRow transactionRow)
        {
            WithdrawlID = Convert.ToInt32(transactionRow["ID"]);
            Amount1 = Convert.ToDouble(transactionRow["Amount"])!;
            WithdrawlDate = Convert.ToDateTime(transactionRow["Date"])!;
        }
    }
}
