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
            // 入ってくる金額paymentが100円でないかつ500円でないならば、返金
            if((payment.DoesNotEqual(Coin.ONE_HUNDRED)) && (payment.DoesNotEqual(Coin.FIVE_HUNDRED)))
            {
                coinMech.AddChange(payment);
                return null;
            }

            // 在庫が無ければ返金
            if(storage.IsEmpty(kindOfDrink))
            {
                coinMech.AddChange(payment);
                return null;
            }

            // 500円入ってきた時、おつりとしての100円硬貨が4枚未満なら返金
            if(payment.Equals(Coin.FIVE_HUNDRED) && coinMech.DoesNotHaveChange())
            {
                coinMech.AddChange(payment);
                return null;
            }

            // ---------- 以下、入金、在庫、お釣りに問題が無い場合 ----------

            // 100円が入ってきた時は金庫にストック、500円が入ってきた時は金庫から100円4枚出す
            if (payment.Equals(Coin.ONE_HUNDRED))
            {
                coinMech.AddCoinIntoCashBox(payment);
            } else if (payment.Equals(Coin.FIVE_HUNDRED))
            {
                coinMech.AddChange(coinMech.TakeOutChange());
            }

            // ドリンクの在庫を一つ減らす
            storage.Decrement(kindOfDrink);

            // ドリンクを返す
            return new Drink(kindOfDrink);
        }



        public Change Refund()
        {
            return this.coinMech.Refund();
        }
    }
}
