using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice.MoneyPackage
{
    class Change
    {
        private List<Coin> change;

        public Change()
        {
            change = new List<Coin>();
        }

        public Change(Change change)
        {
            this.change = new List<Coin>(change.change);
        }

        public void Add(Coin coin)
        {
            change.Add(coin);
        }

        public void Clear()
        {
            change.Clear();
        }

        public Money GetAmount()
        {
            Money ret = new Money(0);
            foreach (Coin coin in change)
            {
                ret = ret.Add(coin.ToMoney());
            }
            return ret;
        }
    }
}
