using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class CoinMech
    {
        private CashBox cashBox = new CashBox();
        private Change change = new Change();
        private Coin coinHolder;

        public CoinMech()
        {
            for (int i = 0; i < 10; i++)
            {
                cashBox.Add(new OneHundredCoin());
            }
        }

        public void Put(Coin coin)
        {
            this.coinHolder = coin;
        }

        public bool DoesNotHaveChange()
        {
            return this.cashBox.DoesNotHaveChange();
        }

        public void Commit()
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
