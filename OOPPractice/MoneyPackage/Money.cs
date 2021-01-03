using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice.MoneyPackage
{
    class Money
    {
        private int amount;

        public Money(int amount)
        {
            this.amount = amount;
        }

        public Money Add(Money money)
        {
            return new Money(this.amount + money.amount);
        }

        override public string ToString()
        {
            return amount.ToString();
        }
    }
}
