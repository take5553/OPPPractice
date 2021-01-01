using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Coin
    {
        public const int ONE_HUNDRED = 100;
        public const int FIVE_HUNDRED = 500;

        public Coin(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; private set; }
    }
}
