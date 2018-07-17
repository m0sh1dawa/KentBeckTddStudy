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
            currency = "USD";
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(this.Amount * multiplier);
        }
    }
}
