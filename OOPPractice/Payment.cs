using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Payment
    {
        private Change change = new Change();
        private Coin coinHolder;

        public void Hold(Coin coin)
        {
            coinHolder = coin;
        }

        public void Commit(CashBox cashBox)
        {
            switch (coinHolder)
            {
                case OneHundredCoin oneHundredCoin:
                    cashBox.Add(oneHundredCoin);
                    change = new Change();
                    break;
                case FiveHundredCoin fiveHundredCoin:
                    cashBox.Add(fiveHundredCoin);
                    change = cashBox.TakeOutChange();
                    break;
            }

            coinHolder = null;

        }

        public Change Refund()
        {
            Change result = new Change(change);
            change.Clear();
            return result;
        }
    }
}
