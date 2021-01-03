using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice.StoragePackage
{
    class Stock
    {
        private int quantity;

        public Stock(int quantity)
        {
            this.quantity = quantity;
        }


        public void Decrement()
        {
            this.quantity--;
        }

        public bool IsEmpty()
        {
            return quantity == 0;
        }

    }
}
