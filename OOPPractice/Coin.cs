using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Coin
    {
        public static readonly Coin ONE_HUNDRED = new Coin(100);
        public static readonly Coin FIVE_HUNDRED = new Coin(500);

        private int amount;

        public Coin(int amount)
        {
            this.amount = amount;
        }

        public bool Equals(Coin comparison)
        {
            return this.amount == comparison.amount;
        }

        public bool DoesNotEqual(Coin comparison)
        {
            return this.amount != comparison.amount;
        }

        public Money ToMoney()
        {
            return new Money(this.amount);
        }
    }
}
