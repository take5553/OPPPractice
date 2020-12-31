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
            for (int i=0; i<10; i++)
            { 
                this.cashBox.Push(new Coin(new Money(100)));
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
            this.cashBox.Push(payment);
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
            Change result = change.Clone();
            change.Clear();
            return result;
        }
    }
}
