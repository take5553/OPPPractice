using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPPractice.DrinkPackage;

namespace OOPPractice.StoragePackage
{
    class Storage
    {
        private Dictionary<DrinkType, Stock> stocks = new Dictionary<DrinkType, Stock>();

        public Storage()
        {
            this.stocks.Add(DrinkType.COKE, new Stock(5));
            this.stocks.Add(DrinkType.DIET_COKE, new Stock(5));
            this.stocks.Add(DrinkType.TEA, new Stock(5));
        }

        public bool DoesNotHaveStock(DrinkType drinkType)
        {
            return this.stocks[drinkType].IsEmpty();
        }

        public Drink TakeOut(DrinkType drinkType)
        {
            this.stocks[drinkType].Decrement();
            return new Drink(drinkType);
        }

    }


}
