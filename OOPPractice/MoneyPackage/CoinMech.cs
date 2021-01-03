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
        private Payment payment = new Payment();

        public CoinMech()
        {
            for (int i = 0; i < 10; i++)
            {
                cashBox.Add(new OneHundredCoin());
            }
        }

        public void Put(Coin coin)
        {
            payment.Hold(coin);
        }

        public bool DoesNotHaveChange()
        {
            return this.cashBox.DoesNotHaveChange();
        }

        public void Commit()
        {
            payment.Commit(cashBox);
        }

        public Change Refund()
        {
            return payment.Refund();
        }
    }
}
