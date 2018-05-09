using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddStudy.Money
{
    public class Franc
    {
        private int Amount;

        public Franc(int amount)
        {
            this.Amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(this.Amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            var franc = (Franc)obj;
            return Amount == franc.Amount;
        }
    }
}
