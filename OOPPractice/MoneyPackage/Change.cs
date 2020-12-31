using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice.MoneyPackage
{
    class Change
    {
        private List<Coin> coins;

        public Change()
        {
            this.coins = new List<Coin>();
        }

        public Change(Coin coin)
        {
            this.coins = new List<Coin>();
            this.coins.Add(coin);
        }

        public Change(List<Coin> coins)
        {
            this.coins = new List<Coin>(coins);
        }

        public void Add(Coin coin)
        {
            this.coins.Add(coin);
        }

        public void Add(Change change)
        {
            this.coins.AddRange(change.coins);
        }

        public Money GetAmount()
        {
            Money ret = new Money(0);
            foreach (Coin coin in this.coins)
            {
                ret = coin.ToMoney().Add(ret);
            }
            return ret;
        }

        public void Clear()
        {
            this.coins.Clear();
        }

        public Change Clone()
        {
            Change ret = (Change)this.MemberwiseClone();
            ret.coins = new List<Coin>(coins);
            return ret;
        }
    }
}
