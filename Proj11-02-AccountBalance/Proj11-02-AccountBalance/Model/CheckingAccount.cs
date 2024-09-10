namespace Proj11_02_AccountBalance.Model {
    public class CheckingAccount : Account {

        public decimal MonthlyFee { get; set; }

        public CheckingAccount(decimal initialDeposit, decimal monthlyFee) {
            base.Balance = initialDeposit;
            MonthlyFee = monthlyFee;
        }

        public void SubtractMonthlyFee() {
            base.Balance -= MonthlyFee;
        }

    }
}
