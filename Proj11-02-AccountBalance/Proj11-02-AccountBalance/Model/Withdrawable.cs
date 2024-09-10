using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj11_02_AccountBalance.Model {
    public interface Withdrawable {
        void withdraw(decimal amount);
    }
}
