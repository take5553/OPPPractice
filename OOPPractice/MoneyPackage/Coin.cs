using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice.MoneyPackage
{
    class Coin
    {
        protected int amount;

        public Money ToMoney()
        {
            return new Money(this.amount);
        }
    }
}
