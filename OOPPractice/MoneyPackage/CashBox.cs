using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice.MoneyPackage
{
    class CashBox
    {
        private Stack<Coin> stackOfCoins = new Stack<Coin>();

        public void Add(Coin coin)
        {
            this.stackOfCoins.Push(coin);
        }

        public bool DoesNotHaveChange()
        {
            return this.stackOfCoins.Count() < 4;
        }

        public Change TakeOutChange()
        {
            Change ret = new Change();
            for (int i = 0; i < 4; i++)
            {
                ret.Add(this.stackOfCoins.Pop());
            }
            return ret;
        }
    }
}
