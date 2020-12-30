using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Drink
    {

        private DrinkType kind;

        public Drink(DrinkType kind)
        {
            this.kind = kind;
        }

        public DrinkType Kind
        {
            get
            {
                return this.kind;
            }
        }

    }
}
