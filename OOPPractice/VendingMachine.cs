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
        Stack<Coin> numberOf100Yen = new Stack<Coin>();
        List<Coin> change = new List<Coin>();


        public Drink Buy(Coin payment, DrinkType kindOfDrink)
        {
            // 入ってくる金額paymentが100円でないかつ500円でないならば、返金
            if((payment.Amount != Coin.ONE_HUNDRED) && (payment.Amount != Coin.FIVE_HUNDRED))
            {
                change.Add(payment);
                return null;
            }

            // 在庫が無ければ返金
            if((kindOfDrink == DrinkType.COKE) && (stockOfCoke.Quantity == 0))
            {
                change.Add(payment);
                return null;
            } else if ((kindOfDrink == DrinkType.DIET_COKE) && (stockOfDietCoke.Quantity == 0))
            {
                change.Add(payment);
                return null;
            } else if ((kindOfDrink == DrinkType.TEA) && (stockOfTea.Quantity == 0))
            {
                change.Add(payment);
                return null;
            }

            // 500円入ってきた時、おつりとしての100円硬貨が4枚未満なら返金
            if(payment.Amount == Coin.FIVE_HUNDRED && numberOf100Yen.Count < 4)
            {
                change.Add(payment);
                return null;
            }

            // ---------- 以下、入金、在庫、お釣りに問題が無い場合 ----------

            // 100円が入ってきた時は金庫にストック、500円が入ってきた時は金庫から100円4枚出す
            if (payment.Amount == Coin.ONE_HUNDRED)
            {
                numberOf100Yen.Push(payment);
            } else if (payment.Amount == Coin.FIVE_HUNDRED)
            {
                change.AddRange(calculateChange());
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

        private List<Coin> calculateChange()
        {
            List<Coin> ret = new List<Coin>();
            for (int i = 0; i < 4; i++)
            {
                ret.Add(numberOf100Yen.Pop());
            }
            return ret;
        }

        public List<Coin> Refund()
        {
            List<Coin> result = new List<Coin>(change);
            change.Clear();
            return result;
        }
    }
}
