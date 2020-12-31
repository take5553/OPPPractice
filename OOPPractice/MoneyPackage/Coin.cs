using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice.MoneyPackage
{
    class Coin
    {
        public static readonly Coin ONE_HUNDRED = new Coin(new Money(100));
        public static readonly Coin FIVE_HUNDRED = new Coin(new Money(500)); 

        private Money amount;

        public Coin(Money amount)
        {
            this.amount = amount;
        }

        // TODO: Getterになっている
        public Money ToMoney()
        {
            return this.amount;
        }

        public bool Equals(Coin comparison)
        {
            return this.amount.Equals(comparison.amount);
        }

        public bool DoesNotEqual(Coin comparison)
        {
            return this.amount.DoesNotEqual(comparison.amount);
        }
    }
}
