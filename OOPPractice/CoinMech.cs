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

        public CoinMech()
        {
            for (int i = 0; i < 10; i++)
            {
                cashBox.Add(new Coin(CoinType.ONE_HUNDRED));
            }
        }

        public void AddChange(Coin payment)
        {
            this.change.Add(payment);
        }

        public void AddChange(Change change)
        {
            this.change.Add(change);
        }

        public void AddCoinIntoCashBox(Coin payment)
        {
            this.cashBox.Add(payment);
        }

        public bool DoesNotHaveChange()
        {
            return this.cashBox.DoesNotHaveChange();
        }

        public Change TakeOutChange()
        {
            return this.cashBox.TakeOutChange();
        }

        public Change Refund()
        {
            Change result = new Change(change);
            change.Clear();
            return result;
        }
    }
}
