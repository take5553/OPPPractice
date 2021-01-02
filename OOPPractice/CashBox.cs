﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class CashBox
    {
        private Stack<Coin> numberOf100Yen = new Stack<Coin>();


        public void Add(Coin coin)
        {
            numberOf100Yen.Push(coin);
        }

        public bool DoesNotHaveChange()
        {
            return numberOf100Yen.Count < 4;
        }

        public Change TakeOutChange()
        {
            Change ret = new Change();
            for (int i = 0; i < 4; i++)
            {
                ret.Add(numberOf100Yen.Pop());
            }
            return ret;
        }
    }
}