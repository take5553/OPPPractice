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

        public bool IsCoke()
        {
            return this.kind == DrinkType.COKE;
        }

        public bool IsDietCoke()
        {
            return this.kind == DrinkType.DIET_COKE;
        }

        public bool IsTea()
        {
            return this.kind == DrinkType.TEA;
        }

    }
}
