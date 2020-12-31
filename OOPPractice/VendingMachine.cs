using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPPractice.StoragePackage;
using OOPPractice.DrinkPackage;
using OOPPractice.MoneyPackage;

namespace OOPPractice
{
    class VendingMachine
    {
        Storage storage = new Storage();
        CoinMech coinMech = new CoinMech();


        public Drink Buy(Coin payment, DrinkType drinkType)
        {

            this.coinMech.Put(payment);

            if (this.coinMech.DoesNotHaveChange())
            {
                return null;
            }

            if (this.storage.DoesNotHaveStock(drinkType))
            {
                return null;
            }

            this.coinMech.Commit();

            // ドリンクを返す
            return this.storage.TakeOut(drinkType);
        }



        public Change Refund()
        {
            return this.coinMech.Refund();
        }
    }
}
