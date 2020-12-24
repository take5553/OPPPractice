using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Stock
    {
        private int quantity;

        public Stock(int quantity)
        {
            this.quantity = quantity;
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }
        }

        public void Decrement()
        {
            this.quantity--;
        }
    }
}
