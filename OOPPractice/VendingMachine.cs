using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPPractice.MoneyPackage;
using OOPPractice.StoragePackage;

namespace OOPPractice
{
    class VendingMachine
    {
        Storage storage = new Storage();
        CoinMech coinMech = new CoinMech();


        public Drink Buy(Coin payment, DrinkType kindOfDrink)
        {
            coinMech.Put(payment);

            if (coinMech.DoesNotHaveChange())
            {
                return null;
            }

            if (storage.DoesNotHaveStock(kindOfDrink))
            {
                return null;
            }

            coinMech.Commit();

            return storage.TakeOut(kindOfDrink);
        }



        public Change Refund()
        {
            return coinMech.Refund();
        }
    }
}
