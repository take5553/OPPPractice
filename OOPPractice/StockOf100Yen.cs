using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class StockOf100Yen
    {
        private Stack<Coin> numberOf100Yen = new Stack<Coin>();

        public void Push(Coin coin)
        {
            this.numberOf100Yen.Push(coin);
        }

        public int Count()
        {
            return this.numberOf100Yen.Count();
        }

        public Coin Pop()
        {
            return this.numberOf100Yen.Pop();
        }

        public bool DoesNotHaveChange()
        {
            return this.numberOf100Yen.Count() < 4;
        }

        public Change calculateChange()
        {
            Change ret = new Change();
            for (int i = 0; i < 4; i++)
            {
                ret.Add(this.numberOf100Yen.Pop());
            }
            return ret;
        }
    }
}
