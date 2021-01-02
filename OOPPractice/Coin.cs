using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Coin
    {
        public static readonly Coin ONE_HUNDRED = new Coin(CoinType.ONE_HUNDRED);
        public static readonly Coin FIVE_HUNDRED = new Coin(CoinType.FIVE_HUNDRED);

        private int amount;

        public Coin(CoinType amount)
        {
            this.amount = (int)amount;
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
