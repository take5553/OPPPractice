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
        int numberOf100Yen = 10;
        List<Coin> change = new List<Coin>();


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

            if(payment.Amount == Coin.FIVE_HUNDRED && numberOf100Yen < 4)
            {
                change.Add(payment);
                return null;
            }

            if (payment.Amount == Coin.ONE_HUNDRED)
            {
                numberOf100Yen++;
            } else if (payment.Amount == Coin.FIVE_HUNDRED)
            {
                change.AddRange(calculateChange());
                numberOf100Yen -= (payment.Amount - 100) / 100;
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

        private List<Coin> calculateChange()
        {
            List<Coin> ret = new List<Coin>();
            for (int i = 0; i < 4; i++)
            {
                ret.Add(new Coin(Coin.ONE_HUNDRED));
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
