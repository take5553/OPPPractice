using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class CashBox
    {
        private Stack<OneHundredCoin> stackOf100Yen = new Stack<OneHundredCoin>();
        private Stack<FiveHundredCoin> stackOf500Yen = new Stack<FiveHundredCoin>();

        public CashBox()
        {
            for (int i = 0; i < 5; i++)
            {
                stackOf100Yen.Push(new OneHundredCoin());
            }
        }

        public void Add(OneHundredCoin coin)
        {
            stackOf100Yen.Push(coin);
        }

        public void Add(FiveHundredCoin coin)
        {
            stackOf500Yen.Push(coin);
        }

        public bool DoesNotHaveChange()
        {
            return stackOf100Yen.Count < 4;
        }

        public Change TakeOutChange()
        {
            Change ret = new Change();
            for (int i = 0; i < 4; i++)
            {
                ret.Add(TakeOutOneHundredCoin());
            }
            return ret;
        }

        private OneHundredCoin TakeOutOneHundredCoin()
        {
            return stackOf100Yen.Pop();
        }

    }
}
