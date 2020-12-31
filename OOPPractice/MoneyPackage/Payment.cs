using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice.MoneyPackage
{
    class Payment
    {
        private Change change;
        private Coin coin;

        public Payment(Coin coin)
        {
            this.coin = coin;
        }

        public bool NeedChange()
        {
            return this.coin.Equals(Coin.FIVE_HUNDRED);
        }

        public void Commit(CashBox cashBox)
        {
            if (this.coin.Equals(Coin.ONE_HUNDRED))
            {
                cashBox.Add(this.coin);
                this.change = new Change();
            }

            if (this.coin.Equals(Coin.FIVE_HUNDRED))
            {
                this.change = cashBox.TakeOutChange();
            }

            this.coin = null;
        }

        public Change Refund()
        {
            return this.IsNotCommited() ? new Change(this.coin) : this.change;
        }

        private bool IsNotCommited()
        {
            return this.coin != null;
        }
    }
}
