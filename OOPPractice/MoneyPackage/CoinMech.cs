using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice.MoneyPackage
{
    class CoinMech
    {
        private CashBox cashBox = new CashBox();
        private Payment payment;

        public CoinMech()
        {
            for (int i=0; i<10; i++)
            { 
                this.cashBox.Add(new Coin(new Money(100)));
            }
        }

        public void Put(Coin coin)
        {
            this.payment = new Payment(coin);
        }

        public bool DoesNotHaveChange()
        {
            return this.payment.NeedChange() && this.cashBox.DoesNotHaveChange();
        }

        public Change Refund()
        {
            return this.payment.Refund();
        }

        public void Commit()
        {
            this.payment.Commit(this.cashBox);
        }

    }
}
