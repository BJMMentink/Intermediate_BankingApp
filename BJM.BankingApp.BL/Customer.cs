namespace BJM.BankingApp.BL
{
    public class Customer : Person
    {
        public int CustomerID { get; set; }
        public Deposit? LastDeposit { get; set; }
        public Withdrawal? LastWithdrawl { get; set; }
        public List<Deposit>? DepositList { get; set; }
        public List<Withdrawal>? WithdrawalList { get; set;}
    }
}