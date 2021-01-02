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
            if(payment.DoesNotEqual(Coin.ONE_HUNDRED) && payment.DoesNotEqual(Coin.FIVE_HUNDRED))
            {
                change.Add(payment);
                return null;
            }

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

            if(payment.Equals(Coin.FIVE_HUNDRED) && numberOf100Yen.DoesNotHaveChange())
            {
                change.Add(payment);
                return null;
            }

            if (payment.Equals(Coin.ONE_HUNDRED))
            {
                numberOf100Yen.Add(payment);
            } else if (payment.Equals(Coin.FIVE_HUNDRED))
            {
                change.Add(numberOf100Yen.TakeOutChange());
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



        public Change Refund()
        {
            Change result = new Change(change);
            change.Clear();
            return result;
        }
    }
}
