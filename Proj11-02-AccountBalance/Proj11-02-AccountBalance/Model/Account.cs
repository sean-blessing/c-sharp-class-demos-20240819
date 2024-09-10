using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj11_02_AccountBalance.Model {
    public class Account : Depositable, Withdrawable {
        public decimal Balance { get; set; }

        public void deposit(decimal amount) {
            Balance += amount;
        }

        public void withdraw(decimal amount) {
            Balance -= amount;
        }
    }
}
