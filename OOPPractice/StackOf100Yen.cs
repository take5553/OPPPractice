using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class StackOf100Yen
    {
        private Stack<Coin> numberOf100Yen = new Stack<Coin>();

        public StackOf100Yen()
        {
            for (int i = 0; i < 4; i++)
            {
                numberOf100Yen.Push(new Coin(Coin.ONE_HUNDRED));
            }
        }

        public int Count()
        {
            return numberOf100Yen.Count;
        }

        public void Add(Coin coin)
        {
            numberOf100Yen.Push(coin);
        }

        public Coin Pop()
        {
            return numberOf100Yen.Pop();
        }
    }
}
