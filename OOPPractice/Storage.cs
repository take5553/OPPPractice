using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
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

        public bool IsEmpty(DrinkType kindOfDrink)
        {
            return this.stocks[kindOfDrink].IsEmpty();
        }

        public void Decrement(DrinkType kindOfDrink)
        {
            this.stocks[kindOfDrink].Decrement();
        }
    }
}
