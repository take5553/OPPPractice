using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Change
    {
        private List<Coin> change;

        public Change()
        {
            change = new List<Coin>();
        }

        public Change(Coin coin)
        {
            change = new List<Coin>();
            change.Add(coin);
        }

        public Change(Change change)
        {
            this.change = new List<Coin>(change.change);
        }

        public void Add(Coin coin)
        {
            change.Add(coin);
        }

        public void Add(Change change)
        {
            this.change.AddRange(change.change);
        }

        public void Clear()
        {
            change.Clear();
        }

        public int GetAmount()
        {
            int ret = 0;
            foreach (Coin coin in change)
            {
                ret = ret + coin.Amount;
            }
            return ret;
        }
    }
}
