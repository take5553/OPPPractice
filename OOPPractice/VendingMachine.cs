using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class VendingMachine
    {
        int quantityOfCoke = 5;
        int quantityOfDietCoke = 5;
        int quantityOfTea = 5;
        int numberOf100Yen = 10;
        int charge = 0;


        public Drink Buy(int payment, int kindOfDrink)
        {
            if((payment != 100) && (payment != 500))
            {
                charge += payment;
                return null;
            }

            if((kindOfDrink == Drink.COKE) && (quantityOfCoke == 0))
            {
                charge += payment;
                return null;
            } else if ((kindOfDrink == Drink.DIET_COKE) && (quantityOfDietCoke == 0))
            {
                charge += payment;
                return null;
            } else if ((kindOfDrink == Drink.TEA) && (quantityOfTea == 0))
            {
                charge += payment;
                return null;
            }

            if(payment == 500 && numberOf100Yen < 4)
            {
                charge += payment;
                return null;
            }

            if (payment == 100)
            {
                numberOf100Yen++;
            } else if (payment == 500)
            {
                charge += (payment - 100);
                numberOf100Yen -= (payment - 100) / 100;
            }

            if (kindOfDrink == Drink.COKE)
            {
                quantityOfCoke--;
            } else if(kindOfDrink == Drink.DIET_COKE)
            {
                quantityOfDietCoke--;
            }
            else
            {
                quantityOfTea--;
            }

            return new Drink(kindOfDrink);
        }

        public int Refund()
        {
            int result = charge;
            charge = 0;
            return result;
        }
    }
}
