using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Change
    {
        private List<Coin> coins;

        public Change()
        {
            this.coins = new List<Coin>();
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

        public int GetAmount()
        {
            int ret = 0;
            foreach (Coin coin in this.coins)
            {
                ret += coin.Amount;
            }
            return ret;
        }

        public void Clear()
        {
            this.coins.Clear();
        }

        public Change Clone()
        {
            return (Change)MemberwiseClone();
        }
    }
}
