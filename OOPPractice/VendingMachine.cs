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
        StackOf100Yen numberOf100Yen = new StackOf100Yen();
        Change change = new Change();


        public Drink Buy(Coin payment, DrinkType kindOfDrink)
        {
            if((payment.Amount != Coin.ONE_HUNDRED) && (payment.Amount != Coin.FIVE_HUNDRED))
            {
                change.Add(payment);
                return null;
            }

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

            if(payment.Amount == Coin.FIVE_HUNDRED && numberOf100Yen.Count() < 4)
            {
                change.Add(payment);
                return null;
            }

            if (payment.Amount == Coin.ONE_HUNDRED)
            {
                numberOf100Yen.Add(payment);
            } else if (payment.Amount == Coin.FIVE_HUNDRED)
            {
                change.Add(calculateChange());
            }

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

            return new Drink(kindOfDrink);
        }

        private Change calculateChange()
        {
            Change ret = new Change();
            for (int i = 0; i < 4; i++)
            {
                ret.Add(numberOf100Yen.Pop());
            }
            return ret;
        }

        public Change Refund()
        {
            Change result = new Change(change);
            change.Clear();
            return result;
        }
    }
}
