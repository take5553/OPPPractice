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
        int change = 0;


        public Drink Buy(int payment, DrinkType kindOfDrink)
        {
            if((payment != 100) && (payment != 500))
            {
                change += payment;
                return null;
            }

            if((kindOfDrink == DrinkType.COKE) && (stockOfCoke.Quantity == 0))
            {
                change += payment;
                return null;
            } else if ((kindOfDrink == DrinkType.DIET_COKE) && (stockOfDietCoke.Quantity == 0))
            {
                change += payment;
                return null;
            } else if ((kindOfDrink == DrinkType.TEA) && (stockOfTea.Quantity == 0))
            {
                change += payment;
                return null;
            }

            if(payment == 500 && numberOf100Yen < 4)
            {
                change += payment;
                return null;
            }

            if (payment == 100)
            {
                numberOf100Yen++;
            } else if (payment == 500)
            {
                change += (payment - 100);
                numberOf100Yen -= (payment - 100) / 100;
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

        public int Refund()
        {
            int result = change;
            change = 0;
            return result;
        }
    }
}
