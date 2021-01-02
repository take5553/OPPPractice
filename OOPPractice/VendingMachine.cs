using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class VendingMachine
    {
        Storage storage = new Storage();
        CoinMech coinMech = new CoinMech();


        public Drink Buy(Coin payment, DrinkType kindOfDrink)
        {
            if(payment.DoesNotEqual(Coin.ONE_HUNDRED) && payment.DoesNotEqual(Coin.FIVE_HUNDRED))
            {
                coinMech.AddChange(payment);
                return null;
            }

            if (storage.IsEmpty(kindOfDrink))
            {
                coinMech.AddChange(payment);
                return null;
            }

            if(payment.Equals(Coin.FIVE_HUNDRED) && coinMech.DoesNotHaveChange())
            {
                coinMech.AddChange(payment);
                return null;
            }

            if (payment.Equals(Coin.ONE_HUNDRED))
            {
                coinMech.AddCoinIntoCashBox(payment);
            } else if (payment.Equals(Coin.FIVE_HUNDRED))
            {
                coinMech.AddChange(coinMech.TakeOutChange());
            }

            storage.Decrement(kindOfDrink);

            return new Drink(kindOfDrink);
        }



        public Change Refund()
        {
            return coinMech.Refund();
        }
    }
}
