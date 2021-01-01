using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Stock
    {
        public Stock(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity { get; private set; }

        public void Decrement()
        {
            this.Quantity--;
        }

    }
}
