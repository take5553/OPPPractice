using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Storage
    {
        Dictionary<DrinkType, Stock> stocks = new Dictionary<DrinkType, Stock>();

        public Storage()
        {
            stocks.Add(DrinkType.COKE, new Stock(5));
            stocks.Add(DrinkType.DIET_COKE, new Stock(5));
            stocks.Add(DrinkType.TEA, new Stock(5));
        }

        public bool DoesNotHaveStock(DrinkType drinkType)
        {
            return stocks[drinkType].IsEmpty();
        }

        public Drink TakeOut(DrinkType drinkType)
        {
            stocks[drinkType].Decrement();
            return new Drink(drinkType);
        }
    }
}
