using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class VendingMachine
    {
        Stock stockOfCoke = new Stock(5);
        Stock stockOfDietCoke = new Stock(5);
        Stock stockOfTea = new Stock(5);
        StockOf100Yen stockOf100Yen = new StockOf100Yen();
        Change change = new Change();


        public Drink Buy(Coin payment, DrinkType kindOfDrink)
        {
            // 入ってくる金額paymentが100円でないかつ500円でないならば、返金
            if((payment.DoesNotEqual(Coin.ONE_HUNDRED)) && (payment.DoesNotEqual(Coin.FIVE_HUNDRED)))
            {
                change.Add(payment);
                return null;
            }

            // 在庫が無ければ返金
            if((kindOfDrink == DrinkType.COKE) && (stockOfCoke.IsEmpty()))
            {
                change.Add(payment);
                return null;
            } else if ((kindOfDrink == DrinkType.DIET_COKE) && (stockOfDietCoke.IsEmpty()))
            {
                change.Add(payment);
                return null;
            } else if ((kindOfDrink == DrinkType.TEA) && (stockOfTea.IsEmpty()))
            {
                change.Add(payment);
                return null;
            }

            // 500円入ってきた時、おつりとしての100円硬貨が4枚未満なら返金
            if(payment.Equals(Coin.FIVE_HUNDRED) && stockOf100Yen.DoesNotHaveChange())
            {
                change.Add(payment);
                return null;
            }

            // ---------- 以下、入金、在庫、お釣りに問題が無い場合 ----------

            // 100円が入ってきた時は金庫にストック、500円が入ってきた時は金庫から100円4枚出す
            if (payment.Equals(Coin.ONE_HUNDRED))
            {
                stockOf100Yen.Push(payment);
            } else if (payment.Equals(Coin.FIVE_HUNDRED))
            {
                change.Add(stockOf100Yen.calculateChange());
            }

            // ドリンクの在庫を一つ減らす
            if (kindOfDrink == DrinkType.COKE)
            {
                stockOfCoke.Decrement();
            } else if(kindOfDrink == DrinkType.DIET_COKE)
            {
                stockOfDietCoke.Decrement();
            }
            else
            {
                stockOfTea.Decrement();
            }

            // ドリンクを返す
            return new Drink(kindOfDrink);
        }



        public Change Refund()
        {
            Change result = this.change.Clone();
            change.Clear();
            return result;
        }
    }
}
