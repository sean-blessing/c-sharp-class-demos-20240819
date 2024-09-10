namespace Proj11_02_AccountBalance.Model {
    public class SavingsAccount : Account {
        public double MonthlyInterestRate { get; set; }
        public decimal MonthlyInterestPayment { get; set; }

        public SavingsAccount(decimal initialBalance, double monthlyInterestRate) {
            base.Balance = initialBalance;
            MonthlyInterestRate = monthlyInterestRate;
        }

        public void ApplyPayment() {
            // 3. Set base.Balance += MIP
            MonthlyInterestPayment = base.Balance * (decimal)MonthlyInterestRate;
            base.Balance += MonthlyInterestPayment;
        }
    }
}
