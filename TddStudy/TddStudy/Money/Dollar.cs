using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddStudy.Money
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(this.Amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            var dollar = (Dollar)obj;
            return Amount == dollar.Amount;
        }
    }
}
