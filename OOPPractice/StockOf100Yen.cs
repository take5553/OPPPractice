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

        public int Size()
        {
            return this.numberOf100Yen.Count();
        }

        public Coin Pop()
        {
            return this.numberOf100Yen.Pop();
        }
    }
}
